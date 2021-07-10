using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocManagementSystem.CustomExceptions
{
    public class DuplicateDocumentaryName:Exception
    {
        public DuplicateDocumentaryName(string name):base($"System Has Already Dcoumentary addded with {name}")
        {

        }
    }
}
