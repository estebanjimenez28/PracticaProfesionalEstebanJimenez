namespace PracticaProfesionalEstebanJimenez.Reportes
{
    partial class Frm_Rpt_Salida_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rpt_Salida_Productos));
            this.uSPListadoSalidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Carniceria = new PracticaProfesionalEstebanJimenez.Reportes.DataSet_Carniceria();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSP_Listado_SalidaTableAdapter = new PracticaProfesionalEstebanJimenez.Reportes.DataSet_CarniceriaTableAdapters.USP_Listado_SalidaTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoSalidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Carniceria)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPListadoSalidaBindingSource
            // 
            this.uSPListadoSalidaBindingSource.DataMember = "USP_Listado_Salida";
            this.uSPListadoSalidaBindingSource.DataSource = this.dataSet_Carniceria;
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
            reportDataSource1.Value = this.uSPListadoSalidaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaProfesionalEstebanJimenez.Reportes.Rpt_SalidaProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1182, 570);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSP_Listado_SalidaTableAdapter
            // 
            this.uSP_Listado_SalidaTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(40, 83);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(141, 22);
            this.txt_p1.TabIndex = 7;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Salida_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 570);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rpt_Salida_Productos";
            this.Text = "REPORTE VENTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Rpt_Salida_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoSalidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Carniceria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadoSalidaBindingSource;
        private DataSet_Carniceria dataSet_Carniceria;
        private DataSet_CarniceriaTableAdapters.USP_Listado_SalidaTableAdapter uSP_Listado_SalidaTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}