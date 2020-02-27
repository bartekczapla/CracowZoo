using CracowZoo.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CracowZoo.DataAccess.Entity
{
    public class Test : IEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(512)]
        public string Description { get; set; }
    }
}
