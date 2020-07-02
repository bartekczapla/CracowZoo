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
        private readonly double _zooLongitude = 19.850727;

        private readonly double _maxZoom = 19;
        private readonly double _minZoom = 16;
        private readonly double _leftRestriction = 19.846560023725;
        private readonly double _rightRestriction = 19.856195859611;
        private readonly double _topRestriction = 50.0554976430348;
        private readonly double _bottomRestriction = 50.0506828412358;

        public double CenterLatitude => CameraPosition.Target.Latitude;
        public double CenterLongitude => CameraPosition.Target.Longitude;

        public ZooMap() : base()
        {
            MyLocationEnabled = true;
            UiSettings.MyLocationButtonEnabled = true;

            //Set map to zoo location by default
            MoveToRegion(MapSpan.FromCenterAndRadius(new Position(_zooLatitude, _zooLongitude), Distance.FromMeters(500)));
            CameraIdled += CameraStopped;
        }

        public bool CheckBounds(double latitude, double longitude)
        {
            if (latitude >= _bottomRestriction && latitude <= _topRestriction
                && longitude >= _leftRestriction && longitude <= _rightRestriction)
                return true;

            return false;
        }

        private async void CameraStopped(object sender, CameraIdledEventArgs e)
        {
            if (Region == null)
                return;

            if (CameraPosition.Zoom > _maxZoom)
                await MoveCamera(CameraUpdateFactory.NewPositionZoom(new Position(CenterLatitude, CenterLongitude), _maxZoom));
            if (CameraPosition.Zoom < _minZoom)
                await MoveCamera(CameraUpdateFactory.NewPositionZoom(new Position(CenterLatitude, CenterLongitude), _minZoom));

            if (CenterLongitude > _rightRestriction)
                await MoveCamera(CameraUpdateFactory.NewPosition(new Position(CenterLatitude, _rightRestriction)));
            if (CenterLongitude < _leftRestriction)
                await MoveCamera(CameraUpdateFactory.NewPosition(new Position(CenterLatitude, _leftRestriction)));
            if (CenterLatitude > _topRestriction)
                await MoveCamera(CameraUpdateFactory.NewPosition(new Position(_topRestriction, CenterLongitude)));
            if (CenterLatitude < _bottomRestriction)
                await MoveCamera(CameraUpdateFactory.NewPosition(new Position(_bottomRestriction, CenterLongitude)));
        }
    }
}
