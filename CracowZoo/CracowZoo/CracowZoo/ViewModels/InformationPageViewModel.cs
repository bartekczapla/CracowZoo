﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CracowZoo.ViewModels
{
    public class InformationPageViewModel : ViewModelBase
    {
        public InformationPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
