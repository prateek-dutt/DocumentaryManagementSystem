using DocManagementSystem.BL;
using DocManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DocManagementSystem.PL.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorRepo _dbContext;


        public ActorController(IActorRepo ar)
        {
            _dbContext = ar;
        }
        // GET: Actor
        public ActionResult Index()
        {
            return View();
        }

        // GET: Actor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Actor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actor/Create
        [HttpPost]
        public ActionResult Create(Actor actor )
        {
            try
            {
                // TODO: Add insert logic here

                int res = _dbContext.AddActor(actor);
                if (res > 0)
                {
                    ViewBag.Message = "Insertion Successful";
                }
                else
                {
                    ViewBag.Message = "ERROR WHILE INSERTING";
                }

            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
            }
            return View("Create");
            

        }

        // GET: Actor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Actor/Edit/5
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

        // GET: Actor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Actor/Delete/5
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
    }
}
