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
    public partial class GrupoSM : Form
    {
        public GrupoSM()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAO.Oden_ProduccionDAO ordendao = new DAO.Oden_ProduccionDAO();
            ordendao.respaldo = DateTime.Now;
            
            string respuesta = ordendao.respaldabasededatos();
            MessageBox.Show(respuesta);
        }

        private void GrupoSM_Load(object sender, EventArgs e)
        {

        }
    }
}
