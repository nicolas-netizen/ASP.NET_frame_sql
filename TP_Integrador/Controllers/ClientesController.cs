using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_Integrador.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult HomeClientes()
        {
            return View();
        }

    }
}
