using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_Integrador.Models
{
    public class Publicacion:Entity
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string NombreVendedor { get; set; }
    }
}
