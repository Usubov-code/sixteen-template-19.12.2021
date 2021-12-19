using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen_template_19._12._2021.Models
{
    public class AboutUS
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Img { get; set; }
        [MaxLength(50)]
        public string SubTitle { get; set; }
        [Column(TypeName ="ntext")]
        public string Content { get; set; }
        public string Social { get; set; }

    }
}
