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
    public partial class Frm_Reporte_VentasxProductos : Form
    {
        public Frm_Reporte_VentasxProductos()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVista_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Rpt_VentasxProductos oRpt_IVP = new Frm_Rpt_VentasxProductos();
            oRpt_IVP.txt_p1.Text = Convert.ToString(Dtp_Fecha_Ini.Value);
            oRpt_IVP.txt_p2.Text = Convert.ToString(Dtp_Fecha_fin.Value);
            oRpt_IVP.ShowDialog();
        }
    }
}
