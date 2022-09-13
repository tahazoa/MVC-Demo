using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace First_Demo.Models
{
    public class Demo
    {

        [Key]
        public int id { get; set; }


        [Required]

        public String Name { get; set; }
        [Required]

        public String Email { get; set; }
        [Required]

        
        public String Password { get; set; }
        
        [Required]
        public int PhoneNumber { get; set; }

    }
}
