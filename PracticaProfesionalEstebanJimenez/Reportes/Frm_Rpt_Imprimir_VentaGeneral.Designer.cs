﻿namespace PracticaProfesionalEstebanJimenez.Reportes
{
    partial class Frm_Rpt_Imprimir_VentaGeneral
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rpt_Imprimir_VentaGeneral));
            this.uSPImprimirVentaGeneradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Carniceria = new PracticaProfesionalEstebanJimenez.Reportes.DataSet_Carniceria();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSP_Imprimir_Venta_GeneradaTableAdapter = new PracticaProfesionalEstebanJimenez.Reportes.DataSet_CarniceriaTableAdapters.USP_Imprimir_Venta_GeneradaTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uSPImprimirVentaGeneradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Carniceria)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPImprimirVentaGeneradaBindingSource
            // 
            this.uSPImprimirVentaGeneradaBindingSource.DataMember = "USP_Imprimir_Venta_Generada";
            this.uSPImprimirVentaGeneradaBindingSource.DataSource = this.dataSet_Carniceria;
            // 
            // dataSet_Carniceria
            // 
            this.dataSet_Carniceria.DataSetName = "DataSet_Carniceria";
            this.dataSet_Carniceria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPImprimirVentaGeneradaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaProfesionalEstebanJimenez.Reportes.Rpt_Imprimir_Venta_Generada.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(598, 838);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSP_Imprimir_Venta_GeneradaTableAdapter
            // 
            this.uSP_Imprimir_Venta_GeneradaTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 57);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(141, 22);
            this.txt_p1.TabIndex = 3;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Imprimir_VentaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 838);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Rpt_Imprimir_VentaGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Rpt_Imprimir_VentaGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPImprimirVentaGeneradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Carniceria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPImprimirVentaGeneradaBindingSource;
        private DataSet_Carniceria dataSet_Carniceria;
        private DataSet_CarniceriaTableAdapters.USP_Imprimir_Venta_GeneradaTableAdapter uSP_Imprimir_Venta_GeneradaTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}