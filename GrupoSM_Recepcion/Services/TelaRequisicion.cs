using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Resources;

namespace GrupoSM_Recepcion.Services
{
    class TelaRequisicion
    {
        public class Tela
        {
            public decimal Cantidad { get; set; }
            public string Tipo { get; set; }
            public string Nombre { get; set; }
            public string Color { get; set; }

            public Tela(string Nombre, string tipo, decimal cantidad, string color)
            {
                this.Nombre = Nombre;
                this.Tipo = tipo;
                this.Cantidad = cantidad;
                this.Color = color;
            }

        }
    }
}
    


