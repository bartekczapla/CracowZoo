
namespace CracowZoo.PlatformCore
{
    public interface IPlatformSettingsProvider
    {
        string ConnectionString { get; }

        string Platform { get;  }
    }
}
