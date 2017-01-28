using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_UNFV.PF.Entidades
{
    public class Proyecto
    {
        public string NombreProyecto { get; set; }
        public decimal ProductividadCreacion { get; set; }
        public decimal ProductividadModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Usuario { get; set; }
    }
}
