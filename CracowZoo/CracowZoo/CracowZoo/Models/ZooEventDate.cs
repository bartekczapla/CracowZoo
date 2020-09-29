using CracowZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CracowZoo.Models
{

    [Table("ZooEventDates")]
    public class ZooEventDate : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DayOfWeek Day { get; set; }
        [Required]
        public TimeSpan Time { get; set; }
        public virtual ZooEvent ZooEvent { get; set; }
        [ForeignKey("ZooEvent")]
        public int ZooEventId { get; set; }
    }
}
