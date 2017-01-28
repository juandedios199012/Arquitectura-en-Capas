using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_UNFV.PF.Entidades
{
    public class Alumno
    {
        public int CodigoAlumno { get; set; }
        public string NombresAlumno { get; set; }
        public string ApellidosAlumno { get; set; }
        public int Practica1 { get; set; }
        public int Practica2 { get; set; }
        public int Practica3 { get; set; }
        public int Practica4 { get; set; }
        public decimal PromedioPracticas { get; set; }
        public int ExamenParcial { get; set; }
        public int ExamenFinal { get; set; }
        public decimal PromedioFinal { get; set; }
        public bool Estado { get; set; }

    }
}
