using CracowZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CracowZoo.Models
{
    [Table("Tickets")]
    public class Ticket : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        [MaxLength(300)]
        public string AdditionalInfo { get; set; }
        public double SummerPrice { get; set; }
        public double WinterPrice { get; set; }
    }
}
