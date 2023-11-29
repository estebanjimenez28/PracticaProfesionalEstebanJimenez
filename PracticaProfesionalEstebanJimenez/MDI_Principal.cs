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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAlmacenes oFrm_al = new FrmAlmacenes();
            oFrm_al.MdiParent = this;
            oFrm_al.StartPosition = FormStartPosition.CenterScreen;
            oFrm_al.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes oFrm_cl = new FrmClientes();
            oFrm_cl.MdiParent = this;
            oFrm_cl.StartPosition = FormStartPosition.CenterScreen;
            oFrm_cl.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmProveedores oFrm_pv = new FrmProveedores();
            oFrm_pv.MdiParent = this;
            oFrm_pv.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pv.Show();
        }

        private void entradasDeProductosComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EntradaProductos oFrm_ep = new Frm_EntradaProductos();
            oFrm_ep.MdiParent = this;
            oFrm_ep.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ep.Show();
        }

        private void salidaDeProductosVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Salida oFrm_sp = new Frm_Salida();
            oFrm_sp.MdiParent = this;
            oFrm_sp.StartPosition = FormStartPosition.CenterScreen;
            oFrm_sp.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void Tbar_Producto_Click(object sender, EventArgs e)
        {
            Frm_Productos oFrm_pr = new Frm_Productos();
            oFrm_pr.MdiParent = this;
            oFrm_pr.StartPosition = FormStartPosition.CenterScreen;
            oFrm_pr.Show();
        }

        private void Tbar_Clientes_Click(object sender, EventArgs e)
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

        private void Tbar_Entrada_Click(object sender, EventArgs e)
        {
            Frm_EntradaProductos oFrm_ep = new Frm_EntradaProductos();
            oFrm_ep.MdiParent = this;
            oFrm_ep.StartPosition = FormStartPosition.CenterScreen;
            oFrm_ep.Show();
        }

        private void Tbar_Salida_Click(object sender, EventArgs e)
        {
            Frm_Salida oFrm_sp = new Frm_Salida();
            oFrm_sp.MdiParent = this;
            oFrm_sp.StartPosition = FormStartPosition.CenterScreen;
            oFrm_sp.Show();
        }

   

        private void ingresoDeComprasPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_Ingreso_ComprasxProductos oFrm_rep1 = new Reportes_Consolidados.Frm_Reporte_Ingreso_ComprasxProductos();
            oFrm_rep1.MdiParent = this;
            oFrm_rep1.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep1.Show();
        }

        private void salidasDeVentasPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_VentasxProductos oFrm_rep2 = new Reportes_Consolidados.Frm_Reporte_VentasxProductos();
            oFrm_rep2.MdiParent = this;
            oFrm_rep2.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep2.Show();
        }

        private void ingresoAcumuladoPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_IngresoAcumuladoxProducto oFrm_rep2 = new Reportes_Consolidados.Frm_Reporte_IngresoAcumuladoxProducto();
            oFrm_rep2.MdiParent = this;
            oFrm_rep2.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep2.Show();
        }

        private void salidaAcumuladoPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Reporte_Salida_AcumuladoxProductos oFrm_rep3 = new Reportes_Consolidados.Frm_Reporte_Salida_AcumuladoxProductos();
            oFrm_rep3.MdiParent = this;
            oFrm_rep3.StartPosition = FormStartPosition.CenterScreen;
            oFrm_rep3.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios oFrm_us = new Usuarios();
            oFrm_us.MdiParent = this;
            oFrm_us.StartPosition = FormStartPosition.CenterScreen;
            oFrm_us.Show();
        }
    }
}
