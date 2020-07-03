﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using CracowZoo.Data.Repository;
using CracowZoo.Interfaces;
using CracowZoo.PlatformCore;
using Prism;
using Prism.Ioc;

namespace CracowZoo.Droid
{
    [Activity(Label = "CracowZoo", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3());
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            global::Xamarin.FormsGoogleMaps.Init(this, bundle);
            global::Xamarin.Essentials.Platform.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
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

