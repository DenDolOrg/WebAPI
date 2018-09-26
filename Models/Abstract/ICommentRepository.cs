using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_test.Models.Abstract
{
    public interface ICommentRepository
    {
        IQueryable<Comment> CommentList { get;}

        void AddComment(Comment comment);
    }
}
