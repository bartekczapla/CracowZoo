using CracowZoo.Enums;
using CracowZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CracowZoo.Models
{
    [Table("Animals")]
    public class Animal : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(60)]
        public string Name { get; set; }
        public AnimalGroup Group { get; set; }
        [MaxLength(60)]
        public string LatinSpecie { get; set; }
        public ConservationStatus ConservationStatus { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [MaxLength(50)]
        public string Occurance { get; set; }
        [MaxLength(100)]
        public string LivingEnvritonment { get; set; }
        [MaxLength(200)]
        public string Food { get; set; }
        [MaxLength(200)]
        public string Breeding { get; set; }
        public AnimalDanger AnimalDanger { get; set; }
        public virtual MapItem MapItem { get; set; }
        [ForeignKey("MapItem")]
        public int? MapItemId { get; set; }
        public ICollection<AnimalTidbit> AnimalTidbits { get; set; }
        [MaxLength(50)]
        public string ImagePath { get; set; }
    }
}
