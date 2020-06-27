using CracowZoo.Views.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace CracowZoo.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ZooMapControl.MyLocationButtonClicked += ValidateUserLocation;
        }

        private async void ValidateUserLocation(object sender, MyLocationButtonClickedEventArgs e)
        {
            if(!ZooMapControl.InZooBounds)
            {
                e.Handled = true;
                await DisplayAlert("Poza lokalizacją", "Znajdujesz się poza lokalizacją zoo", "Ok");
            }           
        }

    }
}