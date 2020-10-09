using CracowZoo.Helpers;
using CracowZoo.Interfaces;
using CracowZoo.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Essentials;

namespace CracowZoo.ViewModels
{
    public class TicketsPageViewModel : ViewModelBase
    {
        private readonly IRepository _repository;
        public ObservableCollection<Ticket> Tickets { get; } = new ObservableCollection<Ticket>();

        public ICommand OpenInfoWebPageButton { get; }

        public TicketsPageViewModel(INavigationService navigationService, IRepository repository) : base(navigationService)
        {
            _repository = repository;

            OpenInfoWebPageButton = new DelegateCommand(OpenInfoWebPage);
        }

        private async void OpenInfoWebPage()
        {
            string uri = @"https://zoo-krakow.pl/ceny-biletow-regulamin-zwiedzania/";

            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            IEnumerable<Ticket> tickets = await _repository.GetManyAsync<Ticket>();
            Tickets.AddCollection(tickets);

            base.OnNavigatedTo(parameters);
        }
    }
}
