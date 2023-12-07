using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaProfesionalEstebanJimenez
{
    public partial class MDI_Principal : Form
    {
        //En esta clase se procede a llamar cada uno de los formularios realizados
        //para que se ejecuten dentro del menu principal(MDI)
        public MDI_Principal()
        {
            InitializeComponent();
        }

        private void compraDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EntradaProductos oFrm_ep = new Frm_EntradaProductos();
            oFrm_ep.MdiParent = this;
            oFrm_ep.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ep.Show();
        }

        private void ventaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Salida oFrm_sp = new Frm_Salida();
            oFrm_sp.MdiParent = this;
            oFrm_sp.StartPosition = FormStartPosition.CenterScreen;
            oFrm_sp.Show();
        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_Ingreso_ComprasxProductos oFrm_rep1 = new Reportes_Consolidados.Frm_Reporte_Ingreso_ComprasxProductos();
            oFrm_rep1.MdiParent = this;
            oFrm_rep1.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep1.Show();
        }

        private void reporte2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_VentasxProductos oFrm_rep2 = new Reportes_Consolidados.Frm_Reporte_VentasxProductos();
            oFrm_rep2.MdiParent = this;
            oFrm_rep2.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep2.Show();
        }

        private void reporte3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_IngresoAcumuladoxProducto oFrm_rep2 = new Reportes_Consolidados.Frm_Reporte_IngresoAcumuladoxProducto();
            oFrm_rep2.MdiParent = this;
            oFrm_rep2.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep2.Show();
        }

        private void reporte4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_Salida_AcumuladoxProductos oFrm_rep3 = new Reportes_Consolidados.Frm_Reporte_Salida_AcumuladoxProductos();
            oFrm_rep3.MdiParent = this;
            oFrm_rep3.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep3.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Productos oFrm_pr = new Frm_Productos();
            oFrm_pr.MdiParent = this;
            oFrm_pr.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pr.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarcas oFrm_ma = new FrmMarcas();
            oFrm_ma.MdiParent = this;
            oFrm_ma.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ma.Show();
        }

        private void unidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnidadesMedida oFrm_um = new FrmUnidadesMedida();
            oFrm_um.MdiParent = this;
            oFrm_um.StartPosition = FormStartPosition.CenterScreen;
            oFrm_um.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias oFrm_ca = new FrmCategorias();
            oFrm_ca.MdiParent = this;
            oFrm_ca.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ca.Show();
        }

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlmacenes oFrm_al = new FrmAlmacenes();
            oFrm_al.MdiParent = this;
            oFrm_al.StartPosition = FormStartPosition.CenterScreen;
            oFrm_al.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores oFrm_pv = new FrmProveedores();
            oFrm_pv.MdiParent = this;
            oFrm_pv.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pv.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes oFrm_cl = new FrmClientes();
            oFrm_cl.MdiParent = this;
            oFrm_cl.StartPosition = FormStartPosition.CenterScreen;
            oFrm_cl.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios oFrm_us = new Usuarios();
            oFrm_us.MdiParent = this;
            oFrm_us.StartPosition = FormStartPosition.CenterScreen;
            oFrm_us.Show();
        }

        private void cERRARSESIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnProcesos_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tbar_Producto_Click(object sender, EventArgs e)
        {
            Frm_Productos oFrm_pr = new Frm_Productos();
            oFrm_pr.MdiParent = this;
            oFrm_pr.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pr.Show();
        }

        private void Tbar_Cliente_Click(object sender, EventArgs e)
        {
            FrmClientes oFrm_cl = new FrmClientes();
            oFrm_cl.MdiParent = this;
            oFrm_cl.StartPosition = FormStartPosition.CenterScreen;
            oFrm_cl.Show();
        }

        private void Tbar_Proveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores oFrm_pv = new FrmProveedores();
            oFrm_pv.MdiParent = this;
            oFrm_pv.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pv.Show();
        }

        private void Tbar_Compras_Click(object sender, EventArgs e)
        {
            Frm_EntradaProductos oFrm_ep = new Frm_EntradaProductos();
            oFrm_ep.MdiParent = this;
            oFrm_ep.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ep.Show();
        }

        private void Tbar_Ventas_Click(object sender, EventArgs e)
        {
            Frm_Salida oFrm_sp = new Frm_Salida();
            oFrm_sp.MdiParent = this;
            oFrm_sp.StartPosition = FormStartPosition.CenterScreen;
            oFrm_sp.Show();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresosPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_Ingreso_ComprasxProductos oFrm_rep1 = new Reportes_Consolidados.Frm_Reporte_Ingreso_ComprasxProductos();
            oFrm_rep1.MdiParent = this;
            oFrm_rep1.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep1.Show();
        }

        private void ingresosTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_IngresoAcumuladoxProducto oFrm_rep2 = new Reportes_Consolidados.Frm_Reporte_IngresoAcumuladoxProducto();
            oFrm_rep2.MdiParent = this;
            oFrm_rep2.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep2.Show();
        }

        private void ventasPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_VentasxProductos oFrm_rep2 = new Reportes_Consolidados.Frm_Reporte_VentasxProductos();
            oFrm_rep2.MdiParent = this;
            oFrm_rep2.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep2.Show();
        }

        private void ventasTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_Salida_AcumuladoxProductos oFrm_rep3 = new Reportes_Consolidados.Frm_Reporte_Salida_AcumuladoxProductos();
            oFrm_rep3.MdiParent = this;
            oFrm_rep3.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep3.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Productos oFrm_pr = new Frm_Productos();
            oFrm_pr.MdiParent = this;
            oFrm_pr.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pr.Show();
        }

        private void unidadMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnidadesMedida oFrm_um = new FrmUnidadesMedida();
            oFrm_um.MdiParent = this;
            oFrm_um.StartPosition = FormStartPosition.CenterScreen;
            oFrm_um.Show();
        }

        private void categoriasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCategorias oFrm_ca = new FrmCategorias();
            oFrm_ca.MdiParent = this;
            oFrm_ca.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ca.Show();
        }

        private void marcasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmMarcas oFrm_ma = new FrmMarcas();
            oFrm_ma.MdiParent = this;
            oFrm_ma.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ma.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Fecha.Text = DateTime.Now.ToLongDateString();
            Lbl_Hora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
