using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesConectarbasesdedatos
{
    class PClass
    {
        //Protegidas
        protected static string Conexion = "Data Source=ALEJANDRO\\SQLPRUEBAS;Initial Catalog=Escuela;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; 
        protected int ID { set; get; }
        protected string Nombre { get; set; }

        protected string PApellido { get; set; }

        protected string SApellido { get; set; }
        protected int Edad { get; set; }

        //Publicas
        public int ID2 (){return ID; }
        public string Nombre2() { return Nombre; }
        public string PApellido2() { return PApellido; }
        public string SApellido2() { return SApellido; }
        public int Edad2 () { return Edad; }


        public void ObtenerEstudiante(int id,string NombreAux,string PAaux,string SAaux,int edad) {
            ID = id;
            Nombre = NombreAux;
            PApellido = PAaux;
            SApellido = SAaux;
            Edad = edad;
        }
        
        
    }
}
