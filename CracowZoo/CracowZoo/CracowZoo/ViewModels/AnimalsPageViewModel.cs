using CracowZoo.Enums;
using CracowZoo.Interfaces;
using CracowZoo.Models;
using CracowZoo.Models.Aditionals;
using CracowZoo.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using static CracowZoo.Helpers.EnumHelper;

namespace CracowZoo.ViewModels
{
    public class AnimalsPageViewModel : ViewModelBase
    {
        private readonly IRepository _repository;
        public int AnimalGroup { get; set; }
        public ObservableCollection<Animal> Animals { get; } = new ObservableCollection<Animal>();

        private Animal _selectedAnimal;
        public Animal SelectedAnimal
        {
            get
            {
                return _selectedAnimal;
            }
            set
            {
                SetProperty(ref _selectedAnimal, value);
                if(value != null)
                {
                    NavigateToAnimalDetails();
                }           
            }
        }
        public AnimalsPageViewModel(INavigationService navigationService, IRepository repository)
            :base(navigationService)
        {
            _repository = repository;
            Title = "Zwierzęta";
            AnimalGroup = -1;
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {    
            if(parameters.ContainsKey("animalGroup"))
            {
                AnimalGroup = parameters.GetValue<int>("animalGroup");
                GetAnimals();
            }
            SelectedAnimal = null;         
            base.OnNavigatedTo(parameters);
        }

        private async void GetAnimals()
        {
            if (AnimalGroup > 0)
            {
                IEnumerable<Animal> animals = await _repository.GetManyAsync<Animal>((Animal entity) => entity.Group == (AnimalGroup)AnimalGroup, new OrderElementDescription("Name", true), new string[] { "MapItem", "AnimalTidbits" });
                animals.ForEach((Animal animal) => Animals.Add(animal));
            }
        }

        async void NavigateToAnimalDetails()
        {
            var parameters = new NavigationParameters();
            parameters.Add("selectedAnimal", SelectedAnimal);
            await NavigationService.NavigateAsync(nameof(AnimalDetailsPage), parameters);

        }
    }
}
