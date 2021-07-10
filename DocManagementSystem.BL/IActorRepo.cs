using DocManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocManagementSystem.BL
{
    public interface IActorRepo
    {
        int AddActor(Actor actor);

        IEnumerable<Actor> GetActors();
    }
}
