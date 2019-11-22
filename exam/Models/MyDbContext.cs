using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace exam.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=Exam") { }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }

}