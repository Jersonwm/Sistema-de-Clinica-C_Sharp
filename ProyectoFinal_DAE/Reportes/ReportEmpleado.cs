using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_DAE.Reportes
{
    public partial class ReportEmpleado : Form
    {
        public ReportEmpleado()
        {
            InitializeComponent();
        }

        private void ReportEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCita.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.dataSetCita.Empleado);

            this.reportViewer1.RefreshReport();
        }
    }
}
