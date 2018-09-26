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
        public string Get(int id)
        {
            return "value";
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
        public void Delete(int id)
        {
        }
    }
}
