namespace PracticaProfesionalEstebanJimenez.Reportes_Consolidados
{
    partial class Frm_Rpt_VentasxProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rpt_VentasxProductos));
            this.uSPReporteSalidaVentasxProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_ReportesConsolidados = new PracticaProfesionalEstebanJimenez.Reportes_Consolidados.DataSet_ReportesConsolidados();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSP_Reporte_Salida_VentasxProductosTableAdapter = new PracticaProfesionalEstebanJimenez.Reportes_Consolidados.DataSet_ReportesConsolidadosTableAdapters.USP_Reporte_Salida_VentasxProductosTableAdapter();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteSalidaVentasxProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportesConsolidados)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPReporteSalidaVentasxProductosBindingSource
            // 
            this.uSPReporteSalidaVentasxProductosBindingSource.DataMember = "USP_Reporte_Salida_VentasxProductos";
            this.uSPReporteSalidaVentasxProductosBindingSource.DataSource = this.dataSet_ReportesConsolidados;
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
            reportDataSource1.Value = this.uSPReporteSalidaVentasxProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaProfesionalEstebanJimenez.Reportes_Consolidados.Rpt_Salidas_VentasxProduc" +
    "tos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1099, 579);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSP_Reporte_Salida_VentasxProductosTableAdapter
            // 
            this.uSP_Reporte_Salida_VentasxProductosTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(36, 127);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(141, 22);
            this.txt_p2.TabIndex = 9;
            this.txt_p2.Visible = false;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(36, 70);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(141, 22);
            this.txt_p1.TabIndex = 8;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_VentasxProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 579);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rpt_VentasxProductos";
            this.Text = "Frm_Rpt_VentasxProductos";
            this.Load += new System.EventHandler(this.Frm_Rpt_VentasxProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteSalidaVentasxProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportesConsolidados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPReporteSalidaVentasxProductosBindingSource;
        private DataSet_ReportesConsolidados dataSet_ReportesConsolidados;
        private DataSet_ReportesConsolidadosTableAdapters.USP_Reporte_Salida_VentasxProductosTableAdapter uSP_Reporte_Salida_VentasxProductosTableAdapter;
        public System.Windows.Forms.TextBox txt_p2;
        public System.Windows.Forms.TextBox txt_p1;
    }
}