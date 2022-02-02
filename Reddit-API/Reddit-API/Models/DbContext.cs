using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DocumentFormat.OpenXml.Office2021.PowerPoint.Comment;

namespace Reddit_API.Models
{
    public class DbContext : IdentityDbContext<ApplicationsUser>
    {
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbContext(DbContextOptions<DbContext> options)
        {

        }
    }
}
