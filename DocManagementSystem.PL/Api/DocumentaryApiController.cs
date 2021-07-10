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
    public class DocumentaryApiController : ApiController
    {
        private readonly IDocRepo _dbContext;
        private readonly IActorRepo _actorContext;

        public DocumentaryApiController(IDocRepo db,IActorRepo adb)
        {
            _dbContext = db;
            _actorContext = adb;
            
        }
        //GET: api/DocumentaryApi
        public IEnumerable<Documentary> Get()
        {
            List<Actor> list = _actorContext.GetActors().ToList();
            List<Documentary> doclist = _dbContext.GetDocumentaries().ToList();
            List<Documentary> l = new List<Documentary>();
            foreach(var d in doclist)
            {
                foreach(var a in list)
                {
                    if(d.ActorId==a.ActorId)
                    {
                        d.actor = a;
                        l.Add(d);
                    }
                }
            }
            return doclist;
        }

        //GET: api/DocumentaryApi/5
        public IEnumerable<Documentary> Get(int id)
        {
            List<Documentary> list = new List<Documentary>();
            List<Documentary> doclist = _dbContext.GetDocumentaries().ToList();
            foreach(var a in doclist)
            {
                if(a.ActorId==id)
                {
                    list.Add(a);

                }
            }
            return list;
        }

        // POST: api/DocumentaryApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DocumentaryApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DocumentaryApi/5
        public void Delete(int id)
        {
        }
    }
}
