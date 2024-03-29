﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CracowZoo.PlatformCore;

namespace CracowZoo.Droid
{
    public class AndroidSettingsProvider : IPlatformSettingsProvider
    {
        public string ConnectionString => "Filename=" + Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "cracowZooDB.db");

        public string Platform => "Android";
    }
}