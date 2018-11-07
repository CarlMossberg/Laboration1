using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Tanken är att;
//1a sidan har en textruta med kontroll (det ska fyllas i ASP) ->skicka vidare i Viewbag
//2a har en radiobutton med , . : ; Skicka vidare med parameterpassning
//3e har textruta med kontroll som ska innehålla NET -> skicka vidare med viewData
//4e presenterar ASP.NET och har en dropdown med frågan va detta bra? JA/Nej och vidare till 5e på ja annars loop
//5e Säger tack

namespace Laboration1.Controllers
{
    public class LabOneController : Controller
    {
        // GET: LabOne
        public ActionResult Index()
        {
            return View();
        }
    }
}