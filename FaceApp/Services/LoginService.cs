using FaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceApp.Services
{
    public class LoginService : ILoginBase<ApplicationUser>
    {
        private readonly ApplicationDBContext context;

        public LoginService(ApplicationDBContext context)
        {
            this.context = context;
        }

        ApplicationUser ILoginBase<ApplicationUser>.Check(string Email)
        {
            return context.Users.FirstOrDefault(s => s.Email == Email);
        }
    }
}
