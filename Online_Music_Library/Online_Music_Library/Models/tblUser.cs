//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Music_Library.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tblUser
    {
        public int user_id { get; set; }

        [Required(ErrorMessage ="User name is required!!!")]
        public string user_name { get; set; }

        [Required(ErrorMessage = "Email is required!!!")]
        public string email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required!!!")]
        public string password { get; set; }

        [Compare("password")]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }
    }
}
