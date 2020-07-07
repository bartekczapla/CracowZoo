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
using System.Dynamic;
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
            get => _selectedAnimal;
            set
            {
                SetProperty(ref _selectedAnimal, value);
                if(value != null)
                {
                    NavigateToAnimalDetails();
                }           
            }
        }

        private bool _pageLoading = true;
        public bool PageLoading
        {
            get => _pageLoading;
            set => SetProperty(ref _pageLoading, value);
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
            PageLoading = true;

            IEnumerable<Animal> animals = new List<Animal>();

            if (AnimalGroup > 0)
            {
                animals = await _repository.GetManyAsync<Animal>((Animal entity) => 
                        entity.Group == (AnimalGroup)AnimalGroup, new OrderElementDescription("Name", true), 
                        new string[] { "MapItem", "AnimalTidbits" });
                
            }
            else if(AnimalGroup == -1)
            {
                animals = await _repository.GetManyAsync<Animal>(null, new OrderElementDescription("Name", true),
                        new string[] { "MapItem", "AnimalTidbits" });
            }

            animals.ForEach((Animal animal) => Animals.Add(animal));

            PageLoading = false;
        }

        async void NavigateToAnimalDetails()
        {
            var parameters = new NavigationParameters();
            parameters.Add("selectedAnimal", SelectedAnimal);
            await NavigationService.NavigateAsync(nameof(AnimalDetailsPage), parameters);
        }
    }
}
