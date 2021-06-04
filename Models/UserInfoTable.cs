//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class UserInfoTable
    {
        [Key]
       
        public int id { get; set; }

        [Required(ErrorMessage = "Enter valid firstname")]
        public string firstname { get; set; }

        [Required(ErrorMessage = "Enter valid lasname")]
        public string lastname { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }
    }
}