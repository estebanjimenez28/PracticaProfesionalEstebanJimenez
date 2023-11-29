namespace PracticaProfesionalEstebanJimenez.Reportes_Consolidados
{
    partial class Frm_Reporte_VentasxProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reporte_VentasxProductos));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnVista = new System.Windows.Forms.Button();
            this.Dtp_Fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Ini = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Maroon;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(538, 171);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(138, 41);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnVista
            // 
            this.BtnVista.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVista.ForeColor = System.Drawing.Color.White;
            this.BtnVista.Location = new System.Drawing.Point(538, 112);
            this.BtnVista.Name = "BtnVista";
            this.BtnVista.Size = new System.Drawing.Size(138, 44);
            this.BtnVista.TabIndex = 10;
            this.BtnVista.Text = "Vista Previa";
            this.BtnVista.UseVisualStyleBackColor = false;
            this.BtnVista.Click += new System.EventHandler(this.BtnVista_Click);
            // 
            // Dtp_Fecha_fin
            // 
            this.Dtp_Fecha_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_fin.Location = new System.Drawing.Point(315, 176);
            this.Dtp_Fecha_fin.Name = "Dtp_Fecha_fin";
            this.Dtp_Fecha_fin.Size = new System.Drawing.Size(155, 27);
            this.Dtp_Fecha_fin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Inicio:";
            // 
            // Dtp_Fecha_Ini
            // 
            this.Dtp_Fecha_Ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Ini.Location = new System.Drawing.Point(315, 121);
            this.Dtp_Fecha_Ini.Name = "Dtp_Fecha_Ini";
            this.Dtp_Fecha_Ini.Size = new System.Drawing.Size(155, 27);
            this.Dtp_Fecha_Ini.TabIndex = 6;
            // 
            // Frm_Reporte_VentasxProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 392);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnVista);
            this.Controls.Add(this.Dtp_Fecha_fin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtp_Fecha_Ini);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Reporte_VentasxProductos";
            this.Text = "REPORTE DE INGRESOS POR VENTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnVista;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_fin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Ini;
    }
}