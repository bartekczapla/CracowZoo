using CracowZoo.Views.CustomControls;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace CracowZoo.Views
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            ZooMapControl.MyLocationButtonClicked += ValidateUserLocation;
        }

        private async void ValidateUserLocation(object sender, MyLocationButtonClickedEventArgs e)
        {
            //ZooMapControl.Pins.Add(new Pin() { Position = new Position(50.053453, 19.850727) });

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
    }
}