using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WebAPI_test.Models.Concrete
{
    public class DB_Context : DbContext
    {
        private static readonly Lazy<DB_Context> lazy = new Lazy<DB_Context>(() => new DB_Context());
        public DB_Context() : base("name=DB_Context") { }

        public virtual DbSet<Comment> CommentRep { get; set; }

        public static DB_Context GetInstance()
        {
            return lazy.Value;
        }
    }
}