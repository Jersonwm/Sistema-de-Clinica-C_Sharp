using ProyectoFinal_DAE.Empleado;
using ProyectoFinal_DAE.Expediente;
using ProyectoFinal_DAE.Paciente;
using ProyectoFinal_DAE.Producto;
using ProyectoFinal_DAE.Reportes;
using ProyectoFinal_DAE.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_DAE
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pant_Carga());
        }
    }
}
