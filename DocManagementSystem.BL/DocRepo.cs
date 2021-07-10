using DocManagementSystem.CustomExceptions;
using DocManagementSystem.DL;
using DocManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocManagementSystem.BL
{
    public class DocRepo : IDocRepo
    {
        private readonly DocumentaryContext _dbContext;

        public DocRepo(DocumentaryContext dcc)
        {
            _dbContext = dcc;
        }
        public int AddDoc(Documentary doc)
        {
            ActorContext db = new ActorContext();

            List<Actor> actor_list = db.Actors.ToList();
            
            int res = -1;

            if (doc != null)
            {
                try
                {
                    if (ValidateDocName(doc.DocumentaryName))
                    {
                        foreach(var a in actor_list)
                        {
                            if(a.ActorId==doc.ActorId)
                            {
                                doc.actor = a;
                            }    
                        }

                        _dbContext.Docs.Add(doc);
                        _dbContext.SaveChanges();
                        res = doc.ActorId;

                    }
                    else
                    {
                        throw new DuplicateDocumentaryName(doc.DocumentaryName);
                    }
                   
                }
                catch( DuplicateDocumentaryName e)
                {
                    throw new DuplicateDocumentaryName(doc.DocumentaryName);

                }

            }
                return res;

            }

            public IEnumerable<Documentary> GetDocumentaries()
            {
                return _dbContext.Docs;
            }

        public IEnumerable<Documentary> GetDocumentary(int id)
        {
            throw new NotImplementedException();
            
        }

        private bool ValidateDocName(string documentaryName)
            {
                IEnumerable<Documentary> list = _dbContext.Docs;
                foreach (var d in list)
                {
                    if (d.DocumentaryName.Equals(documentaryName, StringComparison.OrdinalIgnoreCase))
                    {
                        return false;
                    }

                }

            return true;
            }
        }
    }
