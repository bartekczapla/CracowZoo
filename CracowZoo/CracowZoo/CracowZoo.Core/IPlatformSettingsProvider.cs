using System;

namespace CracowZoo.Core
{
    public interface IPlatformSettingsProvider
    {
        string ConnectionString { get; }

        string Platform { get;  }
    }
}
