using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesConectarbasesdedatos
{
    class Modificar : PClass
    {
        public int Update()
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conexion);
                SqlCommand sql = new SqlCommand();
                cn.Open();
                sql.Connection = cn;
                sql.CommandType.ToString();
                sql.CommandText = "Update  Estudiante set nombre=@Nombre,primer_apellido=@PApellido,segundo_apellido=@SApellido,edad=@Edad where estudiante_id=@id ";
                sql.Parameters.Add("@id", SqlDbType.Int);
                sql.Parameters.Add("@Nombre", SqlDbType.NVarChar);
                sql.Parameters.Add("@PApellido", SqlDbType.NVarChar);
                sql.Parameters.Add("@SApellido", SqlDbType.NVarChar);
                sql.Parameters.Add("@Edad", SqlDbType.Int);
                sql.Parameters["@id"].Value = ID;
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
                return 2;
                throw;
            }
            //return 0;
        }
    }
}
