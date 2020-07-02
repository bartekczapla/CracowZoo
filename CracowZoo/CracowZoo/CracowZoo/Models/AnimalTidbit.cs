using CracowZoo.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CracowZoo.Models
{
    [Table("AnimalTidbits")]
    public class AnimalTidbit : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        public virtual Animal Animal { get; set; }
        [ForeignKey("Animal")]
        public int? AnimalId { get; set; }
    }
}
