using CracowZoo.Interfaces;
using CracowZoo.Models;
using CracowZoo.Models.Aditionals;
using CracowZoo.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms.Xaml;

namespace CracowZoo.ViewModels
{
    public class AnimalDetailsPageViewModel : ViewModelBase
    {
        private readonly IRepository _repository;

        public ICommand GoToAnimalButtonClicked { get; }

        private Animal _selectedAnimal;
        public Animal SelectedAnimal 
        { 
            get => _selectedAnimal;
            set => SetProperty(ref _selectedAnimal, value);
        }

        private ICollection<AnimalTidbit> _animalTidbits;
        public ICollection<AnimalTidbit> AnimalTidbits
        {
            get => _animalTidbits;
            set => SetProperty(ref _animalTidbits, value);
        }

        private bool _pageLoading = true;
        public bool PageLoading
        {
            get => _pageLoading;
            set => SetProperty(ref _pageLoading, value);
        }

        public AnimalDetailsPageViewModel(INavigationService navigationService, IRepository repository)
        : base(navigationService)
        {
            _repository = repository;

            GoToAnimalButtonClicked = new DelegateCommand(GoToAnimal, () => true);
        }

        private async void GoToAnimal()
        {
            if (SelectedAnimal.MapItem == null)
                return;

            var parameters = new NavigationParameters
                {
                    { "goToAnimal", SelectedAnimal.MapItem.Name }
                };
            
            await NavigationService.NavigateAsync(new Uri("/MenuPage/NavigationPage/MapPage"), parameters);
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            PageLoading = true;
            if (parameters.ContainsKey("selectedAnimal"))
            {
                SelectedAnimal = parameters.GetValue<Animal>("selectedAnimal");
                AnimalTidbits = SelectedAnimal.AnimalTidbits;
            }
            else if (parameters.ContainsKey("mapItemId"))
            {
                var mapItemId = parameters.GetValue<int>("mapItemId");
                SelectedAnimal = await GetAnimalDetails(mapItemId);
                AnimalTidbits = SelectedAnimal.AnimalTidbits;
            }

            PageLoading = false;
            base.OnNavigatedTo(parameters);
        }

        private async Task<Animal> GetAnimalDetails(int mapItemId)
        {
            return await _repository.GetAsync<Animal>((Animal entity) =>
                        entity.MapItemId == mapItemId, 
                        new string[] { "MapItem", "AnimalTidbits" });
        }
    }
}
