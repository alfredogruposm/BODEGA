﻿namespace GrupoSM_Recepcion.GUI.REPORTES
{
    partial class Pruebatallas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.salidaMaquilaRPT1 = new GrupoSM_Recepcion.GUI.PLANTILLAS.SalidaMaquilaRPT();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(284, 262);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // Pruebatallas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Pruebatallas";
            this.Text = "Hoja Salida Maquila";
            this.Load += new System.EventHandler(this.Pruebatallas_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private GrupoSM_Recepcion.GUI.PLANTILLAS.CrystalReport1 CrystalReport11;
        private GrupoSM_Recepcion.GUI.PLANTILLAS.CrystalReport1 crystalReport12;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private GrupoSM_Recepcion.GUI.PLANTILLAS.SalidaMaquilaRPT salidaMaquilaRPT1;
    }
}