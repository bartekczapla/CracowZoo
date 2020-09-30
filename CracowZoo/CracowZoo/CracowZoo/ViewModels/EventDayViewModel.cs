using CracowZoo.Interfaces;
using CracowZoo.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;

namespace CracowZoo.ViewModels
{
    public class EventDayViewModel : ViewModelBase
    {
        private readonly IRepository _repository;

        private string _dayName;

        private ObservableCollection<ZooEventDate> _currenDayEvents;
        public ObservableCollection<ZooEventDate> CurrenDayEvents 
        {
            get => _currenDayEvents;
            set => SetProperty(ref _currenDayEvents, value);
        }

        public EventDayViewModel(INavigationService navigationService, IRepository repository, string dayName) : base(navigationService)
        {
            _repository = repository;
            _dayName = dayName;
        }

        public async override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);

            DayOfWeek dayToSelect = DateTime.Today.DayOfWeek;

            if (_dayName == "Dzisiaj")
                dayToSelect = DateTime.Today.DayOfWeek;
            else if(_dayName == "Jutro")
                dayToSelect = DateTime.Today.AddDays(1).DayOfWeek;
            else if (_dayName == "Pojutrze")
                dayToSelect = DateTime.Today.AddDays(2).DayOfWeek;

            CurrenDayEvents = new ObservableCollection<ZooEventDate>((await _repository.GetManyAsync<ZooEventDate>(
                     (ZooEventDate entity) => entity.Day == dayToSelect,
                    null,
                    new string[] { "ZooEvent" })).OrderBy(eventDate => eventDate.Time));
        }
    }
}
