namespace PracticaProfesionalEstebanJimenez.Reportes_Consolidados
{
    partial class Frm_Rpt_IngresosxProductos
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
            this.uSPReporteIngresosComprasxProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_ReportesConsolidados = new PracticaProfesionalEstebanJimenez.Reportes_Consolidados.DataSet_ReportesConsolidados();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSP_Reporte_Ingresos_ComprasxProductosTableAdapter = new PracticaProfesionalEstebanJimenez.Reportes_Consolidados.DataSet_ReportesConsolidadosTableAdapters.USP_Reporte_Ingresos_ComprasxProductosTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteIngresosComprasxProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportesConsolidados)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPReporteIngresosComprasxProductosBindingSource
            // 
            this.uSPReporteIngresosComprasxProductosBindingSource.DataMember = "USP_Reporte_Ingresos_ComprasxProductos";
            this.uSPReporteIngresosComprasxProductosBindingSource.DataSource = this.dataSet_ReportesConsolidados;
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
            reportDataSource1.Value = this.uSPReporteIngresosComprasxProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaProfesionalEstebanJimenez.Reportes_Consolidados.Rpt_Ingreso_ComprasxProdu" +
    "ctos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1242, 633);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSP_Reporte_Ingresos_ComprasxProductosTableAdapter
            // 
            this.uSP_Reporte_Ingresos_ComprasxProductosTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(34, 68);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(141, 22);
            this.txt_p1.TabIndex = 6;
            this.txt_p1.Visible = false;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(34, 125);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(141, 22);
            this.txt_p2.TabIndex = 7;
            this.txt_p2.Visible = false;
            // 
            // Frm_Rpt_IngresosxProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 633);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_IngresosxProductos";
            this.Text = "Frm_Rpt_IngresosxProductos";
            this.Load += new System.EventHandler(this.Frm_Rpt_IngresosxProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteIngresosComprasxProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportesConsolidados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPReporteIngresosComprasxProductosBindingSource;
        private DataSet_ReportesConsolidados dataSet_ReportesConsolidados;
        private DataSet_ReportesConsolidadosTableAdapters.USP_Reporte_Ingresos_ComprasxProductosTableAdapter uSP_Reporte_Ingresos_ComprasxProductosTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
        public System.Windows.Forms.TextBox txt_p2;
    }
}