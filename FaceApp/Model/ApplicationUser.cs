using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceApp.Model
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Friends> Friends { get; set; }
        public virtual ICollection<Posts> Posts { get; set; }
    }
}
