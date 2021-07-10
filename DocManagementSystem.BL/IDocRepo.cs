using DocManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocManagementSystem.BL
{
    public interface IDocRepo
    {
        int AddDoc(Documentary doc);
        IEnumerable<Documentary> GetDocumentaries();
        IEnumerable<Documentary> GetDocumentary(int id);
    }
}
