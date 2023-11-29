namespace PracticaProfesionalEstebanJimenez.Reportes_Consolidados
{
    partial class Frm_Reporte_Ingreso_ComprasxProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reporte_Ingreso_ComprasxProductos));
            this.Dtp_Fecha_Ini = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp_Fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.BtnVista = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dtp_Fecha_Ini
            // 
            this.Dtp_Fecha_Ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Ini.Location = new System.Drawing.Point(262, 106);
            this.Dtp_Fecha_Ini.Name = "Dtp_Fecha_Ini";
            this.Dtp_Fecha_Ini.Size = new System.Drawing.Size(123, 27);
            this.Dtp_Fecha_Ini.TabIndex = 0;
            this.Dtp_Fecha_Ini.ValueChanged += new System.EventHandler(this.Dtp_Fecha_Ini_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Inicio:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Fin:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Dtp_Fecha_fin
            // 
            this.Dtp_Fecha_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_fin.Location = new System.Drawing.Point(262, 161);
            this.Dtp_Fecha_fin.Name = "Dtp_Fecha_fin";
            this.Dtp_Fecha_fin.Size = new System.Drawing.Size(123, 27);
            this.Dtp_Fecha_fin.TabIndex = 3;
            this.Dtp_Fecha_fin.ValueChanged += new System.EventHandler(this.Dtp_Fecha_fin_ValueChanged);
            // 
            // BtnVista
            // 
            this.BtnVista.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVista.ForeColor = System.Drawing.Color.White;
            this.BtnVista.Location = new System.Drawing.Point(467, 98);
            this.BtnVista.Name = "BtnVista";
            this.BtnVista.Size = new System.Drawing.Size(137, 47);
            this.BtnVista.TabIndex = 4;
            this.BtnVista.Text = "Vista Previa";
            this.BtnVista.UseVisualStyleBackColor = false;
            this.BtnVista.Click += new System.EventHandler(this.BtnVista_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Maroon;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(467, 161);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(137, 47);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Frm_Reporte_Ingreso_ComprasxProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 324);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnVista);
            this.Controls.Add(this.Dtp_Fecha_fin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtp_Fecha_Ini);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Reporte_Ingreso_ComprasxProductos";
            this.Text = "REPORTE DE INGRESOS DE COMPRAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Ini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_fin;
        private System.Windows.Forms.Button BtnVista;
        private System.Windows.Forms.Button BtnSalir;
    }
}