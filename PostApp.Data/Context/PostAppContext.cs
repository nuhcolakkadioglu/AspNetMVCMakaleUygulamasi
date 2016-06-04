using PostApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Data.Context
{
    public partial class PostAppContext : DbContext
    {
        private readonly PostAppContext _db;

        public PostAppContext() : base("name=PostAppEntities")
        {

        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Post> Post { get; set; }
    }
}
