using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocManagementSystem.Entity
{
    public class Documentary
    {
        public int DocumentaryId { get; set; }

        public string DocumentaryName { get; set; }

        public string Genre { get; set; }

        public Actor actor { get; set; }

        public int ActorId { get; set; }
    }
}
