using DocManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocManagementSystem.DL
{
    public class DocumentaryContext:DbContext
    {
        public DbSet<Documentary> Docs { get; set; }
    }
}
