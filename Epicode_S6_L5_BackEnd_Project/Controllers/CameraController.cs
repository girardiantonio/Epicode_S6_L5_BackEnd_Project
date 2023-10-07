﻿using Epicode_S6_L5_BackEnd_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Epicode_S6_L5_BackEnd_Project.Controllers
{
    public class CameraController : Controller
    {
        public ActionResult CreaCamera()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreaCamera(Camera model)
        {
            if (ModelState.IsValid)
            {
                model.InserisciCamera();
                return RedirectToAction("ListaCamera");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult ListaCamera()
        {
            var camera = new Camera().ListaCamera();
            return View(camera);
        }
    }
}