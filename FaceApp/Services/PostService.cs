using FaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceApp.Services
{
    public class PostService : IPostBase<Posts>
    {
        private readonly ApplicationDBContext context;

        public PostService(ApplicationDBContext context)
        {
            this.context = context;
        }

        public int Add(Posts Model)
        {
            context.Posts.Add(Model);
            context.SaveChanges();
            return Model.ID;
        }

        public int Delete(int id)
        {
            Posts Post = context.Posts.FirstOrDefault(ar => ar.ID == id);
            context.Posts.Remove(Post);
            context.SaveChanges();
            return 1;
        }

        public List<Posts> GetAll()
        {
            return context.Posts.ToList();
        }

        public int Update(int id, Posts Model)
        {
            Posts post = context.Posts.FirstOrDefault(s => s.ID == id);
            post.Text = Model.Text;
            post.Image = Model.Image;
            context.SaveChanges();
            return 1;
        }
    }
}
