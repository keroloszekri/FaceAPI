using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceApp.Services
{
    public interface IFriendBase<T>
    {
        List<T> GetAll();
        int Add(T Model);
        int Update(int id, T Model);
        int Delete(int id);
    }
}
