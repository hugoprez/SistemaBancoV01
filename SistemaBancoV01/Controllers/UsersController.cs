using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SistemaBancoV01.Models;

namespace SistemaBancoV01.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Login()
        {
            return View();
        }
        
        //
        // POST Users
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users user)
        {

            if (!string.IsNullOrWhiteSpace(user.nombre_usuario) && !string.IsNullOrWhiteSpace(user.contrasena))
            {
                ViewBag.Message = "Bienvenido";
            }
            else
            {
                ViewBag.Message = "Campos requeridos";

            }

            // ViewBag.ReturnUrl = returnUrl;
            return View();
        }



    }
}