using CracowZoo.DataAccess.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace CracowZoo.Models
{
    public class Test : IEntity
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(512)]
        public string Description { get; set; }
    }
}
