using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CracowZoo.Interfaces.CrossServices
{
    public interface ITileConverter
    {
        Task<byte[]> ToByteArray(string resource);
    }
}
