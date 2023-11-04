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
    public partial class Frm_Rpt_IngresosxProductos : Form
    {
        public Frm_Rpt_IngresosxProductos()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_IngresosxProductos_Load(object sender, EventArgs e)
        {
           this.uSP_Reporte_Ingresos_ComprasxProductosTableAdapter.Fill(this.dataSet_ReportesConsolidados.USP_Reporte_Ingresos_ComprasxProductos, Fecha_ini: Convert.ToDateTime(txt_p1.Text),Fecha_fin:Convert.ToDateTime(txt_p2.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
