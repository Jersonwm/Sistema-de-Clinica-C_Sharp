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
    public partial class ReportProductos : Form
    {
        public ReportProductos()
        {
            InitializeComponent();
        }

        private void ReportProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCita.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dataSetCita.Producto);

            this.reportViewer1.RefreshReport();
        }
    }
}
