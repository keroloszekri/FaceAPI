using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceApp.Model
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public string Secret { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
           : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ASPCoreProject;Integrated Security=True");
        //}

        public virtual DbSet<Friends> Friends { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
    }
}
