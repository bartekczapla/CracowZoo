using CracowZoo.Models;
using CracowZoo.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace CracowZoo.ViewModels
{
    public class MenuPageViewModel: BindableBase
    {
        private INavigationService _navigationService;

        public ObservableCollection<CustomMenuItem> MenuItems { get; set; }

        private CustomMenuItem selectedMenuItem;
        public CustomMenuItem SelectedMenuItem
        {
            get => selectedMenuItem;
            set => SetProperty(ref selectedMenuItem, value);
        }
        public DelegateCommand NavigateCommand { get; private set; }

        public MenuPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

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
                Icon = ((char)0xf3ff).ToString(),
                PageName = nameof(AnimalGroupsPage),
                Title = "Bilety"
            });
            MenuItems.Add(new CustomMenuItem()
            {
                Icon = ((char)0xf013).ToString(),
                PageName = nameof(AnimalGroupsPage),
                Title = "Ustawienia"
            });

            NavigateCommand = new DelegateCommand(Navigate);
        }

        async void Navigate()
        {
            await _navigationService.NavigateAsync(nameof(NavigationPage) + "/" + SelectedMenuItem.PageName);
        }
    }
}
