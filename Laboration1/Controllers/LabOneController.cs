﻿using Laboration1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Tanken är att;
//1a sidan har en textruta med kontroll (det ska fyllas i ASP) ->skicka vidare mha model
//2a har en radiobutton med , . : ; Skicka vidare med parameterpassning
//3e har textruta med kontroll som ska innehålla NET -> skicka vidare med viewData
//4e presenterar ASP.NET och har en dropdown med frågan va detta bra? JA/Nej och vidare till 5e på ja annars loop
//5e Säger tack

namespace Laboration1.Controllers

{
    public class LabOneController : Controller
    {
        // GET: LabOne/Create
        [HttpGet]
        public ActionResult Create()
        {
            // Load Create view
            return View();
        }

        // POST: LabOne/Create
        [HttpPost]
        public ActionResult Create(PSA datat)
        {
            // Check if all is ok?
            if (ModelState.IsValid)
            {
                // Go to new view, pass on info "PARAMETERPASSNING"
                return View("Second", datat);
            }
            else
            {
                // There is a validation error
                // Go back and check
                return View();
            }

        }

        [HttpGet]
        public ActionResult Second()
        {
            return View();
        }

        // POST: LabOne/Second
        [HttpPost]
        public ActionResult Second(FormCollection samling)
        {
            return RedirectToAction("Third");
        }
        public ActionResult Third()
        {
            //int str = Convert.ToInt16(Session["x"]);

            ViewBag.Value = "Va kul att du tyckte det " + Session["Namn"];
            return View();
        }
    }
}
