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
    public partial class ReportFactura : Form
    {
        public ReportFactura()
        {
            InitializeComponent();
        }

        private void ReportFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCita.TotalPagar' Puede moverla o quitarla según sea necesario.
            this.totalPagarTableAdapter.Fill(this.dataSetCita.TotalPagar);
            // TODO: esta línea de código carga datos en la tabla 'dataSetCita.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.dataSetCita.Factura);
            // TODO: esta línea de código carga datos en la tabla 'dataSetCita.DetalleFactura' Puede moverla o quitarla según sea necesario.
            this.detalleFacturaTableAdapter.Fill(this.dataSetCita.DetalleFactura);

            this.reportViewer1.RefreshReport();
        }
    }
}
