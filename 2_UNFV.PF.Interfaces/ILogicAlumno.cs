using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_UNFV.PF.Entidades;

namespace _2_UNFV.PF.Interfaces
{
 

    public interface ILogicAlumno
    {
        string RegistrarAlumno(ClaseMaster ObjMaster);
        string ActualizarAlumno(ClaseMaster ObjMaster);
        string EliminarAlumno(ClaseMaster ObjMaster);

    }
}
