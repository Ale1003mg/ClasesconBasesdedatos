using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesConectarbasesdedatos;

namespace ClasesConectarbasesdedatos
{
    class Insertar :PClass
    {
        public int Insert()
        {
            try
            {

            
            SqlConnection cn = new SqlConnection(Conexion);
            SqlCommand sql = new SqlCommand();
            cn.Open();
            sql.Connection = cn;
            sql.CommandType.ToString();
            sql.CommandText = "insert into Estudiante values(@Nombre,@PApellido,@SApellido,@Edad) ";
            sql.Parameters.Add("@Nombre",SqlDbType.NVarChar);
            sql.Parameters.Add("@PApellido", SqlDbType.NVarChar);
            sql.Parameters.Add("@SApellido", SqlDbType.NVarChar);
            sql.Parameters.Add("@Edad", SqlDbType.Int);
            sql.Parameters["@Nombre"].Value = Nombre;
            sql.Parameters["@PApellido"].Value = PApellido;
            sql.Parameters["@SApellido"].Value = SApellido;
            sql.Parameters["@Edad"].Value = Edad;
            sql.ExecuteNonQuery();
            cn.Close();
                return 1;
            }
            catch (Exception)
            {
                return 2;//Error de conexion
                throw;
            }

            //return 0;
        }

        public int Cargar()
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conexion);
                SqlCommand sql = new SqlCommand();
                sql.Connection = cn;
                sql.CommandType.ToString();
                sql.CommandText = "Select * from Estudiante where estudiante_id=@id";
                sql.Parameters.Add("@id", SqlDbType.Int);
                sql.Parameters["@id"].Value = ID;
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ID = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    Nombre = ds.Tables[0].Rows[0][1].ToString();
                    PApellido = ds.Tables[0].Rows[0][2].ToString();
                    SApellido = ds.Tables[0].Rows[0][3].ToString();
                    Edad = Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());
                    return 1;
                }
                else {
                    return 3;
                }

               
            }
            catch (Exception)
            {
                return 2;
                throw;
            }
        }
    }
}
