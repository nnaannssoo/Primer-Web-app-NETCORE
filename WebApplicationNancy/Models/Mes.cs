using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationNancy.Models
{
    public class Mes
    {

        public string nombre { get; set; }
        public int dias { get; set; }

        public Mes(string v1, int v2)
        {
            this.nombre = v1;
            this.dias = v2;
        }

    }
}
