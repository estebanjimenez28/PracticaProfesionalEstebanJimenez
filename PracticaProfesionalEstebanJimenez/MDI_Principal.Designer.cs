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
            this.MiMenu = new System.Windows.Forms.MenuStrip();
            this.BtnGestiones = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasDeProductosComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaDeProductosVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeComprasPorProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoAcumuladoPorProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasDeVentasPorProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaAcumuladoPorProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSistemas = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MiBarra = new System.Windows.Forms.ToolStrip();
            this.Tbar_Producto = new System.Windows.Forms.ToolStripButton();
            this.Tbar_Clientes = new System.Windows.Forms.ToolStripButton();
            this.Tbar_Proveedores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tbar_Entrada = new System.Windows.Forms.ToolStripButton();
            this.Tbar_Salida = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Pnl_barra = new System.Windows.Forms.Panel();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkAdmin = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblnombreusuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MiMenu.SuspendLayout();
            this.MiBarra.SuspendLayout();
            this.Pnl_barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MiMenu
            // 
            this.MiMenu.BackColor = System.Drawing.Color.White;
            this.MiMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGestiones,
            this.BtnProcesos,
            this.BtnReportes,
            this.BtnSistemas,
            this.salirToolStripMenuItem});
            this.MiMenu.Location = new System.Drawing.Point(0, 0);
            this.MiMenu.Name = "MiMenu";
            this.MiMenu.Size = new System.Drawing.Size(1396, 30);
            this.MiMenu.TabIndex = 1;
            this.MiMenu.Text = "menuStrip1";
            // 
            // BtnGestiones
            // 
            this.BtnGestiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.BtnGestiones.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestiones.Name = "BtnGestiones";
            this.BtnGestiones.Size = new System.Drawing.Size(107, 26);
            this.BtnGestiones.Text = "Gestiones";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem1,
            this.marcasToolStripMenuItem,
            this.unidadesDeMedidaToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.productosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productosToolStripMenuItem.Image")));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("productosToolStripMenuItem1.Image")));
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(265, 26);
            this.productosToolStripMenuItem1.Text = "Productos";
            this.productosToolStripMenuItem1.Click += new System.EventHandler(this.productosToolStripMenuItem1_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("marcasToolStripMenuItem.Image")));
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // unidadesDeMedidaToolStripMenuItem
            // 
            this.unidadesDeMedidaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unidadesDeMedidaToolStripMenuItem.Image")));
            this.unidadesDeMedidaToolStripMenuItem.Name = "unidadesDeMedidaToolStripMenuItem";
            this.unidadesDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.unidadesDeMedidaToolStripMenuItem.Text = "Unidades de Medida";
            this.unidadesDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadesDeMedidaToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriasToolStripMenuItem.Image")));
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "Almacenes";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresToolStripMenuItem.Image")));
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // BtnProcesos
            // 
            this.BtnProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasDeProductosComprasToolStripMenuItem,
            this.salidaDeProductosVentasToolStripMenuItem});
            this.BtnProcesos.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcesos.Name = "BtnProcesos";
            this.BtnProcesos.Size = new System.Drawing.Size(97, 26);
            this.BtnProcesos.Text = "Procesos";
            // 
            // entradasDeProductosComprasToolStripMenuItem
            // 
            this.entradasDeProductosComprasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("entradasDeProductosComprasToolStripMenuItem.Image")));
            this.entradasDeProductosComprasToolStripMenuItem.Name = "entradasDeProductosComprasToolStripMenuItem";
            this.entradasDeProductosComprasToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.entradasDeProductosComprasToolStripMenuItem.Text = "Entradas de Productos(Compras)";
            this.entradasDeProductosComprasToolStripMenuItem.Click += new System.EventHandler(this.entradasDeProductosComprasToolStripMenuItem_Click);
            // 
            // salidaDeProductosVentasToolStripMenuItem
            // 
            this.salidaDeProductosVentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salidaDeProductosVentasToolStripMenuItem.Image")));
            this.salidaDeProductosVentasToolStripMenuItem.Name = "salidaDeProductosVentasToolStripMenuItem";
            this.salidaDeProductosVentasToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.salidaDeProductosVentasToolStripMenuItem.Text = "Salida de Productos(Ventas)";
            this.salidaDeProductosVentasToolStripMenuItem.Click += new System.EventHandler(this.salidaDeProductosVentasToolStripMenuItem_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.salidasToolStripMenuItem});
            this.BtnReportes.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(99, 26);
            this.BtnReportes.Text = "Reportes";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeComprasPorProductosToolStripMenuItem,
            this.ingresoAcumuladoPorProductosToolStripMenuItem});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // ingresoDeComprasPorProductosToolStripMenuItem
            // 
            this.ingresoDeComprasPorProductosToolStripMenuItem.Name = "ingresoDeComprasPorProductosToolStripMenuItem";
            this.ingresoDeComprasPorProductosToolStripMenuItem.Size = new System.Drawing.Size(391, 26);
            this.ingresoDeComprasPorProductosToolStripMenuItem.Text = "Ingreso de Compras por Productos";
            this.ingresoDeComprasPorProductosToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeComprasPorProductosToolStripMenuItem_Click);
            // 
            // ingresoAcumuladoPorProductosToolStripMenuItem
            // 
            this.ingresoAcumuladoPorProductosToolStripMenuItem.Name = "ingresoAcumuladoPorProductosToolStripMenuItem";
            this.ingresoAcumuladoPorProductosToolStripMenuItem.Size = new System.Drawing.Size(391, 26);
            this.ingresoAcumuladoPorProductosToolStripMenuItem.Text = "Ingreso Acumulado por Productos";
            this.ingresoAcumuladoPorProductosToolStripMenuItem.Click += new System.EventHandler(this.ingresoAcumuladoPorProductosToolStripMenuItem_Click);
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salidasDeVentasPorProductosToolStripMenuItem,
            this.salidaAcumuladoPorProductosToolStripMenuItem});
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.salidasToolStripMenuItem.Text = "Salidas";
            // 
            // salidasDeVentasPorProductosToolStripMenuItem
            // 
            this.salidasDeVentasPorProductosToolStripMenuItem.Name = "salidasDeVentasPorProductosToolStripMenuItem";
            this.salidasDeVentasPorProductosToolStripMenuItem.Size = new System.Drawing.Size(371, 26);
            this.salidasDeVentasPorProductosToolStripMenuItem.Text = "Salidas de Ventas por Productos";
            this.salidasDeVentasPorProductosToolStripMenuItem.Click += new System.EventHandler(this.salidasDeVentasPorProductosToolStripMenuItem_Click);
            // 
            // salidaAcumuladoPorProductosToolStripMenuItem
            // 
            this.salidaAcumuladoPorProductosToolStripMenuItem.Name = "salidaAcumuladoPorProductosToolStripMenuItem";
            this.salidaAcumuladoPorProductosToolStripMenuItem.Size = new System.Drawing.Size(371, 26);
            this.salidaAcumuladoPorProductosToolStripMenuItem.Text = "Salida Acumulado por Productos";
            this.salidaAcumuladoPorProductosToolStripMenuItem.Click += new System.EventHandler(this.salidaAcumuladoPorProductosToolStripMenuItem_Click);
            // 
            // BtnSistemas
            // 
            this.BtnSistemas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.BtnSistemas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSistemas.Name = "BtnSistemas";
            this.BtnSistemas.Size = new System.Drawing.Size(102, 26);
            this.BtnSistemas.Text = "Sistemas";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelSistemaToolStripMenuItem});
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirDelSistemaToolStripMenuItem.Image")));
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // MiBarra
            // 
            this.MiBarra.AutoSize = false;
            this.MiBarra.BackColor = System.Drawing.Color.White;
            this.MiBarra.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiBarra.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MiBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tbar_Producto,
            this.Tbar_Clientes,
            this.Tbar_Proveedores,
            this.toolStripSeparator1,
            this.Tbar_Entrada,
            this.Tbar_Salida,
            this.toolStripSeparator2});
            this.MiBarra.Location = new System.Drawing.Point(0, 30);
            this.MiBarra.Name = "MiBarra";
            this.MiBarra.Size = new System.Drawing.Size(1396, 60);
            this.MiBarra.TabIndex = 3;
            this.MiBarra.Text = "toolStrip1";
            // 
            // Tbar_Producto
            // 
            this.Tbar_Producto.AutoSize = false;
            this.Tbar_Producto.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbar_Producto.Image = ((System.Drawing.Image)(resources.GetObject("Tbar_Producto.Image")));
            this.Tbar_Producto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbar_Producto.Name = "Tbar_Producto";
            this.Tbar_Producto.Size = new System.Drawing.Size(97, 77);
            this.Tbar_Producto.Text = "Productos";
            this.Tbar_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tbar_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tbar_Producto.Click += new System.EventHandler(this.Tbar_Producto_Click);
            // 
            // Tbar_Clientes
            // 
            this.Tbar_Clientes.AutoSize = false;
            this.Tbar_Clientes.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbar_Clientes.Image = ((System.Drawing.Image)(resources.GetObject("Tbar_Clientes.Image")));
            this.Tbar_Clientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbar_Clientes.Name = "Tbar_Clientes";
            this.Tbar_Clientes.Size = new System.Drawing.Size(100, 77);
            this.Tbar_Clientes.Text = "Clientes";
            this.Tbar_Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tbar_Clientes.Click += new System.EventHandler(this.Tbar_Clientes_Click);
            // 
            // Tbar_Proveedores
            // 
            this.Tbar_Proveedores.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbar_Proveedores.Image = ((System.Drawing.Image)(resources.GetObject("Tbar_Proveedores.Image")));
            this.Tbar_Proveedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbar_Proveedores.Name = "Tbar_Proveedores";
            this.Tbar_Proveedores.Size = new System.Drawing.Size(117, 57);
            this.Tbar_Proveedores.Text = "Proveedores";
            this.Tbar_Proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tbar_Proveedores.Click += new System.EventHandler(this.Tbar_Proveedores_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // Tbar_Entrada
            // 
            this.Tbar_Entrada.AutoSize = false;
            this.Tbar_Entrada.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbar_Entrada.Image = ((System.Drawing.Image)(resources.GetObject("Tbar_Entrada.Image")));
            this.Tbar_Entrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbar_Entrada.Name = "Tbar_Entrada";
            this.Tbar_Entrada.Size = new System.Drawing.Size(100, 77);
            this.Tbar_Entrada.Text = "Compras";
            this.Tbar_Entrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tbar_Entrada.Click += new System.EventHandler(this.Tbar_Entrada_Click);
            // 
            // Tbar_Salida
            // 
            this.Tbar_Salida.AutoSize = false;
            this.Tbar_Salida.Image = ((System.Drawing.Image)(resources.GetObject("Tbar_Salida.Image")));
            this.Tbar_Salida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tbar_Salida.Name = "Tbar_Salida";
            this.Tbar_Salida.Size = new System.Drawing.Size(100, 77);
            this.Tbar_Salida.Text = "Ventas";
            this.Tbar_Salida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tbar_Salida.Click += new System.EventHandler(this.Tbar_Salida_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            // 
            // Pnl_barra
            // 
            this.Pnl_barra.BackColor = System.Drawing.Color.White;
            this.Pnl_barra.Controls.Add(this.lbl_hora);
            this.Pnl_barra.Controls.Add(this.lbl_fecha);
            this.Pnl_barra.Controls.Add(this.label4);
            this.Pnl_barra.Controls.Add(this.ChkAdmin);
            this.Pnl_barra.Controls.Add(this.pictureBox3);
            this.Pnl_barra.Controls.Add(this.pictureBox2);
            this.Pnl_barra.Controls.Add(this.lblcargo);
            this.Pnl_barra.Controls.Add(this.lblnombreusuario);
            this.Pnl_barra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_barra.Location = new System.Drawing.Point(0, 482);
            this.Pnl_barra.Name = "Pnl_barra";
            this.Pnl_barra.Size = new System.Drawing.Size(1396, 121);
            this.Pnl_barra.TabIndex = 5;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.Black;
            this.lbl_hora.Location = new System.Drawing.Point(1005, 67);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(119, 45);
            this.lbl_hora.TabIndex = 23;
            this.lbl_hora.Text = "Hora";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.Black;
            this.lbl_fecha.Location = new System.Drawing.Point(991, 14);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(77, 22);
            this.lbl_fecha.TabIndex = 22;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(380, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sesión Iniciada";
            // 
            // ChkAdmin
            // 
            this.ChkAdmin.AutoSize = true;
            this.ChkAdmin.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkAdmin.ForeColor = System.Drawing.Color.Black;
            this.ChkAdmin.Location = new System.Drawing.Point(731, 85);
            this.ChkAdmin.Name = "ChkAdmin";
            this.ChkAdmin.Size = new System.Drawing.Size(121, 20);
            this.ChkAdmin.TabIndex = 20;
            this.ChkAdmin.Text = "Administrador";
            this.ChkAdmin.UseVisualStyleBackColor = true;
            this.ChkAdmin.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(265, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(265, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargo.ForeColor = System.Drawing.Color.Black;
            this.lblcargo.Location = new System.Drawing.Point(313, 90);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(52, 16);
            this.lblcargo.TabIndex = 17;
            this.lblcargo.Text = "Cargo:";
            // 
            // lblnombreusuario
            // 
            this.lblnombreusuario.AutoSize = true;
            this.lblnombreusuario.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreusuario.ForeColor = System.Drawing.Color.Black;
            this.lblnombreusuario.Location = new System.Drawing.Point(313, 49);
            this.lblnombreusuario.Name = "lblnombreusuario";
            this.lblnombreusuario.Size = new System.Drawing.Size(65, 16);
            this.lblnombreusuario.TabIndex = 16;
            this.lblnombreusuario.Text = "Nombre:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MDI_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1396, 603);
            this.Controls.Add(this.Pnl_barra);
            this.Controls.Add(this.MiBarra);
            this.Controls.Add(this.MiMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MiMenu;
            this.Name = "MDI_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SISTEMA DE INVENTARIO 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Principal_Load);
            this.MiMenu.ResumeLayout(false);
            this.MiMenu.PerformLayout();
            this.MiBarra.ResumeLayout(false);
            this.MiBarra.PerformLayout();
            this.Pnl_barra.ResumeLayout(false);
            this.Pnl_barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MiMenu;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadesDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasDeProductosComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaDeProductosVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip MiBarra;
        private System.Windows.Forms.ToolStripButton Tbar_Producto;
        private System.Windows.Forms.ToolStripButton Tbar_Clientes;
        private System.Windows.Forms.ToolStripButton Tbar_Proveedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Tbar_Entrada;
        private System.Windows.Forms.ToolStripButton Tbar_Salida;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeComprasPorProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasDeVentasPorProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoAcumuladoPorProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaAcumuladoPorProductosToolStripMenuItem;
        private System.Windows.Forms.Panel Pnl_barra;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox ChkAdmin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblcargo;
        public System.Windows.Forms.Label lblnombreusuario;
        public System.Windows.Forms.ToolStripMenuItem BtnGestiones;
        public System.Windows.Forms.ToolStripMenuItem BtnProcesos;
        public System.Windows.Forms.ToolStripMenuItem BtnReportes;
        public System.Windows.Forms.ToolStripMenuItem BtnSistemas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
    }
}