using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_test.Models;
using WebAPI_test.Models.Abstract;
using WebAPI_test.Models.Concrete;

namespace WebAPI_test.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        private ICommentRepository _repository = new CommentRepository();

        public IEnumerable<Comment> Get()
        {
            return _repository.CommentList.AsEnumerable();
        }

        // GET api/values/5
        public Comment Get(int id)
        {
            Comment comment;
            if(!_repository.TryGet(id, out comment))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return comment;
        }

        // POST api/values
        public void Post([FromBody]Comment value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Comment value)
        {
        }

        // DELETE api/values/5
        public Comment Delete(int id)
        {
            Comment comment;
            if (!_repository.TryGet(id, out comment))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _repository.RemoveComment(id);

            return comment;
        }
    }
}
