namespace PracticaProfesionalEstebanJimenez
{
    partial class MDI_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Principal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pnl_Barra = new System.Windows.Forms.Panel();
            this.Lbl_Hora = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ChkAdmin = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblCargo = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.compraDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosPorProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosTotalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasTotalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnGestiones = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSistemas = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MiBarra = new System.Windows.Forms.ToolStrip();
            this.Tbar_Producto = new System.Windows.Forms.ToolStripButton();
            this.Tbar_Cliente = new System.Windows.Forms.ToolStripButton();
            this.Tbar_Proveedores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tbar_Compras = new System.Windows.Forms.ToolStripButton();
            this.Tbar_Ventas = new System.Windows.Forms.ToolStripButton();
            this.Pnl_Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.MiBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pnl_Barra
            // 
            this.Pnl_Barra.BackColor = System.Drawing.Color.LightGray;
            this.Pnl_Barra.Controls.Add(this.Lbl_Hora);
            this.Pnl_Barra.Controls.Add(this.Lbl_Fecha);
            this.Pnl_Barra.Controls.Add(this.label1);
            this.Pnl_Barra.Controls.Add(this.pictureBox2);
            this.Pnl_Barra.Controls.Add(this.ChkAdmin);
            this.Pnl_Barra.Controls.Add(this.pictureBox1);
            this.Pnl_Barra.Controls.Add(this.LblCargo);
            this.Pnl_Barra.Controls.Add(this.Lbl_Nombre);
            this.Pnl_Barra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Barra.Location = new System.Drawing.Point(0, 531);
            this.Pnl_Barra.Name = "Pnl_Barra";
            this.Pnl_Barra.Size = new System.Drawing.Size(1396, 110);
            this.Pnl_Barra.TabIndex = 9;
            this.Pnl_Barra.UseWaitCursor = true;
            // 
            // Lbl_Hora
            // 
            this.Lbl_Hora.AutoSize = true;
            this.Lbl_Hora.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hora.Location = new System.Drawing.Point(1266, 60);
            this.Lbl_Hora.Name = "Lbl_Hora";
            this.Lbl_Hora.Size = new System.Drawing.Size(64, 30);
            this.Lbl_Hora.TabIndex = 7;
            this.Lbl_Hora.Text = "Hora";
            this.Lbl_Hora.UseWaitCursor = true;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(1238, 34);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Fecha.TabIndex = 6;
            this.Lbl_Fecha.Text = "Fecha";
            this.Lbl_Fecha.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sesión Iniciada";
            this.label1.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(110, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // ChkAdmin
            // 
            this.ChkAdmin.AutoSize = true;
            this.ChkAdmin.Location = new System.Drawing.Point(455, 51);
            this.ChkAdmin.Name = "ChkAdmin";
            this.ChkAdmin.Size = new System.Drawing.Size(95, 21);
            this.ChkAdmin.TabIndex = 1;
            this.ChkAdmin.Text = "checkBox1";
            this.ChkAdmin.UseVisualStyleBackColor = true;
            this.ChkAdmin.UseWaitCursor = true;
            this.ChkAdmin.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Location = new System.Drawing.Point(152, 82);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(47, 17);
            this.LblCargo.TabIndex = 1;
            this.LblCargo.Text = "Cargo:";
            this.LblCargo.UseWaitCursor = true;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(151, 40);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(59, 17);
            this.Lbl_Nombre.TabIndex = 0;
            this.Lbl_Nombre.Text = "Usuario:";
            this.Lbl_Nombre.UseWaitCursor = true;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.Maroon;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(28, 352);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(202, 541);
            this.miniToolStrip.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnProcesos,
            this.BtnReportes,
            this.BtnGestiones,
            this.BtnSistemas,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1396, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnProcesos
            // 
            this.BtnProcesos.AutoSize = false;
            this.BtnProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraDeProductosToolStripMenuItem,
            this.ventaDeProductosToolStripMenuItem});
            this.BtnProcesos.ForeColor = System.Drawing.Color.Black;
            this.BtnProcesos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProcesos.Image")));
            this.BtnProcesos.Name = "BtnProcesos";
            this.BtnProcesos.Size = new System.Drawing.Size(152, 30);
            this.BtnProcesos.Text = "PROCESOS";
            this.BtnProcesos.Click += new System.EventHandler(this.BtnProcesos_Click);
            // 
            // compraDeProductosToolStripMenuItem
            // 
            this.compraDeProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("compraDeProductosToolStripMenuItem.Image")));
            this.compraDeProductosToolStripMenuItem.Name = "compraDeProductosToolStripMenuItem";
            this.compraDeProductosToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.compraDeProductosToolStripMenuItem.Text = "Compra de Productos";
            this.compraDeProductosToolStripMenuItem.Click += new System.EventHandler(this.compraDeProductosToolStripMenuItem_Click);
            // 
            // ventaDeProductosToolStripMenuItem
            // 
            this.ventaDeProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventaDeProductosToolStripMenuItem.Image")));
            this.ventaDeProductosToolStripMenuItem.Name = "ventaDeProductosToolStripMenuItem";
            this.ventaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.ventaDeProductosToolStripMenuItem.Text = "Venta de Productos";
            this.ventaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.ventaDeProductosToolStripMenuItem_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.AutoSize = false;
            this.BtnReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.salidasToolStripMenuItem});
            this.BtnReportes.ForeColor = System.Drawing.Color.Black;
            this.BtnReportes.Image = ((System.Drawing.Image)(resources.GetObject("BtnReportes.Image")));
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(111, 30);
            this.BtnReportes.Text = "REPORTES";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosPorProductosToolStripMenuItem,
            this.ingresosTotalesToolStripMenuItem});
            this.ingresosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ingresosToolStripMenuItem.Image")));
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ingresosToolStripMenuItem.Text = "Compras";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // ingresosPorProductosToolStripMenuItem
            // 
            this.ingresosPorProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ingresosPorProductosToolStripMenuItem.Image")));
            this.ingresosPorProductosToolStripMenuItem.Name = "ingresosPorProductosToolStripMenuItem";
            this.ingresosPorProductosToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.ingresosPorProductosToolStripMenuItem.Text = "Ingresos por Productos";
            this.ingresosPorProductosToolStripMenuItem.Click += new System.EventHandler(this.ingresosPorProductosToolStripMenuItem_Click);
            // 
            // ingresosTotalesToolStripMenuItem
            // 
            this.ingresosTotalesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ingresosTotalesToolStripMenuItem.Image")));
            this.ingresosTotalesToolStripMenuItem.Name = "ingresosTotalesToolStripMenuItem";
            this.ingresosTotalesToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.ingresosTotalesToolStripMenuItem.Text = "Ingresos Totales";
            this.ingresosTotalesToolStripMenuItem.Click += new System.EventHandler(this.ingresosTotalesToolStripMenuItem_Click);
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorProductosToolStripMenuItem,
            this.ventasTotalesToolStripMenuItem});
            this.salidasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salidasToolStripMenuItem.Image")));
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salidasToolStripMenuItem.Text = "Ventas";
            // 
            // ventasPorProductosToolStripMenuItem
            // 
            this.ventasPorProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasPorProductosToolStripMenuItem.Image")));
            this.ventasPorProductosToolStripMenuItem.Name = "ventasPorProductosToolStripMenuItem";
            this.ventasPorProductosToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.ventasPorProductosToolStripMenuItem.Text = "Ventas por Productos";
            this.ventasPorProductosToolStripMenuItem.Click += new System.EventHandler(this.ventasPorProductosToolStripMenuItem_Click);
            // 
            // ventasTotalesToolStripMenuItem
            // 
            this.ventasTotalesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasTotalesToolStripMenuItem.Image")));
            this.ventasTotalesToolStripMenuItem.Name = "ventasTotalesToolStripMenuItem";
            this.ventasTotalesToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.ventasTotalesToolStripMenuItem.Text = "Ventas Totales";
            this.ventasTotalesToolStripMenuItem.Click += new System.EventHandler(this.ventasTotalesToolStripMenuItem_Click);
            // 
            // BtnGestiones
            // 
            this.BtnGestiones.AutoSize = false;
            this.BtnGestiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacenesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.BtnGestiones.ForeColor = System.Drawing.Color.Black;
            this.BtnGestiones.Image = ((System.Drawing.Image)(resources.GetObject("BtnGestiones.Image")));
            this.BtnGestiones.Name = "BtnGestiones";
            this.BtnGestiones.Size = new System.Drawing.Size(111, 30);
            this.BtnGestiones.Text = "GESTIONES";
            // 
            // almacenesToolStripMenuItem
            // 
            this.almacenesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("almacenesToolStripMenuItem.Image")));
            this.almacenesToolStripMenuItem.Name = "almacenesToolStripMenuItem";
            this.almacenesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.almacenesToolStripMenuItem.Text = "Almacenes";
            this.almacenesToolStripMenuItem.Click += new System.EventHandler(this.almacenesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresToolStripMenuItem.Image")));
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem1,
            this.unidadMedidaToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.marcasToolStripMenuItem});
            this.productosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productosToolStripMenuItem.Image")));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("productosToolStripMenuItem1.Image")));
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(195, 26);
            this.productosToolStripMenuItem1.Text = "Productos";
            this.productosToolStripMenuItem1.Click += new System.EventHandler(this.productosToolStripMenuItem1_Click);
            // 
            // unidadMedidaToolStripMenuItem
            // 
            this.unidadMedidaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unidadMedidaToolStripMenuItem.Image")));
            this.unidadMedidaToolStripMenuItem.Name = "unidadMedidaToolStripMenuItem";
            this.unidadMedidaToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.unidadMedidaToolStripMenuItem.Text = "Unidad Medida";
            this.unidadMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadMedidaToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriasToolStripMenuItem.Image")));
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click_1);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("marcasToolStripMenuItem.Image")));
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click_1);
            // 
            // BtnSistemas
            // 
            this.BtnSistemas.AutoSize = false;
            this.BtnSistemas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.BtnSistemas.ForeColor = System.Drawing.Color.Black;
            this.BtnSistemas.Image = ((System.Drawing.Image)(resources.GetObject("BtnSistemas.Image")));
            this.BtnSistemas.Name = "BtnSistemas";
            this.BtnSistemas.Size = new System.Drawing.Size(111, 30);
            this.BtnSistemas.Text = "SISTEMA";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.sALIRToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sALIRToolStripMenuItem.Image")));
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesiónToolStripMenuItem.Image")));
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // MiBarra
            // 
            this.MiBarra.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MiBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tbar_Producto,
            this.Tbar_Cliente,
            this.Tbar_Proveedores,
            this.toolStripSeparator1,
            this.Tbar_Compras,
            this.Tbar_Ventas});
            this.MiBarra.Location = new System.Drawing.Point(0, 30);
            this.MiBarra.Name = "MiBarra";
            this.MiBarra.Size = new System.Drawing.Size(1396, 47);
            this.MiBarra.TabIndex = 13;
            this.MiBarra.Text = "toolStrip1";
            // 
            // Tbar_Producto
            // 
            this.Tbar_Producto.AutoSize = false;
            this.Tbar_Producto.Image = ((System.Drawing.Image)(resources.GetObject("Tbar_Producto.Image")));
            this.Tbar_Producto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbar_Producto.Name = "Tbar_Producto";
            this.Tbar_Producto.Size = new System.Drawing.Size(100, 44);
            this.Tbar_Producto.Text = "Productos";
            this.Tbar_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tbar_Producto.Click += new System.EventHandler(this.Tbar_Producto_Click);
            // 
            // Tbar_Cliente
            // 
            this.Tbar_Cliente.AutoSize = false;
            this.Tbar_Cliente.Image = ((System.Drawing.Image)(resources.GetObject("Tbar_Cliente.Image")));
            this.Tbar_Cliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbar_Cliente.Name = "Tbar_Cliente";
            this.Tbar_Cliente.Size = new System.Drawing.Size(100, 44);
            this.Tbar_Cliente.Text = "Clientes";
            this.Tbar_Cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tbar_Cliente.Click += new System.EventHandler(this.Tbar_Cliente_Click);
            // 
            // Tbar_Proveedores
            // 
            this.Tbar_Proveedores.AutoSize = false;
            this.Tbar_Proveedores.Image = ((System.Drawing.Image)(resources.GetObject("Tbar_Proveedores.Image")));
            this.Tbar_Proveedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbar_Proveedores.Name = "Tbar_Proveedores";
            this.Tbar_Proveedores.Size = new System.Drawing.Size(100, 44);
            this.Tbar_Proveedores.Text = "Proveedores";
            this.Tbar_Proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tbar_Proveedores.Click += new System.EventHandler(this.Tbar_Proveedores_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // Tbar_Compras
            // 
            this.Tbar_Compras.AutoSize = false;
            this.Tbar_Compras.Image = ((System.Drawing.Image)(resources.GetObject("Tbar_Compras.Image")));
            this.Tbar_Compras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbar_Compras.Name = "Tbar_Compras";
            this.Tbar_Compras.Size = new System.Drawing.Size(100, 44);
            this.Tbar_Compras.Text = "Compras";
            this.Tbar_Compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tbar_Compras.Click += new System.EventHandler(this.Tbar_Compras_Click);
            // 
            // Tbar_Ventas
            // 
            this.Tbar_Ventas.AutoSize = false;
            this.Tbar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Tbar_Ventas.Image")));
            this.Tbar_Ventas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbar_Ventas.Name = "Tbar_Ventas";
            this.Tbar_Ventas.Size = new System.Drawing.Size(100, 44);
            this.Tbar_Ventas.Text = "Ventas";
            this.Tbar_Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tbar_Ventas.Click += new System.EventHandler(this.Tbar_Ventas_Click);
            // 
            // MDI_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1396, 641);
            this.Controls.Add(this.MiBarra);
            this.Controls.Add(this.Pnl_Barra);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.miniToolStrip;
            this.Name = "MDI_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de Inventario 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Pnl_Barra.ResumeLayout(false);
            this.Pnl_Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MiBarra.ResumeLayout(false);
            this.MiBarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Pnl_Barra;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem compraDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStrip MiBarra;
        private System.Windows.Forms.ToolStripButton Tbar_Producto;
        private System.Windows.Forms.ToolStripButton Tbar_Cliente;
        private System.Windows.Forms.ToolStripButton Tbar_Proveedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Tbar_Compras;
        private System.Windows.Forms.ToolStripButton Tbar_Ventas;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosPorProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosTotalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasTotalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unidadMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ToolStripMenuItem BtnProcesos;
        public System.Windows.Forms.ToolStripMenuItem BtnReportes;
        public System.Windows.Forms.ToolStripMenuItem BtnGestiones;
        public System.Windows.Forms.ToolStripMenuItem BtnSistemas;
        public System.Windows.Forms.Label LblCargo;
        public System.Windows.Forms.Label Lbl_Nombre;
        public System.Windows.Forms.CheckBox ChkAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Hora;
        private System.Windows.Forms.Label Lbl_Fecha;
    }
}