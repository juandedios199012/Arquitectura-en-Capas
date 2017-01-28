using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_UNFV.PF.Entidades;
using _2_UNFV.PF.Interfaces;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace _3_UNFV.PF.DataAccess
{
   public class ProductoData: IAccesoDatos
    {
        public string StringConnection = String.Empty;

        public ProductoData()
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
                Comando = new SqlCommand("Producto_Insertar", Connection);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@CodigoProducto", SqlDbType.Int).Direction = ParameterDirection.Output;
                Comando.Parameters.Add("@NombreProducto", SqlDbType.VarChar, 50).Value = ObjMaster.EntidadProducto[0].NombreProducto;
                Comando.Parameters.Add("@LineaProducto", SqlDbType.VarChar, 250).Value = ObjMaster.EntidadProducto[0].LineaProducto;
                Comando.Parameters.Add("@PrecioProducto", SqlDbType.Decimal).Value = ObjMaster.EntidadProducto[0].PrecioProducto;

                try
                {
                    Comando.CommandTimeout = 900;
                    Comando.ExecuteNonQuery();
                    Rpta = Convert.ToInt32(Comando.Parameters["@CodigoProducto"].Value.ToString());
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
