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
    public class ClienteLogic:IlogicCliente
    {
        string IlogicCliente.RegistrarCliente(ClaseMaster ObjMaster)
        {
            ClienteData objClienteData = new ClienteData();
            IAccesoDatos iAccesoDatos;
            iAccesoDatos = objClienteData;
            string Respuesta = null;

            using (TransactionScope Tx = new TransactionScope(TransactionScopeOption.Required))
            {
                try
                {
                    int CodigoCliente = iAccesoDatos.Registrar(ObjMaster);
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
