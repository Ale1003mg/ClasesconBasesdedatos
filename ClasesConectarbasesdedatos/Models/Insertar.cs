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
    }
}
