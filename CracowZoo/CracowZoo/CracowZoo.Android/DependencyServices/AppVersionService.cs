using CracowZoo.Droid.DependencyServices;
using CracowZoo.Interfaces.CrossServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppVersionService))]
namespace CracowZoo.Droid.DependencyServices
{
    class AppVersionService : IAppVersion
    {
        public string GetVersion()
        {
            return Android.App.Application.Context.PackageManager.GetPackageInfo(Android.App.Application.Context.PackageName, 0).VersionName;
        }
    }
}