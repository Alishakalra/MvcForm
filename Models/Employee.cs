using System.ComponentModel.DataAnnotations;
using System;
using System.Web;
using System.Linq;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Enter valid firstname")]
        public string firstname { get; set; }

        [Required(ErrorMessage = "Enter valid lasname")]
        public string lastname { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public int age { get; set; }

    }
}