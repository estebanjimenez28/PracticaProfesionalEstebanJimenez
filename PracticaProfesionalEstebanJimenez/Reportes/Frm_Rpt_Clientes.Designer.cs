namespace PracticaProfesionalEstebanJimenez.Reportes
{
    partial class Frm_Rpt_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rpt_Clientes));
            this.uSPListadoclBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Carniceria = new PracticaProfesionalEstebanJimenez.Reportes.DataSet_Carniceria();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSP_Listado_clTableAdapter = new PracticaProfesionalEstebanJimenez.Reportes.DataSet_CarniceriaTableAdapters.USP_Listado_clTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoclBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Carniceria)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPListadoclBindingSource
            // 
            this.uSPListadoclBindingSource.DataMember = "USP_Listado_cl";
            this.uSPListadoclBindingSource.DataSource = this.dataSet_Carniceria;
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
            reportDataSource1.Value = this.uSPListadoclBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PracticaProfesionalEstebanJimenez.Reportes.Rpt_Clientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1805, 577);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSP_Listado_clTableAdapter
            // 
            this.uSP_Listado_clTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(21, 74);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(141, 22);
            this.txt_p1.TabIndex = 3;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 577);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rpt_Clientes";
            this.Text = "Frm_Rpt_Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Rpt_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoclBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Carniceria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadoclBindingSource;
        private DataSet_Carniceria dataSet_Carniceria;
        private DataSet_CarniceriaTableAdapters.USP_Listado_clTableAdapter uSP_Listado_clTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}