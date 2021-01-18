using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemo.Models
{
    public class EmpDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter employee name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter employee email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter employee age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter employee salary")]
        public int Salary { get; set; }
    }
}
