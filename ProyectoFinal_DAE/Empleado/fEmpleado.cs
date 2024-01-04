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

namespace ProyectoFinal_DAE.Empleado
{
    public partial class fEmpleado : Form
    {
        ConsultaBD consult = new ConsultaBD();
        Encriptar encrip = new Encriptar();
        public fEmpleado()
        {
            InitializeComponent();
        }

        private void fEmpleado_Load(object sender, EventArgs e)
        {
            ///Agregar
            string sql = "SELECT * FROM Empleado";

            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();

            ///Actualizar
                 //Carga el nombre completo en el comboBox2
                string sql2 = "select id_empleado,nombreEmp +' '+ apellidoEmp as nombre from Empleado";
                comboBox2.DisplayMember = "nombre";
                comboBox2.ValueMember = "id_empleado";
                comboBox2.DataSource = consult.consulta(sql2);

            ///Consultar
                 //Carga todos los datos de la tabla empleado en el dataGridView1
                string sql3 = "SELECT * FROM Empleado";
                dataGridView2.DataSource = consult.consulta(sql3);
                dataGridView2.Refresh();

                //Carga el nombre completo en el comboBox1
                string sql4 = "select id_empleado,nombreEmp +' '+ apellidoEmp as nombre from Empleado";
                comboBox5.DisplayMember = "nombre";
                comboBox5.ValueMember = "id_empleado";
                comboBox5.DataSource = consult.consulta(sql4);

                //Carga los estados de los empleados en el comboBox2
                string sql5 = "SELECT DISTINCT estadoEmp FROM Empleado";
                comboBox4.DisplayMember = "estadoEmp";
                comboBox4.DataSource = consult.consulta(sql5);

            ///Eliminar
                //Muestra los nombre sde elos empleados en el comboBox
                string sql6 = "select id_empleado,nombreEmp +' '+ apellidoEmp as nombre from Empleado";
                comboBox6.DisplayMember = "nombre";
                comboBox6.ValueMember = "id_empleado";
                comboBox6.DataSource = consult.consulta(sql6);

                //Muestra todos los datos de los empleados en el datGridView
                string sql7 = "SELECT * FROM Empleado";
                dataGridView3.DataSource = consult.consulta(sql7);
                dataGridView3.Refresh();
        }

        //Código para ingresar
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.SelectedIndex != -1 && dateTimePicker1.Value != DateTime.Now && dateTimePicker2.Value != DateTime.Now)
            {
                string nombre = textBox1.Text;
                string apellido = textBox2.Text;
                string cargo = comboBox1.Text;
                string fechaNac = dateTimePicker1.Value.ToString();
                string fechaCon = dateTimePicker2.Value.ToString();
                string usuario = textBox3.Text;
                string contraseña = encrip.encriptar(textBox4.Text, "Trabajo Final");

                string sql = "INSERT INTO Empleado VALUES ('" + nombre + "','" + apellido + "','" + cargo + "','" + fechaNac + "','" + fechaCon + "','Activo','" + usuario + "','" + contraseña + "')";

                consult.ejecutarComando(sql);

                string sql2 = "SELECT * FROM Empleado";

                dataGridView1.DataSource = consult.consulta(sql2);
                dataGridView1.Refresh();

                limpiar();
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
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            comboBox1.SelectedIndex = -1;
        }

        //Código para actualizar
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                string dNombre = comboBox2.SelectedValue.ToString();

                string sql = "SELECT * FROM Empleado WHERE id_empleado = '" + dNombre + "'";

                DataTable tabla = consult.consulta(sql);

                textBox7.Text = tabla.Rows[0][1].ToString();
                textBox8.Text = tabla.Rows[0][2].ToString();
                textBox6.Text = tabla.Rows[0][7].ToString();
                textBox5.Text = encrip.desencriptar(tabla.Rows[0][7].ToString(), "Trabajo Final");
                dateTimePicker4.Value = Convert.ToDateTime(tabla.Rows[0][4]);
                dateTimePicker3.Value = Convert.ToDateTime(tabla.Rows[0][5]);
                comboBox1.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Seleccione un empleado","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "" && textBox8.Text != "" && textBox6.Text != "" && textBox5.Text != "" && comboBox3.SelectedIndex != -1 && dateTimePicker3.Value != DateTime.Now && dateTimePicker4.Value != DateTime.Now)
            {
                string nombre = textBox7.Text;
                string apellido = textBox8.Text;
                string cargo = comboBox3.Text;
                string estado = comboBox7.Text;
                string fechaNac = dateTimePicker4.Value.ToString();
                string fechaCon = dateTimePicker3.Value.ToString();
                string usuario = textBox6.Text;
                string contraseña = encrip.encriptar(textBox5.Text, "Trabajo Final");
                string dNombre = comboBox2.SelectedValue.ToString();

                string sql = "UPDATE Empleado SET nombreEmp = '" + nombre + "', apellidoEmp = '" + apellido + "', cargoEmp = '" + cargo +
                    "', fechaNacEmp = '" + fechaNac + "', fechaContratEmp = '" + fechaCon + "', estadoEmp = '" + estado + "', usuario ='" + usuario +
                    "', contraseña = '" + contraseña + "' Where id_empleado = '" + dNombre + "'";

                consult.ejecutarComando(sql);

                limpiar2();
            }
            else
            {
                MessageBox.Show("Debe llenar cada campo del formulario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar2();    
        }

        private void limpiar2()
        {
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            dateTimePicker3.Value = DateTime.Today;
            dateTimePicker4.Value = DateTime.Today;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Empleado";
            dataGridView2.DataSource = consult.consulta(sql);
            dataGridView2.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex != -1)
            {
                string dNombre = comboBox5.SelectedValue.ToString();

                string sql = "SELECT * FROM Empleado WHERE id_empleado = '" + dNombre + "'";
                dataGridView2.DataSource = consult.consulta(sql);
                dataGridView2.Refresh();
            }
            else
            {
                MessageBox.Show("Seleccione un empleado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dateTimePicker5.Value != DateTime.Now.Date)
            {
                string fecha = dateTimePicker5.Value.ToString();

                string sql = "SELECT * FROM Empleado WHERE fechaContratEmp = '" + fecha + "'";
                dataGridView2.DataSource = consult.consulta(sql);
                dataGridView2.Refresh();
            }
            else
            {
                MessageBox.Show("Seleccione una fecha", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != -1)
            {
                string estado = comboBox4.Text;

                string sql = "SELECT * FROM Empleado WHERE estadoEmp = '" + estado + "'";
                dataGridView2.DataSource = consult.consulta(sql);
                dataGridView2.Refresh();
            }
            else
            {
                MessageBox.Show("Seleccione un estado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex != -1)
            {
                string pEliminar = comboBox6.Text;

                string sql = "UPDATE Empleado SET estadoEmp = 'Inactivo' WHERE nombreEmp+' '+apellidoEmp = '" + pEliminar + "'";
                if (consult.ejecutarComando(sql) == true)
                {
                    MessageBox.Show("Eliminado con exito", "Imformación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string sql7 = "SELECT * FROM Empleado";
                dataGridView3.DataSource = consult.consulta(sql7);
                dataGridView3.Refresh();

                limpiar3();
            }
            else
            {
                MessageBox.Show("ESeleccione un empleado a despedir", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            limpiar3();
        }

        private void limpiar3()
        {
            comboBox2.SelectedIndex = -1;
        }
    }
}
