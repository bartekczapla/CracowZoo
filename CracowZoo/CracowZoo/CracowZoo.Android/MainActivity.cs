using Android.App;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using CracowZoo.Data.Repository;
using CracowZoo.Interfaces;
using CracowZoo.PlatformCore;
using CracowZoo.Views;
using FFImageLoading.Forms.Platform;
using Prism;
using Prism.Common;
using Prism.Ioc;
using System;
using System.IO;
using Xamarin.Forms;

namespace CracowZoo.Droid
{
    [Activity(Label = "Zoo Kraków", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = false,
        LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
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
            CachedImageRenderer.Init(true);
            LoadApplication(new App(new AndroidInitializer()));
        }

        public override void OnBackPressed()
        {
            Page currentPage = PageUtilities.GetCurrentPage(App.Current.MainPage);

            if (App.Current.MainPage is MasterDetailPage mdp && !mdp.IsPresented
                && (currentPage is MapPage || currentPage is AnimalGroupsPage
                    || currentPage is ZooEventsPage || currentPage is EventDayPage
                    || currentPage is InformationPage
                    || currentPage is TicketsPage || currentPage is SettingsPage))
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
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IPlatformSettingsProvider, AndroidSettingsProvider>();
            containerRegistry.Register(typeof(IRepository), typeof(CracowZooRepository));
            containerRegistry.Register(typeof(IAnimalTidbitsRepository), typeof(AnimalTidbitsRepository));
        }
    }
}

