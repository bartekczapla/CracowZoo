using Prism;
using Prism.Ioc;
using CracowZoo.ViewModels;
using CracowZoo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using CracowZoo.Interfaces;

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
            await NavigationService.NavigateAsync($"{nameof(MenuPage)}/{nameof(NavigationPage)}/{nameof(MapPage)}");
        }

        private async void AskForPermissions()
        {
            await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MapPage, MapPageViewModel>();
            containerRegistry.RegisterForNavigation<MenuPage, MenuPageViewModel>();
            containerRegistry.RegisterForNavigation<AnimalGroupsPage, AnimalGroupsPageViewModel>();
            containerRegistry.RegisterForNavigation<AnimalsPage, AnimalsPageViewModel>();
            containerRegistry.RegisterForNavigation<AnimalDetailsPage, AnimalDetailsPageViewModel>();
        }
    }
}
