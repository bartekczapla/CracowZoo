using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.GoogleMaps;

namespace CracowZoo.Views.CustomControls
{
    public class ZooMap : Map
    {
        private readonly double _zooLatitude = 50.053453;
        private readonly double _zooLongtitude = 19.850727;

        private readonly double _maxZoom = 19;
        private readonly double _minZoom = 16;
        private readonly double _leftRestriction = 19.846560023725;
        private readonly double _rightRestriction = 19.856195859611;
        private readonly double _topRestriction = 50.0554976430348;
        private readonly double _bottomRestriction = 50.0506828412358;

        public ZooMap() : base()
        {
            //Set map to zoo location by default
            MoveToRegion(MapSpan.FromCenterAndRadius(new Position(_zooLatitude, _zooLongtitude), Distance.FromMeters(500)));
            CameraIdled += CameraStopped;
        }

        private async void CameraStopped(object sender, CameraIdledEventArgs e)
        {
            if (Region == null)
                return;

            double centerLatitude = (Region.NearRight.Latitude + Region.FarRight.Latitude) / 2.0;
            double centerLongtitude = (Region.NearLeft.Longitude + Region.NearRight.Longitude) / 2.0;

            if (CameraPosition.Zoom > _maxZoom)
                await MoveCamera(CameraUpdateFactory.NewPositionZoom(new Position(centerLatitude, centerLongtitude), _maxZoom));
            if (CameraPosition.Zoom < _minZoom)
                await MoveCamera(CameraUpdateFactory.NewPositionZoom(new Position(centerLatitude, centerLongtitude), _minZoom));

            if (centerLongtitude > _rightRestriction)
                await MoveCamera(CameraUpdateFactory.NewPosition(new Position(centerLatitude, _rightRestriction)));
            if (centerLongtitude < _leftRestriction)
                await MoveCamera(CameraUpdateFactory.NewPosition(new Position(centerLatitude, _leftRestriction)));
            if (centerLatitude > _topRestriction)
                await MoveCamera(CameraUpdateFactory.NewPosition(new Position(_topRestriction, centerLongtitude)));
            if (centerLatitude < _bottomRestriction)
                await MoveCamera(CameraUpdateFactory.NewPosition(new Position(_bottomRestriction, centerLongtitude)));
        }
    }
}
