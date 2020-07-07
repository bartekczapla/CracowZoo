using CracowZoo.Interfaces;
using CracowZoo.Models;
using CracowZoo.Models.Aditionals;
using CracowZoo.Views;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CracowZoo.ViewModels
{
    public class AnimalGroupsPageViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IRepository _zooRepo;
        public ICommand ExecuteNavigate { get; }
        public ICommand MenuButton { get; }
        public ICommand EntryChanged { get; }
        public ICommand FoundAnimalTapped { get; }

        private bool isNavigating { get; set; }

        private ObservableCollection<Animal> _foundAnimals;
        public ObservableCollection<Animal> FoundAnimals
        {
            get => _foundAnimals;
            set => SetProperty(ref _foundAnimals, value);
        }

        private Animal _selectedFoundAnimal;
        public Animal SelectedFoundAnimal
        {
            get => _selectedFoundAnimal;
            set => SetProperty(ref _selectedFoundAnimal, value);
        }

        private string _entryText;
        public string EntryText 
        {
            get => _entryText;
            set => SetProperty(ref _entryText, value);
        }

        public AnimalGroupsPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator,
            IRepository zooRepo)
            : base(navigationService)
        {
            _zooRepo = zooRepo;
            _eventAggregator = eventAggregator;

            ExecuteNavigate = new DelegateCommand<object>(ExecuteNavigateCommand);
            FoundAnimalTapped = new DelegateCommand(NavigateToSpecificAnimal);
            MenuButton = new DelegateCommand(ShowMenu);
            EntryChanged = new DelegateCommand(SearchForAnimals);
            isNavigating = false;
        }

        private async void SearchForAnimals()
        {
            FoundAnimals = new ObservableCollection<Animal>();
            IEnumerable<Animal> animals = await _zooRepo.GetManyAsync<Animal>((Animal entity) => 
                entity.Name.ToLower().Contains(EntryText.ToLower()), new OrderElementDescription("Name", true),
                 new string[] { "MapItem", "AnimalTidbits" });
            animals.ForEach((Animal animal) => FoundAnimals.Add(animal));
        }

        private async void NavigateToSpecificAnimal()
        {
            var parameters = new NavigationParameters();
            parameters.Add("selectedAnimal", SelectedFoundAnimal);
            await NavigationService.NavigateAsync(nameof(AnimalDetailsPage), parameters);
            EntryText = string.Empty;
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            isNavigating = false;
            base.OnNavigatedTo(parameters);
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            isNavigating = false;
            base.OnNavigatedFrom(parameters);
        }

        async void ExecuteNavigateCommand(object animalGroupObject)
        {
            if(isNavigating)
            {
                return;
            }
            isNavigating = true;
            var parameters = new NavigationParameters();
            parameters.Add("animalGroup", animalGroupObject);
            await NavigationService.NavigateAsync(nameof(AnimalsPage), parameters);

        }

        private void ShowMenu()
        {
            _eventAggregator.GetEvent<MyEvent>().Publish();
        }
    }
}
