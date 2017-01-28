using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_UNFV.PF.Entidades;
using _2_UNFV.PF.Interfaces;
using _3_UNFV.PF.DataAccess;
using System.Transactions;

namespace _4_UNFV.PF.LogicaNegocio
{
    public class ProyectoLogic:ILogicProyecto
    {

        string ILogicProyecto.RegistrarProyecto(ClaseMaster ObjMaster)
        {
            ProyectoData objProyectoData = new ProyectoData();
            IAccesoDatos iAccesoDatos;
            iAccesoDatos = objProyectoData;
            string Respuesta = null;

            using (TransactionScope Tx = new TransactionScope(TransactionScopeOption.Required))
            {
                try
                {
                    int CodigoProducto = iAccesoDatos.Registrar(ObjMaster);
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
    }
}
