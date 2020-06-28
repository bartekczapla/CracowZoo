using CracowZoo.DataAccess.Interfaces;
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
        [Required]
        public double X { get; set; }
        [Required]
        public double Y { get; set; }
    }
}
