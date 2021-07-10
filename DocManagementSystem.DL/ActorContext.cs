using DocManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocManagementSystem.DL
{
   public  class ActorContext:DbContext

    {
        public DbSet<Actor> Actors { get; set; }

    }
}
