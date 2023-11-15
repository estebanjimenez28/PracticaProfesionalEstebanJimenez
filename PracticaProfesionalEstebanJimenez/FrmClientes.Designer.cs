namespace PracticaProfesionalEstebanJimenez
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TbpPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DgvPrincipal = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PnlIdentificacion = new System.Windows.Forms.Panel();
            this.DgvIdentificacion = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBuscarIdentificacion = new System.Windows.Forms.Button();
            this.TxtTipoIdentificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtObservacion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnRetornar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_Titulo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TbpPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.PnlIdentificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIdentificacion)).BeginInit();
            this.Pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Gray;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.ImageKey = "Cierre.png";
            this.BtnSalir.ImageList = this.imageList1;
            this.BtnSalir.Location = new System.Drawing.Point(627, 626);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(129, 113);
            this.BtnSalir.TabIndex = 34;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Actualizar.png");
            this.imageList1.Images.SetKeyName(1, "Cierre.png");
            this.imageList1.Images.SetKeyName(2, "Eliminar.png");
            this.imageList1.Images.SetKeyName(3, "nuevo.png");
            this.imageList1.Images.SetKeyName(4, "Reporte.png");
            // 
            // BtnReporte
            // 
            this.BtnReporte.BackColor = System.Drawing.Color.Gray;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.ForeColor = System.Drawing.Color.White;
            this.BtnReporte.ImageKey = "Reporte.png";
            this.BtnReporte.ImageList = this.imageList1;
            this.BtnReporte.Location = new System.Drawing.Point(474, 626);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(129, 113);
            this.BtnReporte.TabIndex = 33;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Gray;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.ImageKey = "Actualizar.png";
            this.BtnActualizar.ImageList = this.imageList1;
            this.BtnActualizar.Location = new System.Drawing.Point(169, 626);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(129, 113);
            this.BtnActualizar.TabIndex = 32;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Gray;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.ImageKey = "Eliminar.png";
            this.BtnEliminar.ImageList = this.imageList1;
            this.BtnEliminar.Location = new System.Drawing.Point(321, 626);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(129, 113);
            this.BtnEliminar.TabIndex = 31;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.Gray;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.ImageKey = "nuevo.png";
            this.BtnNuevo.ImageList = this.imageList1;
            this.BtnNuevo.Location = new System.Drawing.Point(16, 626);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(129, 113);
            this.BtnNuevo.TabIndex = 30;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // TbpPrincipal
            // 
            this.TbpPrincipal.Controls.Add(this.tabPage1);
            this.TbpPrincipal.Controls.Add(this.tabPage2);
            this.TbpPrincipal.Location = new System.Drawing.Point(12, 60);
            this.TbpPrincipal.Name = "TbpPrincipal";
            this.TbpPrincipal.SelectedIndex = 0;
            this.TbpPrincipal.Size = new System.Drawing.Size(1900, 531);
            this.TbpPrincipal.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.DgvPrincipal);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1892, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // DgvPrincipal
            // 
            this.DgvPrincipal.AllowUserToAddRows = false;
            this.DgvPrincipal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DgvPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.DgvPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DgvPrincipal.ColumnHeadersHeight = 35;
            this.DgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPrincipal.DefaultCellStyle = dataGridViewCellStyle15;
            this.DgvPrincipal.EnableHeadersVisualStyles = false;
            this.DgvPrincipal.Location = new System.Drawing.Point(22, 86);
            this.DgvPrincipal.Name = "DgvPrincipal";
            this.DgvPrincipal.ReadOnly = true;
            this.DgvPrincipal.RowHeadersWidth = 51;
            this.DgvPrincipal.RowTemplate.Height = 24;
            this.DgvPrincipal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvPrincipal.Size = new System.Drawing.Size(1658, 408);
            this.DgvPrincipal.TabIndex = 3;
            this.DgvPrincipal.DoubleClick += new System.EventHandler(this.DgvPrincipal_DoubleClick);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(562, 28);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(121, 38);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "CONSULTAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(256, 31);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(289, 30);
            this.TxtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PnlIdentificacion);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.TxtRazonSocial);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.BtnBuscarIdentificacion);
            this.tabPage2.Controls.Add(this.TxtTipoIdentificacion);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.TxtObservacion);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.TxtDireccion);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TxtTelefono);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.TxtEmail);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.TxtApellidos);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.TxtNombre);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.BtnRetornar);
            this.tabPage2.Controls.Add(this.BtnGuardar);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.TxtCedula);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1892, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PnlIdentificacion
            // 
            this.PnlIdentificacion.BackColor = System.Drawing.Color.White;
            this.PnlIdentificacion.Controls.Add(this.DgvIdentificacion);
            this.PnlIdentificacion.Location = new System.Drawing.Point(97, 115);
            this.PnlIdentificacion.Name = "PnlIdentificacion";
            this.PnlIdentificacion.Size = new System.Drawing.Size(521, 125);
            this.PnlIdentificacion.TabIndex = 43;
            this.PnlIdentificacion.Visible = false;
            // 
            // DgvIdentificacion
            // 
            this.DgvIdentificacion.AllowUserToAddRows = false;
            this.DgvIdentificacion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvIdentificacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DgvIdentificacion.BackgroundColor = System.Drawing.Color.White;
            this.DgvIdentificacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvIdentificacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DgvIdentificacion.ColumnHeadersHeight = 35;
            this.DgvIdentificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvIdentificacion.DefaultCellStyle = dataGridViewCellStyle18;
            this.DgvIdentificacion.EnableHeadersVisualStyles = false;
            this.DgvIdentificacion.Location = new System.Drawing.Point(3, 0);
            this.DgvIdentificacion.Name = "DgvIdentificacion";
            this.DgvIdentificacion.ReadOnly = true;
            this.DgvIdentificacion.RowHeadersWidth = 51;
            this.DgvIdentificacion.RowTemplate.Height = 24;
            this.DgvIdentificacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvIdentificacion.Size = new System.Drawing.Size(518, 116);
            this.DgvIdentificacion.TabIndex = 20;
            this.DgvIdentificacion.DoubleClick += new System.EventHandler(this.DgvIdentificacion_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(173, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 18);
            this.label8.TabIndex = 46;
            this.label8.Text = " Identificación (*):";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRazonSocial.Location = new System.Drawing.Point(354, 182);
            this.TxtRazonSocial.MaxLength = 100;
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(369, 24);
            this.TxtRazonSocial.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Razon Social (*):";
            // 
            // BtnBuscarIdentificacion
            // 
            this.BtnBuscarIdentificacion.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarIdentificacion.Image")));
            this.BtnBuscarIdentificacion.Location = new System.Drawing.Point(729, 59);
            this.BtnBuscarIdentificacion.Name = "BtnBuscarIdentificacion";
            this.BtnBuscarIdentificacion.Size = new System.Drawing.Size(48, 39);
            this.BtnBuscarIdentificacion.TabIndex = 42;
            this.BtnBuscarIdentificacion.UseCompatibleTextRendering = true;
            this.BtnBuscarIdentificacion.UseVisualStyleBackColor = true;
            this.BtnBuscarIdentificacion.Click += new System.EventHandler(this.BtnBuscarIdentificacion_Click);
            // 
            // TxtTipoIdentificacion
            // 
            this.TxtTipoIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoIdentificacion.Location = new System.Drawing.Point(354, 65);
            this.TxtTipoIdentificacion.Name = "TxtTipoIdentificacion";
            this.TxtTipoIdentificacion.ReadOnly = true;
            this.TxtTipoIdentificacion.Size = new System.Drawing.Size(369, 24);
            this.TxtTipoIdentificacion.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Tipo Identificación (*):";
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservacion.Location = new System.Drawing.Point(981, 328);
            this.TxtObservacion.MaxLength = 100;
            this.TxtObservacion.Multiline = true;
            this.TxtObservacion.Name = "TxtObservacion";
            this.TxtObservacion.ReadOnly = true;
            this.TxtObservacion.Size = new System.Drawing.Size(337, 83);
            this.TxtObservacion.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(853, 363);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 18);
            this.label15.TabIndex = 39;
            this.label15.Text = "Observacion:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(981, 162);
            this.TxtDireccion.MaxLength = 100;
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ReadOnly = true;
            this.TxtDireccion.Size = new System.Drawing.Size(337, 86);
            this.TxtDireccion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(864, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Direccion (*):";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(981, 62);
            this.TxtTelefono.MaxLength = 100;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.ReadOnly = true;
            this.TxtTelefono.Size = new System.Drawing.Size(337, 24);
            this.TxtTelefono.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(869, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 18);
            this.label14.TabIndex = 35;
            this.label14.Text = "Telefono (*):";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(280, 360);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(358, 24);
            this.TxtEmail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Correo (*):";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(501, 287);
            this.TxtApellidos.MaxLength = 100;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.ReadOnly = true;
            this.TxtApellidos.Size = new System.Drawing.Size(222, 24);
            this.TxtApellidos.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(591, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Apellidos (*):";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(274, 287);
            this.TxtNombre.MaxLength = 100;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(191, 24);
            this.TxtNombre.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(341, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 18);
            this.label12.TabIndex = 29;
            this.label12.Text = "Nombre (*):";
            // 
            // BtnRetornar
            // 
            this.BtnRetornar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRetornar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetornar.ForeColor = System.Drawing.Color.White;
            this.BtnRetornar.Location = new System.Drawing.Point(413, 428);
            this.BtnRetornar.Name = "BtnRetornar";
            this.BtnRetornar.Size = new System.Drawing.Size(139, 45);
            this.BtnRetornar.TabIndex = 15;
            this.BtnRetornar.Text = "RETORNAR";
            this.BtnRetornar.UseVisualStyleBackColor = false;
            this.BtnRetornar.Click += new System.EventHandler(this.BtnRetornar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(248, 428);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(136, 45);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Brown;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(64, 428);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(152, 45);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(354, 133);
            this.TxtCedula.MaxLength = 100;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(369, 24);
            this.TxtCedula.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 0;
            // 
            // Pnl_Titulo
            // 
            this.Pnl_Titulo.BackColor = System.Drawing.Color.Maroon;
            this.Pnl_Titulo.Controls.Add(this.label7);
            this.Pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Titulo.Name = "Pnl_Titulo";
            this.Pnl_Titulo.Size = new System.Drawing.Size(1919, 54);
            this.Pnl_Titulo.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "GESTIÓN DE CLIENTES";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1919, 751);
            this.Controls.Add(this.Pnl_Titulo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.TbpPrincipal);
            this.Name = "FrmClientes";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.TbpPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.PnlIdentificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvIdentificacion)).EndInit();
            this.Pnl_Titulo.ResumeLayout(false);
            this.Pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TabControl TbpPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DgvPrincipal;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtObservacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnRetornar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BtnBuscarIdentificacion;
        private System.Windows.Forms.TextBox TxtTipoIdentificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PnlIdentificacion;
        private System.Windows.Forms.DataGridView DgvIdentificacion;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Pnl_Titulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}