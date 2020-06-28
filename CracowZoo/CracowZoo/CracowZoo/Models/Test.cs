﻿using CracowZoo.DataAccess.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CracowZoo.Models
{
    [Table("Tests")]
    public class Test : IEntity
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }
    }
}
