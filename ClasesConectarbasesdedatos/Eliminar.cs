using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesConectarbasesdedatos
{
    class Eliminar : PClass
    {

        public int Delete() {
            try
            {
            SqlConnection cn = new SqlConnection(Conexion);
            SqlCommand Sql = new SqlCommand();
            Sql.Connection = cn;
            Sql.CommandType.ToString();
            Sql.CommandText = "Delete from Estudiante where estudiante_id=@id ";
            Sql.Parameters.Add("@id", SqlDbType.Int);
            Sql.Parameters["@id"].Value = ID;
            SqlDataAdapter da = new SqlDataAdapter(Sql);
            DataSet ds = new DataSet();
            da.Fill(ds);
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
