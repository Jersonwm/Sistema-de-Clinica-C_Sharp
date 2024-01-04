using ProyectoFinal_DAE.Cita;
using ProyectoFinal_DAE.Empleado;
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
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_DAE
{
    public partial class PrincipalDueño : Form
    {
        public PrincipalDueño()
        {
            InitializeComponent();
        }

        private void PrincipalDueño_Load(object sender, EventArgs e)
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generarFacturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenFactura ventana2 = new GenFactura();
            ventana2.MdiParent = this;
            ventana2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void expedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEmpleado empleado = new fEmpleado();
            empleado.MdiParent = this;
            empleado.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPaciente ventana3 = new fPaciente();
            ventana3.MdiParent = this;
            ventana3.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProducto ventana4 = new fProducto();
            ventana4.MdiParent = this;
            ventana4.Show();
        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fServicio ventana5 = new fServicio();
            ventana5.MdiParent = this;
            ventana5.Show();
        }

        private void citaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cita.Cita ventana6 = new Cita.Cita();
            ventana6.MdiParent = this;
            ventana6.Show();
        }

        private void pacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fPaciente ventana7 = new fPaciente();
            ventana7.MdiParent = this;
            ventana7.Show();
        }

        private void servicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fServicio ventana8 = new fServicio();
            ventana8.MdiParent = this;
            ventana8.Show();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fProducto ventana9 = new fProducto();
            ventana9.MdiParent = this;
            ventana9.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda ventana0 = new Ayuda();
            ventana0.MdiParent = this;
            ventana0.Show();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reporteDeCitasDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReprtCitasDia reporte = new ReprtCitasDia();
            reporte.MdiParent = this;
            reporte.Show();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void productoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fProducto producto = new fProducto();
            producto.MdiParent = this;
            producto.Show();
        }

        private void servicioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fServicio servicio = new fServicio();
            servicio.MdiParent = this;
            servicio.Show();
        }
    }
}
