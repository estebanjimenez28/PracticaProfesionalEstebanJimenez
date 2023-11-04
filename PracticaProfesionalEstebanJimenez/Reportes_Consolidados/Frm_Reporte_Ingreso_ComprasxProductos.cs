using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaProfesionalEstebanJimenez.Reportes_Consolidados
{
    public partial class Frm_Reporte_Ingreso_ComprasxProductos : Form
    {
        public Frm_Reporte_Ingreso_ComprasxProductos()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void BtnVista_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Rpt_IngresosxProductos oRpt_ICP = new Frm_Rpt_IngresosxProductos();
            oRpt_ICP.txt_p1.Text =Convert.ToString(Dtp_Fecha_Ini.Value);
            oRpt_ICP.txt_p2.Text = Convert.ToString(Dtp_Fecha_fin.Value);
            oRpt_ICP.ShowDialog();
        }

        private void Dtp_Fecha_fin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dtp_Fecha_Ini_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
