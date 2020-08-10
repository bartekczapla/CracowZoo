using CracowZoo.Interfaces.CrossServices;
using CracowZoo.PlatformCore;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CracowZoo.ViewModels
{
    public class SettingsPageViewModel : ViewModelBase
    {
        private readonly IPlatformSettingsProvider _platformSettingsProvider;

        public ICommand SendFeedbackTapped { get; }

        //This preference was initially set in App.xaml.cs
        public bool ShowNotifications
        {
            get => Preferences.Get("showNotifications", false);
            set => Preferences.Set("showNotifications", value);
        }

        public string LocationsToShow
        {
            get => Preferences.Get("showLocations", "Wszystko");
            set => Preferences.Set("showLocations", value);
        }

        public string AppVersion => DependencyService.Get<IAppVersion>().GetVersion();

        public SettingsPageViewModel(INavigationService navigationService, IPlatformSettingsProvider platformSettingsProvider) : base(navigationService)
        {
            _platformSettingsProvider = platformSettingsProvider;

            SendFeedbackTapped = new DelegateCommand(SendFeedback);
        }

        private async void SendFeedback()
        {
            //TODO Add sending feedback
        }
    }
}
