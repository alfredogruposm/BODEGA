using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoSM_Recepcion.GUI.Bodega
{
    public partial class ImpresionesAvios : Form
    {
        public ImpresionesAvios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                DAO.AviosDAO aviosdao = new DAO.AviosDAO();

                dataGridView2.DataSource = aviosdao.existenciascatalogoalmacenavios();

                BindingSource source = new BindingSource();

                string nombre, tipo;
                int id;
                decimal cantidad; 

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    aviosdao.nombre = row.Cells[0].Value.ToString();

                    dataGridView3.DataSource = aviosdao.datoscatalogoalmacenavios();

                    nombre = row.Cells[0].Value.ToString();
                    cantidad = Convert.ToDecimal(row.Cells[1].Value.ToString());
                    foreach (DataGridViewRow row1 in dataGridView3.Rows)
                    {
                        tipo = row1.Cells[0].Value.ToString();

                        id = Convert.ToInt16(row1.Cells[0].Value);

                        source.Add(new Services.AviosAlmacen.AvioAlmacen(nombre, tipo, cantidad, id));
                    }
                }

                dataGridView1.DataSource = source;

            }
        }
    }
}
