using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocManagementSystem.Entity
{
    public class Actor
    {

        public int ActorId { get; set; }

        public string ActorName { get; set; }

        public string Gender { get; set; }

        public DateTime DOB { get; set; }

        public int Age { get; set; }
    }
}