using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_UNFV.PF.Entidades
{
    public class TipoProyecto
    {
        public string DescripcionTipoProyecto { get; set; }
        public int RangoMinimo { get; set; }
        public int RangoMaximo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estado { get; set; }
    }
}
