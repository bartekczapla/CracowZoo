using CracowZoo.PlatformCore;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;

namespace CracowZoo.ViewModels
{
    public class SettingsPageViewModel : ViewModelBase
    {
        private readonly IPlatformSettingsProvider _platformSettingsProvider;
        public ICommand ExecuteDeleteDb { get; }

        public SettingsPageViewModel(INavigationService navigationService, IPlatformSettingsProvider platformSettingsProvider) : base(navigationService)
        {
            _platformSettingsProvider = platformSettingsProvider;
            ExecuteDeleteDb = new DelegateCommand(ExecuteDeleteDbCommand);
        }

        void ExecuteDeleteDbCommand()
        {
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "cracowZoo.db");
            if (File.Exists(path))
            {
                File.Delete(path);
            }

        }
    }
}
