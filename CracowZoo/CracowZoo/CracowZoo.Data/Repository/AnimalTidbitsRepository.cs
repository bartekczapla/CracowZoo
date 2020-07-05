using CracowZoo.Interfaces;
using CracowZoo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CracowZoo.Data.Repository
{
    public class AnimalTidbitsRepository : IAnimalTidbitsRepository
    {
        private readonly IRepository _repository;
        public AnimalTidbitsRepository(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<AnimalTidbit> GetRandomAsync()
        {
            var tidbit = await _repository.GetRandomAsync<AnimalTidbit>(new string[] { "Animal" });

            return tidbit;
        }
    }
}
