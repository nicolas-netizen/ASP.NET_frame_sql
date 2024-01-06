using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_Integrador.Models
{
       public class Entity
        {
            private int id;

            public int Id { get => id; set => id = value; }

            public override string ToString()
            {
                return id.ToString();
            }
        }
    }

