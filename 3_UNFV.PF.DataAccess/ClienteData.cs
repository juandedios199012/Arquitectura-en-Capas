using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_UNFV.PF.Entidades;
using _2_UNFV.PF.Interfaces;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _3_UNFV.PF.DataAccess
{
    public class ClienteData: IAccesoDatos
    {
        public string StringConnection = String.Empty;

        public ClienteData()
        {
            this.StringConnection = ConfigurationManager.ConnectionStrings["cnDemoObjetos"].ToString();
        }


        int IAccesoDatos.Registrar(ClaseMaster ObjMaster)
        {
            SqlCommand Comando = null;
            int Rpta = -1;

            using (SqlConnection Connection = new SqlConnection(StringConnection))
            {
                Connection.Open();
                Comando = new SqlCommand("Cliente_Insertar", Connection);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@CodigoCliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                Comando.Parameters.Add("@NombreCliente", SqlDbType.VarChar, 50).Value = ObjMaster.EntidadCliente[0].NombreCliente;
                Comando.Parameters.Add("@DireccionCliente", SqlDbType.VarChar, 250).Value = ObjMaster.EntidadCliente[0].DireccionCliente;
                Comando.Parameters.Add("@MontoCompra", SqlDbType.Decimal).Value = ObjMaster.EntidadCliente[0].MontoCompra;

                try
                {
                    Comando.CommandTimeout = 900;
                    Comando.ExecuteNonQuery();
                    Rpta = Convert.ToInt32(Comando.Parameters["@CodigoCliente"].Value.ToString());
                }
                catch (Exception ex)
                {
                    Rpta = -1;
                }
            }
            return Rpta;
        }


        int IAccesoDatos.Actualizar(ClaseMaster ObjMaster)
        {
            throw new NotImplementedException();
        }

        int IAccesoDatos.Eliminar(ClaseMaster ObjMaster)
        {
            throw new NotImplementedException();
        }

      
    }
}
