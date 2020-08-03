using CracowZoo.Enums;
using CracowZoo.Interfaces;
using CracowZoo.Models;
using CracowZoo.Views;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace CracowZoo.ViewModels
{
    public class MapPageViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IRepository _repository;

        public ObservableCollection<Pin> Pins { get; set; }

        public MapPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator, IRepository repository)
            : base(navigationService)
        {
            _eventAggregator = eventAggregator;
            _repository = repository;
        }

        public Command<MapClickedEventArgs> MapClickedCommand =>
        new Command<MapClickedEventArgs>(args =>
        {
            Pins.Add(new Pin
            {
                Label = $"Pin{Pins.Count}",
                Position = args.Point,
                Icon = BitmapDescriptorFactory.FromBundle("mammalsPin.png"),
            });

            Debug.Write($"{args.Point.Latitude}  {args.Point.Longitude}");
        });

        public Command<PinClickedEventArgs> PinClickedCommand =>
        new Command<PinClickedEventArgs>(args =>
        {
            var selectedPin = args.Pin;
            if(selectedPin.Tag is MapItem)
            {
                NavigateToAnimals(selectedPin.Tag as MapItem);
            }
        });

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            GetMapItems();
        }

        private async void GetMapItems()
        {
            var mapItems = await _repository.GetManyAsync<MapItem>((MapItem mapItem) => mapItem.Longitude > 0 && mapItem.Latitude > 0);
            
            foreach(var mapItem in mapItems)
            {
                var pin = new Pin
                {
                    Label = mapItem.Name,
                    Position = new Position(mapItem.Latitude, mapItem.Longitude),
                    Icon = BitmapDescriptorFactory.FromBundle("mammalsPin.png"),
                    Tag = mapItem
                };
                Pins.Add(pin) ;
            }
        }

        private async void NavigateToAnimals(MapItem clickedMapItem)
        {
            if (clickedMapItem.MapItemType == MapItemType.ManyAnimals)
            {
                var parameters = new NavigationParameters();
                parameters.Add("mapItemId", clickedMapItem.Id);
                await NavigationService.NavigateAsync(nameof(AnimalsPage), parameters);
            } 
            else if (clickedMapItem.MapItemType == MapItemType.SingleAnimal)
            {
                var parameters = new NavigationParameters();
                parameters.Add("mapItemId", clickedMapItem.Id);
                await NavigationService.NavigateAsync(nameof(AnimalDetailsPage), parameters);
            }
        }
    }
}
