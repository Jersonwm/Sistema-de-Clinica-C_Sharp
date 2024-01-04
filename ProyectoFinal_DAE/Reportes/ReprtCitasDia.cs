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
    public partial class ReprtCitasDia : Form
    {
        public ReprtCitasDia()
        {
            InitializeComponent();
        }

        private void ReprtCitasDia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCita.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.dataSetCita.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
