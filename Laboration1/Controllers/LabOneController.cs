using Laboration1.Models;
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
        // GET: LabOne
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: LabOne/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: LabOne/Create
        public ActionResult Create()
        {
            PSA daten = new PSA();
            return View(daten);
        }

        // POST: LabOne/Create
        [HttpPost]
        public ActionResult Create(PSA datat)
        {
            
            try
            {
                //String First = collection["First"];
                //String Mitten = collection["Mitten"];
                //String Last = collection["Last"];

                //PSA datat = new PSA();
                //datat.First = First;
                //datat.Mitten = Mitten;
                //datat.Last = Last;
                //Session["sparat"] = datat;


                    // TODO: Add insert logic here
   // GET: LabOne/Create
                return RedirectToAction("Second");
            }
            catch
            {
                return View();
            }
        }
        // GET: LabOne/Second
        [HttpGet]
        public ActionResult Second(PSA datat)
        {
            //PSA data2 = new PSA();
            //data2 = datat;
            //String Forsta = data2.First;
            //String Middle = data2.Mitten;
            //String Sista = data2.Last;

            //ViewBag.Data = "Du skrev " + Forsta + Middle + Sista + "!";
            return View();
        }
        //////////[HttpPost]
        ////////////public ActionResult Second(PSA data3)
        ////////////{
        ////////////    return RedirectToAction("Third");
        ////////////}
        public ActionResult Third()
        {
            PSA data2 = new PSA();
            data2 = (PSA)Session["sparat"];
            String Forsta = data2.First;
            String Middle = data2.Mitten;
            String Sista = data2.Last;

            ViewBag.Data = "Du skrev " + Forsta + Middle + Sista + "!";
            return View();
        }
    }
}
