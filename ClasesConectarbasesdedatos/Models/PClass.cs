using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesConectarbasesdedatos
{
    class PClass
    {
        protected int ID { set; get; }
        protected String Nombre { get; set; }

        protected String PApellido { get; set; }

        protected String SApellido { get; set; }
        protected int Edad { get; set; }


        public void ObtenerEstudiante(int id,string NombreAux,string PAaux,string SAaux,int edad) {
            ID = id;
            Nombre = NombreAux;
            PApellido = PAaux;
            SApellido = SAaux;
            Edad = edad;
        }
    }
}
