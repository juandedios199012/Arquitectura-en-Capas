using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using _1_UNFV.PF.Entidades;
using _2_UNFV.PF.Interfaces;
using _3_UNFV.PF.DataAccess;


namespace _4_UNFV.PF.LogicaNegocio
{
    public class AlumnoLogic: ILogicAlumno
    {

        string ILogicAlumno.RegistrarAlumno(ClaseMaster ObjMaster)
        {
            AlumnoData ObjAlumnoData = new AlumnoData();
            IAccesoDatos iAccesoDatos;
            iAccesoDatos = ObjAlumnoData;
            string Respuesta = null;

            using (TransactionScope Tx = new TransactionScope(TransactionScopeOption.Required))
            {
                try
                {
                    int CodigoAlumno = iAccesoDatos.Registrar(ObjMaster);
                    Tx.Complete();
                    Respuesta = "1";
                }
                catch (Exception Ex)
                {
                    Respuesta = Ex.Message;
                }
            }
            return Respuesta;
        }

        string ILogicAlumno.ActualizarAlumno(ClaseMaster ObjMaster)
        {
            AlumnoData ObjAlumnoData = new AlumnoData();
            IAccesoDatos iAccesoDatos;
            iAccesoDatos = ObjAlumnoData;
            string Respuesta = null;

            using (TransactionScope Tx = new TransactionScope(TransactionScopeOption.Required))
            {
                try
                {
                    int CodigoAlumno = iAccesoDatos.Actualizar(ObjMaster);
                    Tx.Complete();
                    Respuesta = "1";
                }
                catch (Exception Ex)
                {
                    Respuesta = Ex.Message;
                }
            }
            return Respuesta;
        }

        string ILogicAlumno.EliminarAlumno(ClaseMaster ObjMaster)
        {
            AlumnoData ObjAlumnoData = new AlumnoData();
            IAccesoDatos iAccesoDatos;
            iAccesoDatos = ObjAlumnoData;
            string Respuesta = null;

            using (TransactionScope Tx = new TransactionScope(TransactionScopeOption.Required))
            {
                try
                {
                    int CodigoAlumno = iAccesoDatos.Eliminar(ObjMaster);
                    Tx.Complete();
                    Respuesta = "1";
                }
                catch (Exception Ex)
                {
                    Respuesta = Ex.Message;
                }
            }
            return Respuesta;
        }

        public List<Alumno> ListarAlumnos(Alumno ObjAlumno)
        {
            AlumnoData ObjAlumnoData = new AlumnoData();
            try
            {
                return ObjAlumnoData.ListarAlumnos(ObjAlumno);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ObjAlumnos"></param>
        /// <returns></returns>
        /// 
        public List<Alumno> Buscar(Alumno ObjAlumnos)
        {
            AlumnoData ObjAlumnoData = new AlumnoData();
            try
            {
                return ObjAlumnoData.Buscar(ObjAlumnos);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }


        public List<Alumno> BuscarCodigo(Alumno ObjAlumnos)
        {
            AlumnoData ObjAlumnoData = new AlumnoData();
            try
            {
                return ObjAlumnoData.BuscarCodigo(ObjAlumnos);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
