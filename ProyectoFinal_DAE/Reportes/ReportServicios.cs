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
    public partial class ReportServicios : Form
    {
        public ReportServicios()
        {
            InitializeComponent();
        }

        private void ReportServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCita.Servicio' Puede moverla o quitarla según sea necesario.
            this.servicioTableAdapter.Fill(this.dataSetCita.Servicio);

            this.reportViewer1.RefreshReport();
        }
    }
}
