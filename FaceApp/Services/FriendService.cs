using FaceApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceApp.Services
{
    public class FriendService : IFriendBase<Friends>
    {
        private readonly ApplicationDBContext context;

        public FriendService(ApplicationDBContext context)
        {
            this.context = context;
        }

        public int Add(Friends Model)
        {
            context.Friends.Add(Model);
            context.SaveChanges();
            return Model.ID;
        }

        public int Delete(int id)
        {
            Friends friends = context.Friends.FirstOrDefault(ar => ar.ID == id);
            context.Friends.Remove(friends);
            context.SaveChanges();
            return 1;
        }

        public List<Friends> GetAll()
        {
            return context.Friends.ToList();
        }

        public int Update(int id, Friends Model)
        {
            throw new NotImplementedException();
        }
    }
}
