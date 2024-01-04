using ProyectoFinal_DAE.Cita;
using ProyectoFinal_DAE.Expediente;
using ProyectoFinal_DAE.Factura;
using ProyectoFinal_DAE.Paciente;
using ProyectoFinal_DAE.Producto;
using ProyectoFinal_DAE.Reportes;
using ProyectoFinal_DAE.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_DAE
{
    public partial class PrincipalDoctor : Form
    {
        public PrincipalDoctor()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PrincipalDoctor_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    MdiClient oMDI = (MdiClient)ctl;

                    oMDI.BackColor = Color.AliceBlue;
                }
                catch (InvalidCastException)
                {
                }
            }
        }

        private void expedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgrExpediente expediente = new AgrExpediente();
            expediente.MdiParent = this;
            expediente.Show();
        }

        private void generarFacturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenFactura ventana2 = new GenFactura();
            ventana2.MdiParent = this;
            ventana2.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda ventana0 = new Ayuda();
            ventana0.MdiParent = this;
            ventana0.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void citasDelDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReprtCitasDia repor = new ReprtCitasDia();
            repor.MdiParent=this;
            repor.Show();
        }

        private void productosEnInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportProductos report = new ReportProductos();
            report.MdiParent = this;
            report.Show();
        }

        private void serviciosOfrecidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportServicios report = new ReportServicios();
            report.MdiParent = this;
            report.Show();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cita.Cita citas = new Cita.Cita();
            citas.MdiParent = this;
            citas.Show();
        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fServicio servicio = new fServicio();
            servicio.MdiParent = this;
            servicio.Show();
        }
    }
}
