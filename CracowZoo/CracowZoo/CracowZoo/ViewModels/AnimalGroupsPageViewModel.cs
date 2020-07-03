using CracowZoo.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace CracowZoo.ViewModels
{
    public class AnimalGroupsPageViewModel : ViewModelBase
    {
        public DelegateCommand<object> ExecuteNavigate { get; private set; }
        private bool isNavigating { get; set; }

        public AnimalGroupsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Zwierzęta";
            ExecuteNavigate = new DelegateCommand<object>(ExecuteNavigateCommand);
            isNavigating = false;
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
    }
}
