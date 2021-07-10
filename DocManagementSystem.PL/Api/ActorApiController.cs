using DocManagementSystem.BL;
using DocManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DocManagementSystem.PL.Api
{
    public class ActorApiController : ApiController
    {
        // GET: api/ActorApi
        private readonly IActorRepo _dbContext;

        public ActorApiController(IActorRepo actorrepo)
        {
            _dbContext = actorrepo;
        }
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ActorApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ActorApi
        public HttpResponseMessage Post([FromBody]Actor actor)

        {
            int res = _dbContext.AddActor(actor);
            var message = Request.CreateResponse(HttpStatusCode.Created, actor);
            message.Headers.Location = new Uri("https://localhost:44380/Actor");
            return message;

        }

        // PUT: api/ActorApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ActorApi/5
        public void Delete(int id)
        {
        }
    }
}
