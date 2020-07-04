using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;
using CracowZoo.Data.Repository;
using CracowZoo.Interfaces;
using CracowZoo.PlatformCore;
using CracowZoo.Views;
using Prism;
using Prism.Common;
using Prism.Ioc;
using System;
using Xamarin.Forms;

namespace CracowZoo.Droid
{
    [Activity(Label = "CracowZoo", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private long lastPress;
        protected override void OnCreate(Bundle bundle)
        {
            SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3());
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
 
            base.OnCreate(bundle);

            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            this.Window.ClearFlags(WindowManagerFlags.ForceNotFullscreen);


            global::Xamarin.Forms.Forms.Init(this, bundle);
            global::Xamarin.FormsGoogleMaps.Init(this, bundle);
            global::Xamarin.Essentials.Platform.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
        }

        public override void OnBackPressed()
        {
            Page currentPage = PageUtilities.GetCurrentPage(App.Current.MainPage);

            if (App.Current.MainPage is MasterDetailPage mdp && !mdp.IsPresented
                && (currentPage is MapPage || currentPage is AnimalGroupsPage))
            {
                long currentTime = DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond;

                if (currentTime - lastPress > 2500)
                {
                    Toast.MakeText(this, "Naciśnij ponownie, aby zakończyć", ToastLength.Short).Show();
                    lastPress = currentTime;
                }
                else
                {
                    base.OnBackPressed();
                }
            }
            else
                base.OnBackPressed();

            //if (currentPage is MapPage || currentPage is AnimalGroupsPage)
            //{
            //    long currentTime = DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond;

            //    if (currentTime - lastPress > 2500)
            //    {
            //        Toast.MakeText(this, "Naciśnij ponownie, aby zakończyć", ToastLength.Short).Show();
            //        lastPress = currentTime;
            //    }
            //    else
            //    {
            //        base.OnBackPressed();
            //    }
            //}
            //else
            //    base.OnBackPressed();
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IPlatformSettingsProvider, AndroidSettingsProvider>();
            containerRegistry.Register(typeof(IRepository), typeof(CracowZooRepository));
        }
    }
}

