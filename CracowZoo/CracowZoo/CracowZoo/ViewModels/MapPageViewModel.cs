using CracowZoo.Views;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using System;
using System.Windows.Input;
using Unity;

namespace CracowZoo.ViewModels
{
    public class MapPageViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;
        public ICommand MenuButton { get; }    

        public MapPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
            : base(navigationService)
        {
            _eventAggregator = eventAggregator;

            MenuButton = new DelegateCommand(ShowMenu);
        }

        private void ShowMenu()
        {
            _eventAggregator.GetEvent<MyEvent>().Publish();
        }

    }
}
