using CracowZoo.DataAccess.Interfaces;
using CracowZoo.Enums;
using CracowZoo.Models;
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
        private readonly IRepository<Animal> _animalRepository;
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
                NavigateToAnimalDetails();
            }
        }
        public AnimalsPageViewModel(INavigationService navigationService, IRepository<Animal> animalRepository)
            :base(navigationService)
        {
            _animalRepository = animalRepository;
            Title = "Zwierzęta";
            AnimalGroup = -1;
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {          
            AnimalGroup = parameters.GetValue<int>("animalGroup");
            GetAnimals();
            base.OnNavigatedTo(parameters);
        }

        private async void GetAnimals()
        {
            if (AnimalGroup > 0)
            {
                IEnumerable<Animal> animals = await _animalRepository.GetAsync((Animal entity) => entity.Group == (AnimalGroup)AnimalGroup);
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
