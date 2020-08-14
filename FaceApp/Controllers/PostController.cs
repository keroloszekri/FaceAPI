using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaceApp.Model;
using FaceApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FaceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostBase<Posts> PostService;
        public PostController (IPostBase<Posts> PostService)
        {
            this.PostService = PostService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<Posts> Get()
        {
            return PostService.GetAll();
        }

        [HttpPost]
        [Authorize]
        public int Add(Posts Model)
        {
            return PostService.Add(Model);
        }

        [HttpDelete]
        public int Delete(int id)
        {
           return PostService.Delete(id);
        }

        [HttpPut]
        public int Update(int id, Posts Model)
        {
            return PostService.Update(id, Model);
        }


    }
}