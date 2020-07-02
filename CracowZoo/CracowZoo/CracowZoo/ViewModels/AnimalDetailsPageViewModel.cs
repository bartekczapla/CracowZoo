using CracowZoo.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CracowZoo.ViewModels
{
    public class AnimalDetailsPageViewModel : ViewModelBase
    {
        private Animal _selectedAnimal;
        public Animal SelectedAnimal { 
            get
            {
                return _selectedAnimal;
            }
            set
            {
                SetProperty(ref _selectedAnimal, value);
            }
        }
        public AnimalDetailsPageViewModel(INavigationService navigationService)
        : base(navigationService)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            SelectedAnimal = parameters.GetValue<Animal>("selectedAnimal");   
            base.OnNavigatedTo(parameters);
        }
    }
}
