using CracowZoo.Core;
using CracowZoo.DataAccess;
using CracowZoo.DataAccess.Entity;
using CracowZoo.DataAccess.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CracowZoo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
  
            Title = "Main Page";
                           
        }

    }
}
