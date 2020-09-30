using CracowZoo.Interfaces;
using CracowZoo.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

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

            var zooEventDates = (await GetZooEvents(GetDayOfWeekFromTabPageTitle(_dayName)))
                                 .OrderBy((ZooEventDate entity) => entity.Time);

            CurrenDayEvents = new ObservableCollection<ZooEventDate>(zooEventDates);
        }

        private async Task<IEnumerable<ZooEventDate>> GetZooEvents(DayOfWeek dayOfWeek)
        {
            return await _repository.GetManyAsync<ZooEventDate>(
                     (ZooEventDate entity) => entity.Day == dayOfWeek,
                    null,
                    new string[] { "ZooEvent" });
        }

        private DayOfWeek GetDayOfWeekFromTabPageTitle(string _dayName)
        {
            switch(_dayName)
            {
                case "Jutro":
                    return DateTime.Today.AddDays(1).DayOfWeek;
                case "Pojutrze":
                    return DateTime.Today.AddDays(2).DayOfWeek;
                case "Dzisiaj":
                default:
                    return DateTime.Today.DayOfWeek;

            }
        }
    }
}
