using CracowZoo.Interfaces.CrossServices;
using CracowZoo.Views.CustomControls;
using Prism.Events;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace CracowZoo.Views
{
    public partial class MapPage : ContentPage
    {
        private readonly IEventAggregator _eventAggregator;

        public MapPage(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            InitializeComponent();
            ZooMapControl.MyLocationButtonClicked += ValidateUserLocation;
            ZooMapControl.UiSettings.CompassEnabled = false;
            ZooMapControl.TileLayers.Add(TileLayer.FromAsyncImage(GetTiles));
        }

        private Task<byte[]> GetTiles(int x, int y, int z)
        {
            var tileConverter = DependencyService.Get<ITileConverter>();
            //TODO Poprawnie sformatować string do resources, np. mapTile_x_y_z
            return tileConverter.ToByteArray($"tile_{z}_{x}_{y}");
        }

        private async void ValidateUserLocation(object sender, MyLocationButtonClickedEventArgs e)
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (!ZooMapControl.CheckBounds(location.Latitude, location.Longitude))
                {
                    e.Handled = true;
                    await DisplayAlert("Poza lokalizacją", "Znajdujesz się poza lokalizacją zoo", "Ok");
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }

        private void MenuButton_Clicked(object sender, EventArgs e)
        {
            _eventAggregator.GetEvent<MyEvent>().Publish();
        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            await Plugin.Media.CrossMedia.Current.TakePhotoAsync(
                new Plugin.Media.Abstractions.StoreCameraMediaOptions() {  Directory="Kraków ZOO", SaveToAlbum = true });
        }
    }
}