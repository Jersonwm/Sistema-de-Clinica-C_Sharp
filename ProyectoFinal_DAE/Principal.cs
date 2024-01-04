using ProyectoFinal_DAE.Cita;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
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

        private void generarFacturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenFactura ventana2 = new GenFactura();
            ventana2.MdiParent = this;
            ventana2.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda ayuda = new Ayuda();
            ayuda.MdiParent = this;
            ayuda.Show();
        }

        private void citasDelDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReprtCitasDia reporte = new ReprtCitasDia();
            reporte.MdiParent = this;
            reporte.Show();
        }

        private void productosEnInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportProductos reporte = new ReportProductos();
            reporte.MdiParent = this;
            reporte.Show();
        }

        private void empleadosActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportEmpleado reporte = new ReportEmpleado();
            reporte.MdiParent = this;
            reporte.Show();
        }

        private void serviciosOfrecidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportServicios reporte = new ReportServicios();
            reporte.MdiParent = this;
            reporte.Show();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cita.Cita citas = new Cita.Cita();
            citas.MdiParent = this;
            citas.Show();
        }

        private void pacienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fPaciente paciente = new fPaciente();
            paciente.MdiParent = this;
            paciente.Show();
        }

        private void productoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fProducto producto = new fProducto();
            producto.MdiParent = this;
            producto.Show();
        }

        private void servicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fServicio servicio = new fServicio();
            servicio.MdiParent = this;
            servicio.Show();
        }
    }
}
