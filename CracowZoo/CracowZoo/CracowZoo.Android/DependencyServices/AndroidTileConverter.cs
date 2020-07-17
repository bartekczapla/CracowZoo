using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CracowZoo.Interfaces.CrossServices;
using Java.Nio;
using Xamarin.Forms;

[assembly: Dependency(typeof(CracowZoo.Droid.DependencyServices.AndroidTileConverter))]
namespace CracowZoo.Droid.DependencyServices
{
    public class AndroidTileConverter : ITileConverter
    {
        public async Task<byte[]> ToByteArray(string resource)
        {
            try
            {
                int resourceId = (int)typeof(Resource.Drawable).GetField(resource).GetValue(null);
                var tile = BitmapFactory.DecodeResource(Android.App.Application.Context.Resources, resourceId);

                using(var ms = new MemoryStream())
                {
                    await tile.CompressAsync(Bitmap.CompressFormat.Jpeg, 70, ms);
                    return ms.ToArray();
                }
            }
            catch
            {
                return Array.Empty<byte>();
            } 
        }
    }
}