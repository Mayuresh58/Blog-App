using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog_App.Data
{
    public class Blog_AppContext : DbContext
    {
        
    
        public Blog_AppContext() : base("name=Blog_AppContext")
        {
        }

        public System.Data.Entity.DbSet<Blog_App.Models.Post> Posts { get; set; }
    }
}
