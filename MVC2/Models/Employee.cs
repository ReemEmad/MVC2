using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC2.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int id { get; set; }

        [Required] 
        [MaxLength(50)]
        public string fname { get; set; }

        [Required]
        [MaxLength(50)]
        public string lname { get; set; }

        [Required]
        public string email { get; set; }

    }

}