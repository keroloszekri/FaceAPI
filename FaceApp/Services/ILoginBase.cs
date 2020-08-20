using FaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceApp.Services
{
    public interface ILoginBase<T>
    {
        ApplicationUser Check(string Email);
    }
}
