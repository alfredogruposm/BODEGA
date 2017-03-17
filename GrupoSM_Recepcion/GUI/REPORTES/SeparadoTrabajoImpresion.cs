using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoSM_Recepcion.GUI.REPORTES
{
    public partial class SeparadoTrabajoImpresion : Form
    {
        public int orden { get; set; }
        public SeparadoTrabajoImpresion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void SeparadoTrabajoImpresion_Load(object sender, EventArgs e)
        {
            GUI.PLANTILLAS.TrabajoSeparadoHojaCorte report = new PLANTILLAS.TrabajoSeparadoHojaCorte();
            DAO.PiezasDAO piezasdao = new DAO.PiezasDAO();
            piezasdao.orden = this.orden;
            report.SetDataSource(piezasdao.devuelveordentrabajoseparado());
            //report.Subreports["NumeroprendasRPT"].SetDataSource(ordendao.numeroprendasreporte());
            //report.Subreports["AviosSubRPT"].SetDataSource(aviosdao.sacar_avios());
            //report.Subreports["AviosRpt"].SetDataSource(aviosdao.aviosimpresion());
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
