using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using _1_UNFV.PF.Entidades;
using _2_UNFV.PF.Interfaces;
    
namespace _3_UNFV.PF.DataAccess
{
    public class AlumnoData: IAccesoDatos
    {
        public string StringConnection = String.Empty;

        public AlumnoData()
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
                Comando = new SqlCommand("Alumno_Insertar", Connection);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@NombresAlumno", SqlDbType.VarChar, 50).Value = ObjMaster.EntidadAlumno[0].NombresAlumno;
                Comando.Parameters.Add("@ApellidosAlumno", SqlDbType.VarChar, 50).Value = ObjMaster.EntidadAlumno[0].ApellidosAlumno;
                Comando.Parameters.Add("@Practica1", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].Practica1;
                Comando.Parameters.Add("@Practica2", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].Practica2;
                Comando.Parameters.Add("@Practica3", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].Practica3;
                Comando.Parameters.Add("@Practica4", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].Practica4;
                Comando.Parameters.Add("@PromedioPracticas", SqlDbType.Decimal).Value = ObjMaster.EntidadAlumno[0].PromedioPracticas;
                Comando.Parameters.Add("@ExamenParcial", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].ExamenParcial;
                Comando.Parameters.Add("@ExamenFinal", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].ExamenFinal;
                Comando.Parameters.Add("@PromedioFinal", SqlDbType.Decimal).Value = ObjMaster.EntidadAlumno[0].PromedioFinal;
                Comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = ObjMaster.EntidadAlumno[0].Estado;
                Comando.Parameters.Add("@CodigoAlumno", SqlDbType.Int).Direction = ParameterDirection.Output;

                try
                {
                    Comando.CommandTimeout = 900;
                    Comando.ExecuteNonQuery();
                    Rpta = Convert.ToInt32(Comando.Parameters["@CodigoAlumno"].Value.ToString());
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
            SqlCommand Comando = null;
            int Rpta = -1;

            using (SqlConnection Connection = new SqlConnection(StringConnection))
            {
                Connection.Open();
                Comando = new SqlCommand("Alumno_Actualizar", Connection);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@CodigoAlumno", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].CodigoAlumno;
                Comando.Parameters.Add("@NombresAlumno", SqlDbType.VarChar, 50).Value = ObjMaster.EntidadAlumno[0].NombresAlumno;
                Comando.Parameters.Add("@ApellidosAlumno", SqlDbType.VarChar, 50).Value = ObjMaster.EntidadAlumno[0].ApellidosAlumno;
                Comando.Parameters.Add("@Practica1", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].Practica1;
                Comando.Parameters.Add("@Practica2", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].Practica2;
                Comando.Parameters.Add("@Practica3", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].Practica3;
                Comando.Parameters.Add("@Practica4", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].Practica4;
                Comando.Parameters.Add("@PromedioPracticas", SqlDbType.Decimal).Value = ObjMaster.EntidadAlumno[0].PromedioPracticas;
                Comando.Parameters.Add("@ExamenParcial", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].ExamenParcial;
                Comando.Parameters.Add("@ExamenFinal", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].ExamenFinal;
                Comando.Parameters.Add("@PromedioFinal", SqlDbType.Decimal).Value = ObjMaster.EntidadAlumno[0].PromedioFinal;
                Comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = ObjMaster.EntidadAlumno[0].Estado;

                try
                {
                    Comando.CommandTimeout = 900;
                    Comando.ExecuteNonQuery();
                    Rpta = 1;
                }
                catch (Exception ex)
                {
                    Rpta = -1;
                }
            }
            return Rpta;
        }

        int IAccesoDatos.Eliminar(ClaseMaster ObjMaster)
        {
            SqlCommand Comando = null;
            int Rpta = -1;

            using (SqlConnection Connection = new SqlConnection(StringConnection))
            {
                Connection.Open();
                Comando = new SqlCommand("Alumno_Eliminar", Connection);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@CodigoAlumno", SqlDbType.Int).Value = ObjMaster.EntidadAlumno[0].CodigoAlumno;

                try
                {
                    Comando.CommandTimeout = 900;
                    Comando.ExecuteNonQuery();
                    Rpta = 1;
                }
                catch (Exception ex)
                {
                    Rpta = -1;
                }
            }
            return Rpta;
        }

        public List<Alumno> ListarAlumnos(Alumno objAlumno)
        {
            SqlCommand Comando = null;
            List<Alumno> Lista = new List<Alumno>();
            Alumno Item = null;

            using (SqlConnection Connection = new SqlConnection(StringConnection))
            {
                Connection.Open();
                Comando = new SqlCommand("Alumno_BuscarCodigo", Connection);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@CodigoAlumno", SqlDbType.Int).Value = objAlumno.CodigoAlumno;

                try
                {
                    Comando.CommandTimeout = 900;
                    SqlDataReader dr = Comando.ExecuteReader();

                    while (dr.Read())
                    {
                        int CodigoAlumnoIndex = dr.GetOrdinal("CodigoAlumno");
                        int ApellidosAlumnoIndex = dr.GetOrdinal("ApellidosAlumno");
                        int NombresAlumnoIndex = dr.GetOrdinal("NombresAlumno");
                        int Practica1Index = dr.GetOrdinal("Practica1");
                        int Practica2Index = dr.GetOrdinal("Practica2");
                        int Practica3Index = dr.GetOrdinal("Practica3");
                        int Practica4Index = dr.GetOrdinal("Practica4");
                        int PromedioPracticasIndex = dr.GetOrdinal("PromedioPracticas");
                        int ExamenParcialIndex = dr.GetOrdinal("ExamenParcial");
                        int ExamenFinalIndex = dr.GetOrdinal("ExamenFinal");
                        int PromedioFinalIndex = dr.GetOrdinal("PromedioFinal");
                        int EstadoIndex = dr.GetOrdinal("Estado");

                        Item = new Alumno();

                        if (!dr.IsDBNull(CodigoAlumnoIndex))
                        {
                            Item.CodigoAlumno = Convert.ToInt32(dr["CodigoAlumno"].ToString());
                        }

                        if (!dr.IsDBNull(ApellidosAlumnoIndex))
                        {
                            Item.ApellidosAlumno = Convert.ToString(dr["ApellidosAlumno"]);
                        }

                        if (!dr.IsDBNull(NombresAlumnoIndex))
                        {
                            Item.NombresAlumno = Convert.ToString(dr["NombresAlumno"]);
                        }

                        if (!dr.IsDBNull(Practica1Index))
                        {
                            Item.Practica1 = Convert.ToInt32(dr["Practica1"].ToString());
                        }

                        if (!dr.IsDBNull(Practica2Index))
                        {
                            Item.Practica2 = Convert.ToInt32(dr["Practica2"].ToString());
                        }

                        if (!dr.IsDBNull(Practica3Index))
                        {
                            Item.Practica3 = Convert.ToInt32(dr["Practica3"].ToString());
                        }

                        if (!dr.IsDBNull(Practica4Index))
                        {
                            Item.Practica4 = Convert.ToInt32(dr["Practica4"].ToString());
                        }

                        if (!dr.IsDBNull(PromedioPracticasIndex))
                        {
                            Item.PromedioPracticas = Convert.ToDecimal(dr["PromedioPracticas"].ToString());
                        }

                        if (!dr.IsDBNull(ExamenParcialIndex))
                        {
                            Item.ExamenParcial = Convert.ToInt32(dr["ExamenParcial"].ToString());
                        }

                        if (!dr.IsDBNull(ExamenFinalIndex))
                        {
                            Item.ExamenFinal = Convert.ToInt32(dr["ExamenFinal"].ToString());
                        }

                        if (!dr.IsDBNull(PromedioFinalIndex))
                        {
                            Item.PromedioFinal = Convert.ToDecimal(dr["PromedioFinal"].ToString());
                        }

                        Lista.Add(Item);
                        Item = null;
                    }
                    Connection.Close();
                    dr.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Lista;
        }
                
        public List<Alumno> Buscar(Alumno ObjAlumno)
        {
            SqlCommand Comando = null;
            List<Alumno> DatoAlumno = new List<Alumno>();
            Alumno Item = null;

            using (SqlConnection Connection = new SqlConnection(StringConnection))
            {
                Connection.Open();
                Comando = new SqlCommand("Alumno_Buscar", Connection);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@ApellidosAlumno", SqlDbType.VarChar, 50).Value = ObjAlumno.ApellidosAlumno;

                try
                {
                    Comando.CommandTimeout = 900;
                    SqlDataReader dr = Comando.ExecuteReader();

                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            Item = new Alumno();

                            Item.NombresAlumno = Convert.ToString(dr["NombresAlumno"]);
                            Item.ApellidosAlumno = Convert.ToString(dr["ApellidosAlumno"]);
                            Item.Practica1 = Convert.ToInt32(dr["Practica1"]);
                            Item.Practica2 = Convert.ToInt32(dr["Practica2"]);
                            Item.Practica3 = Convert.ToInt32(dr["Practica3"]);
                            Item.Practica4 = Convert.ToInt32(dr["Practica4"]);
                            Item.PromedioPracticas = Convert.ToDecimal(dr["PromedioPracticas"]);
                            Item.ExamenParcial = Convert.ToInt32(dr["ExamenParcial"]);
                            Item.ExamenFinal = Convert.ToInt32(dr["ExamenFinal"]);
                            Item.PromedioFinal = Convert.ToDecimal(dr["PromedioFinal"]);
                            Item.Estado = Convert.ToBoolean(dr["Estado"]);
                            DatoAlumno.Add(Item);
                        }
                    }
                    Connection.Close();
                    dr.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return DatoAlumno;
        }

        public List<Alumno> BuscarCodigo(Alumno ObjAlumno)
        {
            SqlCommand Comando = null;
            List<Alumno> DatoAlumno = new List<Alumno>();
            Alumno Item = null;

            using (SqlConnection Connection = new SqlConnection(StringConnection))
            {
                Connection.Open();
                Comando = new SqlCommand("Alumno_BuscarCodigo", Connection);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@CodigoAlumno", SqlDbType.Int).Value = ObjAlumno.CodigoAlumno;

                try
                {
                    Comando.CommandTimeout = 900;
                    SqlDataReader dr = Comando.ExecuteReader();

                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            Item = new Alumno();

                            Item.NombresAlumno = Convert.ToString(dr["NombresAlumno"]);
                            Item.ApellidosAlumno = Convert.ToString(dr["ApellidosAlumno"]);
                            Item.Practica1 = Convert.ToInt32(dr["Practica1"]);
                            Item.Practica2 = Convert.ToInt32(dr["Practica2"]);
                            Item.Practica3 = Convert.ToInt32(dr["Practica3"]);
                            Item.Practica4 = Convert.ToInt32(dr["Practica4"]);
                            Item.PromedioPracticas = Convert.ToDecimal(dr["PromedioPracticas"]);
                            Item.ExamenParcial = Convert.ToInt32(dr["ExamenParcial"]);
                            Item.ExamenFinal = Convert.ToInt32(dr["ExamenFinal"]);
                            Item.PromedioFinal = Convert.ToDecimal(dr["PromedioFinal"]);
                            Item.Estado = Convert.ToBoolean(dr["Estado"]);
                            DatoAlumno.Add(Item);
                        }
                    }
                    Connection.Close();
                    dr.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return DatoAlumno;
        }        
    }
}
