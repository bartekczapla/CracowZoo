using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CracowZoo.Interfaces.CrossServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(CracowZoo.Droid.DependencyServices.AndroidTileConverter))]
namespace CracowZoo.Droid.DependencyServices
{
    public class AndroidTileConverter : ITileConverter
    {
        public byte[] ToByteArray(string resource)
        {
            var mydrw = (int)typeof(Resource.Drawable).GetField(resource).GetValue(null);
            var icon = BitmapFactory.DecodeResource(Android.App.Application.Context.Resources, mydrw);
            var ms = new MemoryStream();
            icon.Compress(Bitmap.CompressFormat.Png, 0, ms);
            byte[] iconBytes = ms.ToArray();
            return iconBytes;
        }
    }
}