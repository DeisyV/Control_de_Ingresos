using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebControlGastos.Controllers
{
    public class GastosController : Controller
    {
        // GET: Gastos
        public ActionResult Gastos()
        {
            //return View();
            return PartialView("~/Views/Gastos/prueba.cshtml");

        }
    }
}