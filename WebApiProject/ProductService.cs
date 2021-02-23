using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProject
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
