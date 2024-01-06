using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP_Integrador.Models;

namespace TP_Integrador.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult AddNewUsuario(string nombreUsuario, string email, string contraseña, string tipo)
        {
            var u = new Usuario();
            u.NombreUsuario = nombreUsuario;
            u.Email = email;
            u.Contraseña = contraseña;
            u.Tipo = tipo;
            ListGlossary.usuarios.Add(u);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult CheckLogin(string nombreUsuario, string contraseña)
        {
            try {
            Usuario usuarioEncontrado = ListGlossary.usuarios.Find(x => x.NombreUsuario == nombreUsuario && x.Contraseña == contraseña);
                switch(usuarioEncontrado.Tipo)
                {
                    case "1":
                        ListGlossary.usuarioLogeado = nombreUsuario;
                        return RedirectToAction("HomeClientes", "Clientes");
                        break;
                    case "2":
                        ListGlossary.usuarioLogeado = nombreUsuario;
                        return RedirectToAction("HomeVendedores", "Vendedores");
                        break;
                    case null:
                        return RedirectToAction("Index", "Home");
                        break;
                }
            }
            catch
            {
            return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");

        }
    }
}
