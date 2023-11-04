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
    public partial class Frm_Reporte_IngresoAcumuladoxProducto : Form
    {
        public Frm_Reporte_IngresoAcumuladoxProducto()
        {
            InitializeComponent();
        }

        private void BtnVista_Click(object sender, EventArgs e)
        {
            Reportes_Consolidados.Frm_Rpt_AcumuladoxProducto oRpt_IAP = new Frm_Rpt_AcumuladoxProducto();
            oRpt_IAP.txt_p1.Text = Convert.ToString(Dtp_Fecha_Ini.Value);
            oRpt_IAP.txt_p2.Text = Convert.ToString(Dtp_Fecha_fin.Value);
            oRpt_IAP.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
