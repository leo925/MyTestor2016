﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3dWebPages.Controllers
{
    public class QueryController : Controller
    {
        // GET: Query
        public ActionResult Index()
        {
            return View();
        }

        // GET: Query/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Query/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Query/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Query/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Query/Edit/5
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

        // GET: Query/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Query/Delete/5
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
