using ProyectoFinal_DAE.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_DAE.Paciente
{
    public partial class fPaciente : Form
    {
        ConsultaBD consult = new ConsultaBD();
        public fPaciente()
        {
            InitializeComponent();
        }

        //Código para agregar
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && richTextBox1.Text != "" && dateTimePicker1.Value != DateTime.Now.Date)
            {
                string nombre = textBox1.Text;
                string apellido = textBox2.Text;
                string fechaNac = dateTimePicker1.Value.ToString();
                string direccion = richTextBox1.Text.ToString();

                string sql = "INSERT INTO Paciente VALUES ('" + nombre + "', '" + apellido + "', '" + fechaNac + "', '" + direccion + "' )";

                consult.ejecutarComando(sql);

                cargar();
                limpiar();
            }
            else
            {
                MessageBox.Show("Llene todos los campos","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            richTextBox1.Text = "";
        }

        //Código para actualizar
        private void fPaciente_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ///Actualizar
            string sql = "select id_paciente,nombre +' '+ apellido as nombre from Paciente";
            comboBox2.DisplayMember = "nombre";
            comboBox2.ValueMember = "id_paciente";
            comboBox2.DataSource = consult.consulta(sql);

            ///Consultar
            //Carga todos los datos de la tabla empleado en el dataGridView1
            string sql2 = "SELECT * FROM Paciente";
            dataGridView1.DataSource = consult.consulta(sql2);
            dataGridView1.Refresh();

            //Carga el nombre completo en el comboBox1
            string sql3 = "select id_paciente,nombre +' '+ apellido as nombre from Paciente";
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "id_paciente";
            comboBox1.DataSource = consult.consulta(sql3);

            ///Eliminar
            //Muestra todos los pacientes en el comboBox3
            string sql4 = "select id_paciente,nombre +' '+ apellido as nombre from Paciente";
            comboBox3.DisplayMember = "nombre";
            comboBox3.ValueMember = "id_paciente";
            comboBox3.DataSource = consult.consulta(sql4);

            //Muestra todos los datos de los pacientes en el datGridView
            string sql5 = "SELECT * FROM Paciente";
            dataGridView2.DataSource = consult.consulta(sql5);
            dataGridView2.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                string dNombre = comboBox2.SelectedValue.ToString();

                string sql = "SELECT * FROM Paciente WHERE id_paciente = '" + dNombre + "'";

                DataTable tabla = consult.consulta(sql);

                textBox3.Text = tabla.Rows[0][1].ToString();
                textBox4.Text = tabla.Rows[0][2].ToString();
                dateTimePicker2.Value = Convert.ToDateTime(tabla.Rows[0][3]);
                richTextBox2.Text = tabla.Rows[0][4].ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un paciente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "" && richTextBox2.Text != "" && dateTimePicker2.Value != DateTime.Now.Date)
            {
                string nombre = textBox3.Text;
                string apellido = textBox4.Text;
                string fecha = dateTimePicker2.Value.ToString();
                string direc = richTextBox2.Text;
                string dNombre = comboBox2.SelectedValue.ToString();

                string sql = "UPDATE Paciente SET nombre = '" + nombre + "', apellido = '" + apellido + "', fechaNacPaci = '" + fecha +
                    "', direccion = '" + direc + "' WHERE id_paciente = '" + dNombre + "'";

                consult.ejecutarComando(sql);

                cargar();
                limpiar3();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string dNombre = comboBox1.SelectedValue.ToString();

                string sql = "SELECT * FROM Paciente WHERE id_paciente= '" + dNombre + "'";
                dataGridView1.DataSource = consult.consulta(sql);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Seleccione un paciente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker3.Value.ToString();

            string sql = "SELECT * FROM Paciente WHERE fechaNacPaci = '" + fecha + "'";
            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Paciente";
            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                string pEliminar = comboBox3.SelectedValue.ToString();

                string sql = "DELETE FROM Paciente WHERE id_paciente = " + pEliminar + "";
                if (consult.ejecutarComando(sql) == true)
                {
                    MessageBox.Show("Eliminado con exito", "Imformación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Muestra todos los datos de los pacientes en el datGridView
                string sql5 = "SELECT * FROM Paciente";
                dataGridView2.DataSource = consult.consulta(sql5);
                dataGridView2.Refresh();

                cargar();
                limpiar2();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            limpiar2();
        }

        private void limpiar2()
        {
            comboBox1.SelectedIndex = -1;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar3();
        }
        private void limpiar3()
        {
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker2.Value = DateTime.Today;
            richTextBox2.Text = "";
        }
    }
}
