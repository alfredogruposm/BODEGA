using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoSM_Recepcion.Services
{
    class AviosAlmacen
    {
        public class AvioAlmacen
        {
            public AvioAlmacen(string nombre, string tipo, decimal cantidad, int ID)
            {
                this.Nombre = nombre;
                this.Tipo = tipo;
                this.Cantidad = cantidad;
                this.ID = ID;                
            }

            //the next attribute prevents the EmployeeId column from showing
            //[Browsable(false)]
            public string Tipo { get; set; }
            public string Nombre { get; set; }
            public int ID { get; set; }
            public Decimal Cantidad { get; set; }
        }
    }
}
