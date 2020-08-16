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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.GoogleMaps.Bindings;

namespace CracowZoo.ViewModels
{
    public class MapPageViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IRepository _repository;

        public ObservableCollection<Pin> Pins { get; set; }

        private Pin _selectedPin;
        public Pin SelectedPin
        {
            get => _selectedPin;
            set => SetProperty(ref _selectedPin, value);
        }

        public MapPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator, IRepository repository)
            : base(navigationService)
        {
            _eventAggregator = eventAggregator;
            _repository = repository;
        }

        //public Command<MapClickedEventArgs> MapClickedCommand =>
        //new Command<MapClickedEventArgs>(args =>
        //{
        //    Pins.Add(new Pin
        //    {
        //        Label = $"Pin{Pins.Count}",
        //        Position = args.Point,
        //        Icon = BitmapDescriptorFactory.FromBundle("mammalsPin.png")
        //    });

        //    Debug.Write($"{args.Point.Latitude}  {args.Point.Longitude}");
        //});

        public Command<InfoWindowClickedEventArgs> PinInfoClickedCommand =>
        new Command<InfoWindowClickedEventArgs>(args =>
        {
            var selectedPin = args.Pin;
            if(selectedPin.Tag is MapItem)
            {
                NavigateToAnimals(selectedPin.Tag as MapItem);
            }
        });

        public MoveToRegionRequest MoveToRegionRequest { get; } = new MoveToRegionRequest();
        public MoveCameraRequest MoveCameraRequest { get; } = new MoveCameraRequest();

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);

            GetMapItems();
        }

        private async void GetMapItems()
        {
            Pins.Clear();

            var mapItems = await _repository.GetManyAsync<MapItem>((MapItem mapItem) => mapItem.Longitude > 0 && mapItem.Latitude > 0);
            
            string locationsToShowSetting = Xamarin.Essentials.Preferences.Get("showLocations", "Wszystko");

            foreach (var mapItem in mapItems)
            {
                var pin = new Pin
                {
                    Label = mapItem.Name,
                    Position = new Position(mapItem.Latitude, mapItem.Longitude),
                    Icon = BitmapDescriptorFactory.FromBundle(GetMapItemIcon(mapItem.MapItemType)),
                    Tag = mapItem
                };

                if (locationsToShowSetting == "Zwierzęta")
                {
                    if (mapItem.MapItemType == MapItemType.SingleAnimal
                        || mapItem.MapItemType == MapItemType.ManyAnimals)
                    {
                        Pins.Add(pin);
                    }
                }
                else if (locationsToShowSetting == "Miejsca")
                {
                    if (mapItem.MapItemType == MapItemType.Entrance
                        || mapItem.MapItemType == MapItemType.MiniZoo
                        || mapItem.MapItemType == MapItemType.Place
                        || mapItem.MapItemType == MapItemType.Restroom
                        || mapItem.MapItemType == MapItemType.Playground
                        || mapItem.MapItemType == MapItemType.Exotarium
                        || mapItem.MapItemType == MapItemType.NightAnimals)
                    {
                        Pins.Add(pin);
                    }
                }
                else
                {
                    Pins.Add(pin);
                }
            }
        }

        private string GetMapItemIcon(MapItemType type)
        {
            switch(type) {
                case MapItemType.Place:
                    return "amphibiansPin.png";
                case MapItemType.ManyAnimals:
                    return "reptilesPin.png";
                case MapItemType.SingleAnimal:
                    return "mammalsPin.png";
                case MapItemType.Restroom:
                    return "restroomPin.png";
                case MapItemType.Playground:
                    return "playgroundPin.png";
                case MapItemType.MiniZoo:
                    return "miniZooPin.png";
                case MapItemType.Exotarium:
                    return "egzotariumPin.png";
                case MapItemType.NightAnimals:
                    return "nightAnimalsPin.png";
                default:
                    return "mammalsPin.png";
            }
        }

        private async void NavigateToAnimals(MapItem clickedMapItem)
        {
            if (clickedMapItem.MapItemType == MapItemType.ManyAnimals)
            {
                var parameters = new NavigationParameters
                {
                    { "mapItemId", clickedMapItem.Id }
                };
                await NavigationService.NavigateAsync(nameof(AnimalsPage), parameters);
            } 
            else if (clickedMapItem.MapItemType == MapItemType.SingleAnimal)
            {
                var parameters = new NavigationParameters
                {
                    { "mapItemId", clickedMapItem.Id }
                };
                await NavigationService.NavigateAsync(nameof(AnimalDetailsPage), parameters);
            }
        }

        public async override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("goToAnimal"))
            {
                string mapPinName = parameters.GetValue<string>("goToAnimal");

                var pin = Pins.FirstOrDefault(p => p.Label == mapPinName);

                if (pin != null)
                {
                    SelectedPin = pin;
                    await Task.Delay(1000);
                    await MoveCameraRequest.MoveCamera(CameraUpdateFactory.NewPositionZoom(pin.Position, 18.0));
                }
            }

            base.OnNavigatedTo(parameters);
        }
    }
}
