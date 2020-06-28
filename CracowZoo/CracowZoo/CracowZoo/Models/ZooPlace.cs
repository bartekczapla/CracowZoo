using CracowZoo.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CracowZoo.Models
{
    [Table("ZooPlaces")]
    public class ZooPlace : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public virtual MapItem MapItem { get; set; }
        [ForeignKey("MapItem")]
        public int MapItemId { get; set; }
    }
}
