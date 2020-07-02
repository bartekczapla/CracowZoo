using CracowZoo.DataAccess.Interfaces;
using CracowZoo.Models;
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

        public AnimalGroupsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Zwierzęta";
            ExecuteNavigate = new DelegateCommand<object>(ExecuteNavigateCommand);
        }

        async void ExecuteNavigateCommand(object animalGroupObject)
        {
            var parameters = new NavigationParameters();
            parameters.Add("animalGroup", animalGroupObject);
            await NavigationService.NavigateAsync(nameof(AnimalsPage), parameters);

        }
    }
}
