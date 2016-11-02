using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Consultorio.Models;

namespace Consultorio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["usuario"] == null)
            {
                return RedirectToAction("PaginaPrincipal", "Home");
            }
            return View();
        }

        public ActionResult PaginaPrincipal(string nombre, string password)
        {
            if ("maxi".Equals(nombre) && "123".Equals(password))
            {
                Session["usuario"] = new Usuario() { LogIn = nombre, Password = password };
                return RedirectToAction("Index", "Home");

            }
            return View();
        }

    
    }
}
