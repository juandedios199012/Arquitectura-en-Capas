using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_UNFV.PF.Entidades
{
   public class EtapaProyecto
    {
        public int TotalPFCreacion { get; set; }
        public int HorasCreacion { get; set; }
        public int TotalPFActualizacion { get; set; }
        public int HorasActualizacion { get; set; }
        public int TotalPF { get; set; }
        public int TotalHoras { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estado { get; set; }
    }
}
