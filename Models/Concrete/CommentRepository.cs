using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI_test.Models.Abstract;

namespace WebAPI_test.Models.Concrete
{
    public class CommentRepository : ICommentRepository
    {
        private DB_Context context = DB_Context.GetInstance();
        public IQueryable<Comment> CommentList
        {
            get => context.CommentRep;
        }

        public void AddComment(Comment comment)
        {
            if(comment != null)
            {
                context.CommentRep.Add(comment);
                context.SaveChanges();
            }
        }
    }
}