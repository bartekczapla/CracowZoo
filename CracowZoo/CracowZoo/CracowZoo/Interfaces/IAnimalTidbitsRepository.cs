using CracowZoo.Models;
using System.Threading.Tasks;

namespace CracowZoo.Interfaces
{
    public interface IAnimalTidbitsRepository
    {
        Task<AnimalTidbit> GetRandomAsync();
    }
}
