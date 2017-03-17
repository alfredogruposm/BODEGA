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
    public partial class SeleccionarOrdenTela : Form
    {
        public SeleccionarOrdenTela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI.Bodega.TelasControl telasctrl = new TelasControl();
            telasctrl.label10.Text = dataGridView1.CurrentRow.Cells["id_orden"].Value.ToString();
            telasctrl.Show();
        }

        private void SeleccionarOrdenTela_Load(object sender, EventArgs e)
        {
            DAO.Oden_ProduccionDAO producciondao = new DAO.Oden_ProduccionDAO();
            dataGridView1.DataSource = producciondao.ordenesvistatelas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedIndex == 0)
            //{
            //    //GUI.REPORTES.TelasBodegaVistas_Almacen reportealmacen = new REPORTES.TelasBodegaVistas_Almacen();
            //    reportealmacen.Show();
            //}
            //else
            //{
            //    if (comboBox1.SelectedIndex == 1)
            //    {
            //       // GUI.REPORTES.TelasBodegaVista_porNombre telasbodega = new REPORTES.TelasBodegaVista_porNombre();
            //        telasbodega.nombretela = dataGridView1.CurrentRow.Cells["id_orden"].Value.ToString();
            //    }
            //    if (comboBox1.SelectedIndex == 2)
            //    {
            //       // GUI.REPORTES.TelasBodegaVista_porCliente reporteclientesalmacen = new REPORTES.TelasBodegaVista_porCliente();
            //        reporteclientesalmacen.idcliente = Convert.ToInt16(dataGridView1.CurrentRow.Cells["id_cliente"].Value);


            //        reporteclientesalmacen.ShowDialog();
            //    }                
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GUI.Bodega.Telas_Captura telasgui = new Telas_Captura();
            telasgui.lbl_consumocombinacion.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["consumo_conbinacion"].Value);
            telasgui.lbl_consumoforro.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["consumo_forro"].Value);
            telasgui.tb_forro.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["forro"].Value);
            telasgui.lbl_idorden.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id_orden"].Value);
            telasgui.tb_tela.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["tela"].Value);
            telasgui.tb_combinacion.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["combinacion"].Value);
            telasgui.lbl_cliente.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id_cliente"].Value);
            telasgui.ShowDialog();
            DAO.Oden_ProduccionDAO ordendao = new GrupoSM_Recepcion.DAO.Oden_ProduccionDAO();

            dataGridView1.DataSource = ordendao.ordenesvistatelas();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string campo = "asunto";

            DAO.AviosDAO aviosdao = new GrupoSM_Recepcion.DAO.AviosDAO();

            DataView dv;

            DAO.Oden_ProduccionDAO ordendao = new GrupoSM_Recepcion.DAO.Oden_ProduccionDAO();

            dv = new DataView(ordendao.ordenesvistatelas());

            dv.RowFilter = campo + " like '%" + textBox5.Text + "%'";

            dataGridView1.DataSource = dv;
        }
    }
}
