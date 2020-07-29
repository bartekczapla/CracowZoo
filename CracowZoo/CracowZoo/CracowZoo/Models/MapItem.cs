using CracowZoo.Enums;
using CracowZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CracowZoo.Models
{
    [Table("MapItems")]
    public class MapItem : IEntity
    {
        [Key]
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool Marked { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public MapItemType MapItemType { get; set; }
    }
}
