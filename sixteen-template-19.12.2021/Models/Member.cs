using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen_template_19._12._2021.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string İmg { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Job { get; set; }
    }
}
