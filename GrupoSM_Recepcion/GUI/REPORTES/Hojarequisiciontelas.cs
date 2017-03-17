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
    public partial class Hojarequisiciontelas : Form
    {
        public Hojarequisiciontelas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public int idficha { get; set; }
        public int idproduccion { get; set; }
    

        private void Hojarequisiciontelas_Load(object sender, EventArgs e)
        {
            DAO.Oden_ProduccionDAO ordendao = new GrupoSM_Recepcion.DAO.Oden_ProduccionDAO();
            ordendao.idorden = this.idproduccion;

            DAO.TelasDAO telasdao = new GrupoSM_Recepcion.DAO.TelasDAO();

            telasdao.produccion = this.idproduccion;

           // GUI.PLANTILLAS.RequisicionTelas report = new PLANTILLAS.RequisicionTelas();

            //report.SetDataSource(telasdao.telasrequisicion());

            //report.Subreports[0].SetDataSource(ordendao.datosproduccionreporte());

            //crystalReportViewer1.ReportSource = report;

            crystalReportViewer1.Refresh();
        }
    }
}
