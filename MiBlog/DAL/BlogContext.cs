using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MiBlog.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace MiBlog.DAL
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContext")
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}