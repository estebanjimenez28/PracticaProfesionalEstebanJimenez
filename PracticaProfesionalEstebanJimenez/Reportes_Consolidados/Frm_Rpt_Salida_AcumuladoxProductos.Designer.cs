namespace PracticaProfesionalEstebanJimenez.Reportes_Consolidados
{
    partial class Frm_Rpt_Salida_AcumuladoxProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rpt_Salida_AcumuladoxProductos));
            this.uSPReporteSalidaAcumuladoxProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_ReportesConsolidados = new PracticaProfesionalEstebanJimenez.Reportes_Consolidados.DataSet_ReportesConsolidados();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSP_Reporte_Salida_AcumuladoxProductoTableAdapter = new PracticaProfesionalEstebanJimenez.Reportes_Consolidados.DataSet_ReportesConsolidadosTableAdapters.USP_Reporte_Salida_AcumuladoxProductoTableAdapter();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteSalidaAcumuladoxProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportesConsolidados)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPReporteSalidaAcumuladoxProductoBindingSource
            // 
            this.uSPReporteSalidaAcumuladoxProductoBindingSource.DataMember = "USP_Reporte_Salida_AcumuladoxProducto";
            this.uSPReporteSalidaAcumuladoxProductoBindingSource.DataSource = this.dataSet_ReportesConsolidados;
            // 
            // dataSet_ReportesConsolidados
            // 
            this.dataSet_ReportesConsolidados.DataSetName = "DataSet_ReportesConsolidados";
            this.dataSet_ReportesConsolidados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPReporteSalidaAcumuladoxProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaProfesionalEstebanJimenez.Reportes_Consolidados.Rpt_Salida_AcumuladoxProd" +
    "uctos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1133, 596);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSP_Reporte_Salida_AcumuladoxProductoTableAdapter
            // 
            this.uSP_Reporte_Salida_AcumuladoxProductoTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(54, 137);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(141, 22);
            this.txt_p2.TabIndex = 11;
            this.txt_p2.Visible = false;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(54, 80);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(141, 22);
            this.txt_p1.TabIndex = 10;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Salida_AcumuladoxProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 596);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rpt_Salida_AcumuladoxProductos";
            this.Text = "Reporte Acumulado de Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Rpt_Salida_AcumuladoxProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteSalidaAcumuladoxProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportesConsolidados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPReporteSalidaAcumuladoxProductoBindingSource;
        private DataSet_ReportesConsolidados dataSet_ReportesConsolidados;
        private DataSet_ReportesConsolidadosTableAdapters.USP_Reporte_Salida_AcumuladoxProductoTableAdapter uSP_Reporte_Salida_AcumuladoxProductoTableAdapter;
        public System.Windows.Forms.TextBox txt_p2;
        public System.Windows.Forms.TextBox txt_p1;
    }
}