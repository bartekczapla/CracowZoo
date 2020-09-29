using CracowZoo.Helpers;
using CracowZoo.Interfaces;
using CracowZoo.Models;
using CracowZoo.Models.Aditionals;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace CracowZoo.ViewModels
{
    public class EventsPageViewModel : ViewModelBase
    {
        private readonly IRepository _repository;
        public ObservableCollection<ZooEventDate> ZooEvents { get; } = new ObservableCollection<ZooEventDate>();
        private bool _pageLoading = true;
        public bool PageLoading
        {
            get => _pageLoading;
            set => SetProperty(ref _pageLoading, value);
        }

        private bool _isTodayAnyEvent = true;
        public bool IsTodayAnyEvent
        {
            get => _isTodayAnyEvent;
            set => SetProperty(ref _isTodayAnyEvent, value);
        }

        public EventsPageViewModel(INavigationService navigationService, IRepository repository) : base(navigationService)
        {
            _repository = repository;
            Title = "Wydarzenia";
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            PageLoading = true;
            var zooEventDates = await GetTodaysEvents();
            IsTodayAnyEvent = zooEventDates.Count() > 0;
            if(!IsTodayAnyEvent)
            {
                zooEventDates = await GetTomorrowEvents();
            }
            ZooEvents.AddCollection(zooEventDates);

             PageLoading = false;
            base.OnNavigatedTo(parameters);
        }

        private async Task<IEnumerable<ZooEventDate>> GetTodaysEvents()
        {
            var now = new DateTime();
            return await _repository.GetManyAsync<ZooEventDate>(
                     (ZooEventDate entity) => (int)entity.Day == (int)now.DayOfWeek,
                    null,
                    new string[] { "ZooEvent" });
        }
        private async Task<IEnumerable<ZooEventDate>> GetTomorrowEvents()
        {
            var tommorow = new DateTime().AddDays(1);
            return await _repository.GetManyAsync<ZooEventDate>(
                     (ZooEventDate entity) => (int)entity.Day == (int)tommorow.DayOfWeek,
                    null,
                    new string[] { "ZooEvent" });
        }
    }
}
