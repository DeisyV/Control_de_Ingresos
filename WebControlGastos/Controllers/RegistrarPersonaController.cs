using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebControlGastos.Models;

namespace WebControlGastos.Controllers
{
    public class RegistrarPersonaController : Controller
    {
        DataAccess BD = new DataAccess(); // se configura el using y se realiza la comucnicacion del controlador y modelo
        // GET: RegistrarPersona
        public ActionResult RegistrarPersona()
        {
            return View();
        }

        [HttpPost] //esto siempre va, determinar el tipo de peticion   HttpPost o HttpGet
        public ActionResult ConsultarParametricas(string Tabla = "") //esta funcion es la que se enlaza con el ajax script en el data
        { //comunicarnos entre dos capas controlador y modelo se declara una variable arriba con el DataAccess

            IList<SelectListItem> Parametrica = new List<SelectListItem>(); //public List<SelectListItem> variable:parametricas. se debe de llamar igual del dataaccess
            Parametrica = BD.ConsultarParametricas(Tabla);   //se le envia la tabla que se envia desde el ajax 
            return Json(Parametrica);
        }
    }
}