using DocManagementSystem.BL;
using DocManagementSystem.CustomExceptions;
using DocManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocManagementSystem.PL.Controllers
{
    public class DocController : Controller
    {
        // GET: Doc
        private readonly IDocRepo _docContext;
        private readonly IActorRepo _actorContext;

        public DocController(IActorRepo acc, IDocRepo dcc)
        {
            _docContext = dcc;
            _actorContext = acc;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Doc/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Doc/Create
        public ActionResult Create()
        {
            List<Actor> list = _actorContext.GetActors().ToList();
            ViewBag.Actors = list;
            return View();
        }
        /// <summary>
        /// This is the sample Summary to push
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        // POST: Doc/Create
        [HttpPost]
        public ActionResult Create(Documentary doc)
        {
            List<Actor> list = _actorContext.GetActors().ToList();
            ViewBag.Actors = list;
            try
            {
                // TODO: Add insert logic here

                int res = _docContext.AddDoc(doc);
                if(res>0)
                {
                    ViewBag.Message = "Inserted Successfully";
                }
            }
            catch(DuplicateDocumentaryName e)
            {
                ViewBag.Message = e.Message;
            }
            catch(Exception e)
            {
                ViewBag.Message = e.Message;
            }
            return View("Create");
        }

        // GET: Doc/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Doc/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Doc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Doc/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult List()
        {

            List<Actor> list = _actorContext.GetActors().ToList();
            ViewBag.Actors = list;
            return View();
        }
    }
}
