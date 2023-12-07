namespace PracticaProfesionalEstebanJimenez.Reportes
{
    partial class Frm_Rpt_Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rpt_Categorias));
            this.uSPListadocaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Carniceria = new PracticaProfesionalEstebanJimenez.Reportes.DataSet_Carniceria();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            this.uSP_Listado_caTableAdapter = new PracticaProfesionalEstebanJimenez.Reportes.DataSet_CarniceriaTableAdapters.USP_Listado_caTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadocaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Carniceria)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPListadocaBindingSource
            // 
            this.uSPListadocaBindingSource.DataMember = "USP_Listado_ca";
            this.uSPListadocaBindingSource.DataSource = this.dataSet_Carniceria;
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
            reportDataSource1.Value = this.uSPListadocaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaProfesionalEstebanJimenez.Reportes.Rpt_Categorias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1054, 533);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(102, 85);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(178, 22);
            this.txt_p1.TabIndex = 1;
            this.txt_p1.Visible = false;
            // 
            // uSP_Listado_caTableAdapter
            // 
            this.uSP_Listado_caTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Rpt_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 533);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rpt_Categorias";
            this.Text = "Reporte de Categorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Rpt_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadocaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Carniceria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadocaBindingSource;
        private DataSet_Carniceria dataSet_Carniceria;
        private DataSet_CarniceriaTableAdapters.USP_Listado_caTableAdapter uSP_Listado_caTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}