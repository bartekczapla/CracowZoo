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

namespace CracowZoo.ViewModels
{
    public class AnimalGroupsPageViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;
        public ICommand ExecuteNavigate { get; }
        public ICommand MenuButton { get; }
        private bool isNavigating { get; set; }

        public AnimalGroupsPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
            : base(navigationService)
        {
            _eventAggregator = eventAggregator;

            ExecuteNavigate = new DelegateCommand<object>(ExecuteNavigateCommand);
            MenuButton = new DelegateCommand(ShowMenu);
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

        private void ShowMenu()
        {
            _eventAggregator.GetEvent<MyEvent>().Publish();
        }
    }
}
