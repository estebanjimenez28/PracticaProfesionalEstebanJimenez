using PracticaProfesionalEstebanJimenez.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaProfesionalEstebanJimenez
{
    internal static class Program
    {
        //Se procede a llamar el formulario que ejecutara la aplicacion
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Registro());
        }
    }
}
