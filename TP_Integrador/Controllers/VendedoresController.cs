using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP_Integrador.Models;

namespace TP_Integrador.Controllers
{
    public class VendedoresController : Controller
    {
        public IActionResult HomeVendedores()
        {
            return View();
        }
    
        public IActionResult CrearPublicacion()
        {
            return View();
        }

        public IActionResult AñadirPublicacion(string titulo, string descripcion, double precio)
        {
            Publicacion p = new Publicacion();
            p.Id = ListGlossary.publicaciones.Count + 1;
            p.Titulo = titulo;
            p.Descripcion = descripcion;
            p.Precio = precio;
            p.NombreVendedor = ListGlossary.usuarioLogeado;
            ListGlossary.publicaciones.Add(p);
            return RedirectToAction("HomeVendedores", "Vendedores");
        }
    }
}
