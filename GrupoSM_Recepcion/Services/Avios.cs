using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoSM_Recepcion.Services
{
    class Avios
    {
        public class Avio
        {
            public Avio(string nombre, string tipo, int ID, int Clave)
            {
                this.Nombre = nombre;
                this.Tipo = tipo;
                this.ID = ID;
                this.Clave = Clave;
            }                     

            //the next attribute prevents the EmployeeId column from showing
            //[Browsable(false)]
            public int Clave { get; set; }
            public string Tipo { get; set; }
            public string Nombre { get; set; }
            public int ID { get; set; }
        }
    }
}
