﻿namespace PracticaProfesionalEstebanJimenez.Reportes_Consolidados
{
    partial class Frm_Reporte_IngresoAcumuladoxProducto
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
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(493, 147);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(112, 35);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnVista
            // 
            this.BtnVista.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVista.ForeColor = System.Drawing.Color.White;
            this.BtnVista.Location = new System.Drawing.Point(493, 98);
            this.BtnVista.Name = "BtnVista";
            this.BtnVista.Size = new System.Drawing.Size(112, 31);
            this.BtnVista.TabIndex = 10;
            this.BtnVista.Text = "Vista Previa";
            this.BtnVista.UseVisualStyleBackColor = false;
            this.BtnVista.Click += new System.EventHandler(this.BtnVista_Click);
            // 
            // Dtp_Fecha_fin
            // 
            this.Dtp_Fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_fin.Location = new System.Drawing.Point(316, 147);
            this.Dtp_Fecha_fin.Name = "Dtp_Fecha_fin";
            this.Dtp_Fecha_fin.Size = new System.Drawing.Size(101, 22);
            this.Dtp_Fecha_fin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Inicio:";
            // 
            // Dtp_Fecha_Ini
            // 
            this.Dtp_Fecha_Ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Ini.Location = new System.Drawing.Point(316, 107);
            this.Dtp_Fecha_Ini.Name = "Dtp_Fecha_Ini";
            this.Dtp_Fecha_Ini.Size = new System.Drawing.Size(101, 22);
            this.Dtp_Fecha_Ini.TabIndex = 6;
            // 
            // Frm_Reporte_IngresoAcumuladoxProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 324);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnVista);
            this.Controls.Add(this.Dtp_Fecha_fin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtp_Fecha_Ini);
            this.Name = "Frm_Reporte_IngresoAcumuladoxProducto";
            this.Text = "Frm_Reporte_IngresoAcumuladoxProducto";
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