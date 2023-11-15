namespace PracticaProfesionalEstebanJimenez
{
    partial class FrmProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TbpPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DgvPrincipal = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PnlProductos = new System.Windows.Forms.Panel();
            this.BtnBuscar3 = new System.Windows.Forms.Button();
            this.BtnRetornar3 = new System.Windows.Forms.Button();
            this.TxtBuscar3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DgvProductoProveedor = new System.Windows.Forms.DataGridView();
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
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_lupa2 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.TxtMedida = new System.Windows.Forms.Label();
            this.BtnRetornar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.Pnl_Titulo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TbpPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.PnlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductoProveedor)).BeginInit();
            this.Pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbpPrincipal
            // 
            this.TbpPrincipal.Controls.Add(this.tabPage1);
            this.TbpPrincipal.Controls.Add(this.tabPage2);
            this.TbpPrincipal.Location = new System.Drawing.Point(44, 74);
            this.TbpPrincipal.Name = "TbpPrincipal";
            this.TbpPrincipal.SelectedIndex = 0;
            this.TbpPrincipal.Size = new System.Drawing.Size(1900, 525);
            this.TbpPrincipal.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DgvPrincipal);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1892, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DgvPrincipal
            // 
            this.DgvPrincipal.AllowUserToAddRows = false;
            this.DgvPrincipal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.DgvPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPrincipal.ColumnHeadersHeight = 35;
            this.DgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPrincipal.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPrincipal.EnableHeadersVisualStyles = false;
            this.DgvPrincipal.Location = new System.Drawing.Point(15, 98);
            this.DgvPrincipal.Name = "DgvPrincipal";
            this.DgvPrincipal.ReadOnly = true;
            this.DgvPrincipal.RowHeadersWidth = 51;
            this.DgvPrincipal.RowTemplate.Height = 24;
            this.DgvPrincipal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvPrincipal.Size = new System.Drawing.Size(1629, 380);
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
            this.BtnBuscar.Location = new System.Drawing.Point(593, 27);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(124, 34);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "CONSULTAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(275, 28);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(289, 30);
            this.TxtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.PnlProductos);
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
            this.tabPage2.Controls.Add(this.TxtRazonSocial);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.Btn_lupa2);
            this.tabPage2.Controls.Add(this.TxtProducto);
            this.tabPage2.Controls.Add(this.TxtMedida);
            this.tabPage2.Controls.Add(this.BtnRetornar);
            this.tabPage2.Controls.Add(this.BtnGuardar);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.TxtCedula);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1892, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // PnlProductos
            // 
            this.PnlProductos.BackColor = System.Drawing.Color.Silver;
            this.PnlProductos.Controls.Add(this.BtnBuscar3);
            this.PnlProductos.Controls.Add(this.BtnRetornar3);
            this.PnlProductos.Controls.Add(this.TxtBuscar3);
            this.PnlProductos.Controls.Add(this.label9);
            this.PnlProductos.Controls.Add(this.DgvProductoProveedor);
            this.PnlProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlProductos.Location = new System.Drawing.Point(136, 6);
            this.PnlProductos.Name = "PnlProductos";
            this.PnlProductos.Size = new System.Drawing.Size(792, 289);
            this.PnlProductos.TabIndex = 26;
            this.PnlProductos.Visible = false;
            // 
            // BtnBuscar3
            // 
            this.BtnBuscar3.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar3.Image")));
            this.BtnBuscar3.Location = new System.Drawing.Point(442, 33);
            this.BtnBuscar3.Name = "BtnBuscar3";
            this.BtnBuscar3.Size = new System.Drawing.Size(62, 48);
            this.BtnBuscar3.TabIndex = 25;
            this.BtnBuscar3.UseVisualStyleBackColor = true;
            this.BtnBuscar3.Click += new System.EventHandler(this.BtnBuscar3_Click);
            // 
            // BtnRetornar3
            // 
            this.BtnRetornar3.Image = ((System.Drawing.Image)(resources.GetObject("BtnRetornar3.Image")));
            this.BtnRetornar3.Location = new System.Drawing.Point(516, 34);
            this.BtnRetornar3.Name = "BtnRetornar3";
            this.BtnRetornar3.Size = new System.Drawing.Size(66, 47);
            this.BtnRetornar3.TabIndex = 24;
            this.BtnRetornar3.UseVisualStyleBackColor = true;
            this.BtnRetornar3.Click += new System.EventHandler(this.BtnRetornar3_Click);
            // 
            // TxtBuscar3
            // 
            this.TxtBuscar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBuscar3.Location = new System.Drawing.Point(241, 39);
            this.TxtBuscar3.Name = "TxtBuscar3";
            this.TxtBuscar3.Size = new System.Drawing.Size(186, 30);
            this.TxtBuscar3.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(142, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Buscar:";
            // 
            // DgvProductoProveedor
            // 
            this.DgvProductoProveedor.AllowUserToAddRows = false;
            this.DgvProductoProveedor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvProductoProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvProductoProveedor.BackgroundColor = System.Drawing.Color.White;
            this.DgvProductoProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProductoProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvProductoProveedor.ColumnHeadersHeight = 35;
            this.DgvProductoProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProductoProveedor.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvProductoProveedor.EnableHeadersVisualStyles = false;
            this.DgvProductoProveedor.Location = new System.Drawing.Point(23, 95);
            this.DgvProductoProveedor.Name = "DgvProductoProveedor";
            this.DgvProductoProveedor.ReadOnly = true;
            this.DgvProductoProveedor.RowHeadersWidth = 51;
            this.DgvProductoProveedor.RowTemplate.Height = 24;
            this.DgvProductoProveedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvProductoProveedor.Size = new System.Drawing.Size(746, 167);
            this.DgvProductoProveedor.TabIndex = 20;
            this.DgvProductoProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductoProveedor_CellContentClick);
            this.DgvProductoProveedor.DoubleClick += new System.EventHandler(this.DgvProductoProveedor_DoubleClick);
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservacion.Location = new System.Drawing.Point(986, 348);
            this.TxtObservacion.MaxLength = 100;
            this.TxtObservacion.Multiline = true;
            this.TxtObservacion.Name = "TxtObservacion";
            this.TxtObservacion.ReadOnly = true;
            this.TxtObservacion.Size = new System.Drawing.Size(382, 62);
            this.TxtObservacion.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(990, 321);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 18);
            this.label15.TabIndex = 39;
            this.label15.Text = "Observación (*):";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(993, 230);
            this.TxtDireccion.MaxLength = 100;
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ReadOnly = true;
            this.TxtDireccion.Size = new System.Drawing.Size(382, 62);
            this.TxtDireccion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(991, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Dirección (*):";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(993, 135);
            this.TxtTelefono.MaxLength = 100;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.ReadOnly = true;
            this.TxtTelefono.Size = new System.Drawing.Size(240, 24);
            this.TxtTelefono.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(990, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 18);
            this.label14.TabIndex = 35;
            this.label14.Text = "Teléfono (*):";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(993, 62);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(382, 24);
            this.TxtEmail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(990, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Correo Electrónico (*):";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(513, 251);
            this.TxtApellidos.MaxLength = 100;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.ReadOnly = true;
            this.TxtApellidos.Size = new System.Drawing.Size(177, 24);
            this.TxtApellidos.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(548, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Apellidos (*):";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(311, 251);
            this.TxtNombre.MaxLength = 100;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(177, 24);
            this.TxtNombre.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(351, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 18);
            this.label12.TabIndex = 29;
            this.label12.Text = "Nombre (*):";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRazonSocial.Location = new System.Drawing.Point(419, 135);
            this.TxtRazonSocial.MaxLength = 100;
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.ReadOnly = true;
            this.TxtRazonSocial.Size = new System.Drawing.Size(289, 24);
            this.TxtRazonSocial.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(257, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "Razón Social (*):";
            // 
            // Btn_lupa2
            // 
            this.Btn_lupa2.ImageKey = "btnbuscar.png";
            this.Btn_lupa2.ImageList = this.imageList2;
            this.Btn_lupa2.Location = new System.Drawing.Point(716, 321);
            this.Btn_lupa2.Name = "Btn_lupa2";
            this.Btn_lupa2.Size = new System.Drawing.Size(64, 46);
            this.Btn_lupa2.TabIndex = 12;
            this.Btn_lupa2.UseVisualStyleBackColor = true;
            this.Btn_lupa2.Click += new System.EventHandler(this.Btn_lupa2_Click_1);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "btnbuscar.png");
            // 
            // TxtProducto
            // 
            this.TxtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProducto.Location = new System.Drawing.Point(410, 329);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.ReadOnly = true;
            this.TxtProducto.Size = new System.Drawing.Size(289, 24);
            this.TxtProducto.TabIndex = 6;
            // 
            // TxtMedida
            // 
            this.TxtMedida.AutoSize = true;
            this.TxtMedida.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMedida.Location = new System.Drawing.Point(259, 332);
            this.TxtMedida.Name = "TxtMedida";
            this.TxtMedida.Size = new System.Drawing.Size(95, 18);
            this.TxtMedida.TabIndex = 7;
            this.TxtMedida.Text = "Producto (*):";
            // 
            // BtnRetornar
            // 
            this.BtnRetornar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRetornar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetornar.ForeColor = System.Drawing.Color.White;
            this.BtnRetornar.Location = new System.Drawing.Point(579, 430);
            this.BtnRetornar.Name = "BtnRetornar";
            this.BtnRetornar.Size = new System.Drawing.Size(120, 45);
            this.BtnRetornar.TabIndex = 15;
            this.BtnRetornar.Text = "RETORNAR";
            this.BtnRetornar.UseVisualStyleBackColor = false;
            this.BtnRetornar.Click += new System.EventHandler(this.BtnRetornar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(419, 430);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(123, 45);
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
            this.BtnCancelar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(262, 430);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(120, 45);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(419, 61);
            this.TxtCedula.MaxLength = 100;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(289, 24);
            this.TxtCedula.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identificación (*):";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Gray;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.ImageKey = "Cierre.png";
            this.BtnSalir.ImageList = this.imageList1;
            this.BtnSalir.Location = new System.Drawing.Point(651, 626);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(129, 113);
            this.BtnSalir.TabIndex = 28;
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
            this.BtnReporte.Location = new System.Drawing.Point(498, 626);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(129, 113);
            this.BtnReporte.TabIndex = 27;
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
            this.BtnActualizar.Location = new System.Drawing.Point(197, 626);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(129, 113);
            this.BtnActualizar.TabIndex = 26;
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
            this.BtnEliminar.Location = new System.Drawing.Point(345, 626);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(129, 113);
            this.BtnEliminar.TabIndex = 25;
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
            this.BtnNuevo.Location = new System.Drawing.Point(48, 626);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(129, 113);
            this.BtnNuevo.TabIndex = 24;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // Pnl_Titulo
            // 
            this.Pnl_Titulo.BackColor = System.Drawing.Color.Maroon;
            this.Pnl_Titulo.Controls.Add(this.label7);
            this.Pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Titulo.Name = "Pnl_Titulo";
            this.Pnl_Titulo.Size = new System.Drawing.Size(1919, 54);
            this.Pnl_Titulo.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "GESTIÓN DE PROVEEDORES";
            // 
            // FrmProveedores
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
            this.Name = "FrmProveedores";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            this.TbpPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrincipal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.PnlProductos.ResumeLayout(false);
            this.PnlProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductoProveedor)).EndInit();
            this.Pnl_Titulo.ResumeLayout(false);
            this.Pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbpPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DgvPrincipal;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel PnlProductos;
        private System.Windows.Forms.Button BtnBuscar3;
        private System.Windows.Forms.Button BtnRetornar3;
        private System.Windows.Forms.TextBox TxtBuscar3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DgvProductoProveedor;
        private System.Windows.Forms.Button Btn_lupa2;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label TxtMedida;
        private System.Windows.Forms.Button BtnRetornar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtObservacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel Pnl_Titulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}