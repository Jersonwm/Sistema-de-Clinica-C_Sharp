using ProyectoFinal_DAE.Clases;
using ProyectoFinal_DAE.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ProyectoFinal_DAE.Factura
{
    public partial class GenFactura : Form
    {
        ConsultaBD consult = new ConsultaBD();
       
        public GenFactura()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void GenFactura_Load(object sender, EventArgs e)
        {
            //Presentar los pacientes
            string sql = "select id_paciente, nombre+' '+apellido as NombreCompleto from Paciente";
            comboBox2.DisplayMember = "NombreCompleto";
            comboBox2.ValueMember = "id_paciente";
            comboBox2.DataSource = consult.consulta(sql);

            //Presentar los empleados
            string sql2 = "select id_empleado, nombreEmp+' '+apellidoEmp as Nombrecompleto from Empleado";
            comboBox3.DisplayMember = "Nombrecompleto";
            comboBox3.ValueMember = "id_empleado";
            comboBox3.DataSource = consult.consulta(sql2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex !=-1)
            {
                string fecha = DateTime.Now.ToString();
                string tipoP = comboBox1.Text;
                string paci = comboBox2.SelectedValue.ToString();
                string emple = comboBox3.SelectedValue.ToString();

                string sql = "insert into Factura values('" + fecha + "','" + tipoP + "', " + paci + "," + emple + ")";
                consult.ejecutarComando(sql);

                DetFactura detalle = new DetFactura();
                detalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Todos los datos anteriores son necesarios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportFactura factura = new ReportFactura();
            factura.ShowDialog();
        }
    }
}
