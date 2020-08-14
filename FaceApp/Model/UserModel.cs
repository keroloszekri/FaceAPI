using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FaceApp.Model
{
    public class UserModel
    {


        [Required]
        public string Email { get; set; }


        [Required]
        public string Password { get; set; }


        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }



        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }



    }
}
