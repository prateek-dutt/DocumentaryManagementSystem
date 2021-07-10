using DocManagementSystem.DL;
using DocManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocManagementSystem.BL
{
    public class ActorRepo : IActorRepo
    {
        private readonly ActorContext _dbcontext;

        public ActorRepo(ActorContext dbcontext)
        {
         _dbcontext = dbcontext;
        }
        public int AddActor(Actor actor)
        {

            int res = -1;
            if(actor!=null)
            {
                actor.Age = (int)(DateTime.UtcNow - actor.DOB).Days/365;
                _dbcontext.Actors.Add(actor);
                _dbcontext.SaveChanges();
                res = actor.ActorId;

            }
            return res;

        }

        public IEnumerable<Actor> GetActors()
        {
            return _dbcontext.Actors;
        }
    }
}
