using CracowZoo.Interfaces;
using CracowZoo.Views;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace CracowZoo.ViewModels
{
    public class MapPageViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;

        private readonly IAnimalTidbitsRepository _animalTidbitsRepository;

        public ObservableCollection<Pin> Pins { get; set; }

        public MapPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator, IAnimalTidbitsRepository animalTidbitsRepository)
            : base(navigationService)
        {
            _eventAggregator = eventAggregator;
            _animalTidbitsRepository = animalTidbitsRepository;
        }

        public Command<MapClickedEventArgs> MapClickedCommand =>
        new Command<MapClickedEventArgs>(args =>
        {
            Pins.Add(new Pin
            {
                Label = $"Pin{Pins.Count}",
                Position = args.Point,
                Icon = BitmapDescriptorFactory.FromBundle("mammalsPin.png")
            });

            Pins.Add(new Pin
            {
                Label = $"Pin{Pins.Count}",
                Position = new Position(args.Point.Latitude+0.001, args.Point.Longitude+0.001),
                Icon = BitmapDescriptorFactory.FromBundle("reptilesPin.png")
            });

            Pins.Add(new Pin
            {
                Label = $"Pin{Pins.Count}",
                Position = new Position(args.Point.Latitude + 0.001, args.Point.Longitude - 0.001),
                Icon = BitmapDescriptorFactory.FromBundle("fishPin.png")
            });

            Pins.Add(new Pin
            {
                Label = $"Pin{Pins.Count}",
                Position = new Position(args.Point.Latitude - 0.001, args.Point.Longitude + 0.001),
                Icon = BitmapDescriptorFactory.FromBundle("amphibiansPin.png")
            });
        });

        public override void Initialize(INavigationParameters parameters)
        {
            GetRandomAnimalTidbit();
            base.Initialize(parameters);
        }

        private async void GetRandomAnimalTidbit()
        {
            var randomAnimalTidbit = await _animalTidbitsRepository.GetRandomAsync(); //tymczasowo tu, dla testu
        }

    }
}
