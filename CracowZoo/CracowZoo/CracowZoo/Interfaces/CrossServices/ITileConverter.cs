using System;
using System.Collections.Generic;
using System.Text;

namespace CracowZoo.Interfaces.CrossServices
{
    public interface ITileConverter
    {
        byte[] ToByteArray(string resource);
    }
}
