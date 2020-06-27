using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms.GoogleMaps;

namespace CracowZoo.Views.CustomControls
{
    public class ZooMap : Xamarin.Forms.GoogleMaps.Map
    {
        private readonly double _zooLatitude = 50.053453;
        private readonly double _zooLongtitude = 19.850727;

        private readonly double _maxZoom = 19;
        private readonly double _minZoom = 16;
        private readonly double _leftRestriction = 19.846560023725;
        private readonly double _rightRestriction = 19.856195859611;
        private readonly double _topRestriction = 50.0554976430348;
        private readonly double _bottomRestriction = 50.0506828412358;

        public bool InZooBounds { get => CheckBounds().Result; }
        public double CenterLatitude => (Region.NearRight.Latitude + Region.FarRight.Latitude) / 2.0;
        public double CenterLongtitude => (Region.NearLeft.Longitude + Region.NearRight.Longitude) / 2.0;

        public ZooMap() : base()
        {
            MyLocationEnabled = true;
            UiSettings.MyLocationButtonEnabled = true;

            //Set map to zoo location by default
            MoveToRegion(MapSpan.FromCenterAndRadius(new Position(_zooLatitude, _zooLongtitude), Distance.FromMeters(500)));
            CameraIdled += CameraStopped;
        }

        private async Task<bool> CheckBounds()
        {
            var location = await Geolocation.GetLastKnownLocationAsync();

            if (location.Latitude >= _bottomRestriction && location.Latitude <= _topRestriction
                && location.Longitude >= _leftRestriction && location.Longitude <= _rightRestriction)
                return true;

            return false;
        }

        private async void CameraStopped(object sender, CameraIdledEventArgs e)
        {
            if (Region == null)
                return;

            if (CameraPosition.Zoom > _maxZoom)
                await MoveCamera(CameraUpdateFactory.NewPositionZoom(new Position(CenterLatitude, CenterLongtitude), _maxZoom));
            if (CameraPosition.Zoom < _minZoom)
                await MoveCamera(CameraUpdateFactory.NewPositionZoom(new Position(CenterLatitude, CenterLongtitude), _minZoom));

            if (CenterLongtitude > _rightRestriction)
                await MoveCamera(CameraUpdateFactory.NewPosition(new Position(CenterLatitude, _rightRestriction)));
            if (CenterLongtitude < _leftRestriction)
                await MoveCamera(CameraUpdateFactory.NewPosition(new Position(CenterLatitude, _leftRestriction)));
            if (CenterLatitude > _topRestriction)
                await MoveCamera(CameraUpdateFactory.NewPosition(new Position(_topRestriction, CenterLongtitude)));
            if (CenterLatitude < _bottomRestriction)
                await MoveCamera(CameraUpdateFactory.NewPosition(new Position(_bottomRestriction, CenterLongtitude)));
        }
    }
}
