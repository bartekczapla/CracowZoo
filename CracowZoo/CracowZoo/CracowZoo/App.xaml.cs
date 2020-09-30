using Prism;
using Prism.Ioc;
using CracowZoo.ViewModels;
using CracowZoo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using CracowZoo.Interfaces;
using static CracowZoo.Models.AppSettings;
using System.Diagnostics.Tracing;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CracowZoo
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) 
        {

        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            AskForPermissions();
            SetInitialAppPreferences();
            await NavigationService.NavigateAsync($"{nameof(MenuPage)}/{nameof(NavigationPage)}/{nameof(MapPage)}");
        }

        private async void AskForPermissions()
        {
            await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            await Permissions.RequestAsync<Permissions.Camera>();
        }

        private void SetInitialAppPreferences()
        {
            if (!Preferences.ContainsKey("showNotifications"))
                Preferences.Set("showNotifications", false);

            if (!Preferences.ContainsKey("showLocations"))
                Preferences.Set("showLocations", "Wszystko");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MapPage, MapPageViewModel>();
            containerRegistry.RegisterForNavigation<MenuPage, MenuPageViewModel>();
            containerRegistry.RegisterForNavigation<AnimalGroupsPage, AnimalGroupsPageViewModel>();
            containerRegistry.RegisterForNavigation<AnimalsPage, AnimalsPageViewModel>();
            containerRegistry.RegisterForNavigation<AnimalDetailsPage, AnimalDetailsPageViewModel>();
            containerRegistry.RegisterForNavigation<InformationPage, InformationPageViewModel>();
            //containerRegistry.RegisterForNavigation<EventsPage, EventsPageViewModel>();
            containerRegistry.RegisterForNavigation<TicketsPage, TicketsPageViewModel>();
            containerRegistry.RegisterForNavigation<SettingsPage, SettingsPageViewModel>();
            containerRegistry.RegisterForNavigation<ZooEventsPage, ZooEventsPageViewModel>();
            //containerRegistry.RegisterForNavigation<EventDayPage, EventDayViewModel>();
        }
    }
}
