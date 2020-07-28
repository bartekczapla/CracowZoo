using CracowZoo.Models;
using CracowZoo.Views;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CracowZoo.ViewModels
{
    public class MenuPageViewModel: BindableBase
    {
        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;

        public ObservableCollection<CustomMenuItem> MenuItems { get; set; }

        private CustomMenuItem selectedMenuItem;
        public CustomMenuItem SelectedMenuItem
        {
            get => selectedMenuItem;
            set => SetProperty(ref selectedMenuItem, value);
        }

        private bool _showMenu;
        public bool ShowMenu
        {
            get => _showMenu;
            set => SetProperty(ref _showMenu, value);
        }

        public DelegateCommand NavigateCommand { get; private set; }

        public MenuPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            _navigationService = navigationService;
            _eventAggregator = eventAggregator;

            MenuItems = new ObservableCollection<CustomMenuItem>();

            MenuItems.Add(new CustomMenuItem()
            {
                Icon = ((char)0xf279).ToString(),
                PageName = nameof(MapPage),
                Title = "Mapa"
            });
            MenuItems.Add(new CustomMenuItem()
            {
                Icon = ((char)0xf6ed).ToString(),
                PageName = nameof(AnimalGroupsPage),
                Title = "Zwierzęta"
            });
            MenuItems.Add(new CustomMenuItem()
            {
                Icon = ((char)0xf017).ToString(),
                PageName = nameof(EventsPage),
                Title = "Wydarzenia / pokazy"
            });
            MenuItems.Add(new CustomMenuItem()
            {
                Icon = ((char)0xf05a).ToString(),
                PageName = nameof(InformationPage),
                Title = "Informacje"
            });
            MenuItems.Add(new CustomMenuItem()
            {
                Icon = ((char)0xf0d6).ToString(),
                PageName = nameof(TicketsPage),
                Title = "Bilety"
            });
            MenuItems.Add(new CustomMenuItem()
            {
                Icon = ((char)0xf0d6).ToString(),
                PageName = nameof(SettingsPage),
                Title = "Ustawienia"
            });
            //MenuItems.Add(new CustomMenuItem()
            //{
            //    Icon = ((char)0xf013).ToString(),
            //    PageName = nameof(AnimalGroupsPage),
            //    Title = "Ustawienia"
            //});

            NavigateCommand = new DelegateCommand(Navigate);

            _eventAggregator.GetEvent<MyEvent>().Publish();
        }

        async void Navigate()
        {
            _eventAggregator.GetEvent<MyEvent>().Publish();

            await Task.Delay(250);
            await _navigationService.NavigateAsync(nameof(NavigationPage) + "/" + SelectedMenuItem.PageName);      
        }
    }
}
