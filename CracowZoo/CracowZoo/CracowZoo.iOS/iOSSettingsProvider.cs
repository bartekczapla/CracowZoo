using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CracowZoo.Core;
using Foundation;
using UIKit;

namespace CracowZoo.iOS
{
    public class iOSSettingsProvider : IPlatformSettingsProvider
    {
        public string ConnectionString => "Filename=" + Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), @"cracowZoo.sqlite");

        public string Platform => "Android";
    }
}