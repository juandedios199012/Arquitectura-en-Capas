using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_UNFV.PF.Entidades
{
    public class ClaseMaster
    {
        public List<Alumno> EntidadAlumno { get; set; }
        public List<Cliente> EntidadCliente { get; set; }
        public List<Producto> EntidadProducto { get; set; }
        public List<Proyecto> EntidadProyecto { get; set; }
    }
}
