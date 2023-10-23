using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaProfesionalEstebanJimenez.Reportes
{
    public partial class Frm_Rpt_Productos : Form
    {
        public Frm_Rpt_Productos()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Productos_Load(object sender, EventArgs e)
        {
            this.uSP_Listado_prTableAdapter.Fill(this.dataSet_Carniceria.USP_Listado_pr, cTexto: txt_p1.Text);
            this.reportViewer1.RefreshReport();
        }

        private void txt_p1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
