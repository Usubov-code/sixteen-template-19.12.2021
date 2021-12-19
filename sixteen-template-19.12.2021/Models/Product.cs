using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen_template_19._12._2021.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Img { get; set; }

        [Column(TypeName ="Money")]
        public decimal Price { get; set; }

        [Column(TypeName = "ntext")]

        public string Content { get; set; }

        public int Review { get; set; }
    }
}
