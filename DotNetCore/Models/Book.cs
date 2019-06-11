using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
