using CracowZoo.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms.Xaml;

namespace CracowZoo.ViewModels
{
    public class AnimalDetailsPageViewModel : ViewModelBase
    {
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

        public AnimalDetailsPageViewModel(INavigationService navigationService)
        : base(navigationService)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            SelectedAnimal = parameters.GetValue<Animal>("selectedAnimal");
            AnimalTidbits = SelectedAnimal.AnimalTidbits;
            base.OnNavigatedTo(parameters);
        }
    }
}
