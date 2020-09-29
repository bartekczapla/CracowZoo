using CracowZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CracowZoo.Models
{

    [Table("ZooEvents")]
    public class ZooEvent : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Conditions { get; set; }
        public ICollection<ZooEventDate> Dates { get; set; }
    }
}
