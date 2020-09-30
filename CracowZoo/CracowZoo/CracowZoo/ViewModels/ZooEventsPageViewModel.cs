using CracowZoo.Interfaces;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CracowZoo.ViewModels
{
    public class ZooEventsPageViewModel : ViewModelBase
    {
        private readonly IRepository _repository;

        public EventDayViewModel TodayVm { get; set; }
        public EventDayViewModel TomorrowVm { get; set; }
        public EventDayViewModel AfterTomorrowVm { get; set; }

        public ZooEventsPageViewModel(INavigationService navigationService, IRepository repository) : base(navigationService)
        {
            _repository = repository;
            Title = "Wydarzenia";

            TodayVm = new EventDayViewModel(navigationService, repository, "Dzisiaj");
            TomorrowVm = new EventDayViewModel(navigationService, repository, "Jutro");
            AfterTomorrowVm = new EventDayViewModel(navigationService, repository, "Pojutrze");
        }
    }
}
