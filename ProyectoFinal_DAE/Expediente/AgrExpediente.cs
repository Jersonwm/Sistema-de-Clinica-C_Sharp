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

namespace ProyectoFinal_DAE.Expediente
{
    public partial class AgrExpediente : Form
    {
        ConsultaBD consult = new ConsultaBD();
        public AgrExpediente()
        {
            InitializeComponent();
        }

        private void AgrExpediente_Load(object sender, EventArgs e)
        {
            ///Agregar
                //Imprime todos los doctores en el comboBox3
                string sql = "select id_empleado, nombreEmp+' '+apellidoEmp as NombreCompleto from Empleado where estadoEmp = 'Activo' and cargoEmp = 'Doctor'";
                comboBox3.DisplayMember = "NombreCompleto";
                comboBox3.ValueMember = "id_empleado ";
                comboBox3.DataSource = consult.consulta(sql);

                //Imprime todas las citas para este día
                string fecha = DateTime.Today.Date.ToShortDateString();
                string sql2 = "select c.id_cita as id, p.nombre+' '+p.apellido as NombreCom from Cita c" +
                    " inner join paciente p on p.id_paciente = c.id_Paciente" +
                    " where fechaCita = '" + fecha + "' order by id_cita desc";
                comboBox2.DisplayMember = "NombreCom";
                comboBox2.ValueMember = "id";
                comboBox2.DataSource = consult.consulta(sql2);

            ///Actualizar
                //Imprime todos los doctores en el comboBox3
                string sql3 = "select id_empleado, nombreEmp+' '+apellidoEmp as NombreCompleto from Empleado where cargoEmp = 'Doctor' and estadoEmp = 'Activo'";
                comboBox6.DisplayMember = "NombreCompleto";
                comboBox6.ValueMember = "id_empleado";
                comboBox6.DataSource = consult.consulta(sql3);

                //Imprime todas las citas
                string fecha2 = DateTime.Today.Date.ToShortDateString();
                string sql4 = " select c. id_cita, p.nombre+' '+p.apellido as NombreCompleto, c.fechaCita from Cita c" +
                   " inner join paciente p on p.id_paciente = c.id_Paciente " +
                   " where fechaCita = '" + fecha2 + "' order by id_cita desc";
                comboBox5.DisplayMember = "NombreCompleto";
                comboBox5.ValueMember = "id_cita";
                comboBox5.DataSource = consult.consulta(sql4);

                //Imprime todos los informes en el comboBox3
                string sql5 = "select e.id_expediente, p.nombre+' '+p.apellido as NombreCompleto, c.fechaCita  " +
                    "from Expediente e inner join paciente p on p.id_paciente = e.id_Paciente " +
                    "inner join Cita c on c.id_cita = e.id_Cita";
                comboBox4.DisplayMember = "NombreCompleto";
                comboBox4.ValueMember = "id_expediente";
                comboBox4.DataSource = consult.consulta(sql5);

            ///Consultar
             //Carga todos los datos de la tabla expediente en el dataGridView1
                string sql6 = "select e.id_expediente, e.diagnostico, e.recomendacion, e.receta, e.notaAdici," +
                    " e.id_Cita, p.nombre+' '+p.apellido as NPaciente, em.nombreEmp+' '+em.apellidoEmp as NEmpleado" +
                    "  from Expediente e inner join Paciente p on p.id_paciente = e.id_Paciente " +
                    "inner join Empleado em on em.id_empleado = e.id_Empleado";
                dataGridView1.DataSource = consult.consulta(sql6);
                dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string nombre = textBox1.Text;
                string sql = "select id_paciente, nombre+' '+apellido as NombreCompleto from Paciente where nombre like '%" + nombre + "%'";

                comboBox1.DisplayMember = "NombreCompleto";
                comboBox1.ValueMember = "id_paciente";
                comboBox1.DataSource = consult.consulta(sql);
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de un paciente","Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string paciente = comboBox1.SelectedValue.ToString();
            string cita = comboBox2.SelectedValue.ToString();
            string doctor = comboBox3.SelectedValue.ToString();

            string diagnostico = richTextBox1.Text;
            string recomendacion = richTextBox2.Text;
            string receta = richTextBox3.Text;
            string nota = richTextBox4.Text;
            if (richTextBox1.Text != "" && richTextBox2.Text != "" && richTextBox3.Text != "" && richTextBox4.Text != "")
            {
                string sql = "insert into Expediente values('" + diagnostico + "','" + recomendacion + "','" + receta + "','" + nota + "'," + cita + "," + paciente + "," + doctor + ")";

                consult.ejecutarComando(sql);

                limpiar();
            }       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
        }

        //Código para actualizar
        private void button7_Click(object sender, EventArgs e)
        {
            string expe = comboBox4.SelectedValue.ToString();

            string sql = "select * from Expediente where id_expediente ='" + expe + "'";

            DataTable tabla = consult.consulta(sql);

            richTextBox7.Text = tabla.Rows[0][1].ToString();
            richTextBox6.Text = tabla.Rows[0][2].ToString();
            richTextBox5.Text = tabla.Rows[0][3].ToString();
            richTextBox8.Text = tabla.Rows[0][4].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string nombre = textBox2.Text;
                string sql = "select id_paciente, nombre+' '+apellido as NombreCompleto from Paciente " +
                    "where nombre like '%" + nombre + "%'";

                comboBox7.DisplayMember = "NombreCompleto";
                comboBox7.ValueMember = "id_paciente";
                comboBox7.DataSource = consult.consulta(sql);
            }
            else
            {
                MessageBox.Show("Debe ingresar un código de expediente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {           
            string paciente = comboBox7.SelectedValue.ToString();
            string cita = comboBox5.SelectedValue.ToString();
            string doctor = comboBox6.SelectedValue.ToString();
            string diagnostico = richTextBox7.Text;
            string recomendacion = richTextBox6.Text;
            string receta = richTextBox5.Text;
            string nota = richTextBox8.Text;
            string idE = comboBox4.SelectedValue.ToString();

            if (richTextBox5.Text != "" && richTextBox6.Text != "" && richTextBox7.Text != "" && richTextBox8.Text != "")
            {
                string sql = "update Expediente set diagnostico ='" + diagnostico + "', recomendacion ='" + recomendacion + "', receta ='" + receta +
                               "', notaAdici ='" + nota + "', id_Cita =" + cita + ", id_Paciente =" + paciente + ", id_Empleado =" + doctor + "where id_expediente =" + idE;

                consult.ejecutarComando(sql);

                limpiar2();
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos","Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar2();
        }

        private void limpiar2()
        {
            textBox2.Text = "";
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            richTextBox7.Text = "";
            richTextBox6.Text = "";
            richTextBox5.Text = "";
            richTextBox8.Text = "";
        }

        //Código para consultar
        private void button9_Click(object sender, EventArgs e)
        {
            string busqueda = textBox3.Text;

            if (textBox3.Text != "")
            {
                //Carga todos los datos de la tabla expediente en el dataGridView1
                string sql = "select e.id_expediente, e.diagnostico, e.recomendacion, e.receta, e.notaAdici," +
                    " e.id_Cita, p.nombre+' '+p.apellido as NPaciente, em.nombreEmp+' '+em.apellidoEmp as NEmpleado" +
                    "  from Expediente e inner join Paciente p on p.id_paciente = e.id_Paciente " +
                    "inner join Empleado em on em.id_empleado = e.id_Empleado " +
                    "where p.nombre like '%" + busqueda + "%' ";
                dataGridView1.DataSource = consult.consulta(sql);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.ToString();

            //Carga todos los datos de la tabla expediente en el dataGridView1
            string sql = "select e.id_expediente, e.diagnostico, e.recomendacion, e.receta, e.notaAdici," +
                " e.id_Cita, p.nombre+' '+p.apellido as NPaciente, em.nombreEmp+' '+em.apellidoEmp as NEmpleado" +
                "  from Expediente e inner join Paciente p on p.id_paciente = e.id_Paciente " +
                " inner join Empleado em on em.id_empleado = e.id_Empleado" +
                " inner join Cita c on c.id_cita = e.id_Cita where c.fechaCita = '" + fecha + "'";
            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Carga todos los datos de la tabla expediente en el dataGridView1
            string sql = "select e.id_expediente, e.diagnostico, e.recomendacion, e.receta, e.notaAdici," +
                " e.id_Cita, p.nombre+' '+p.apellido as NPaciente, em.nombreEmp+' '+em.apellidoEmp as NEmpleado" +
                "  from Expediente e inner join Paciente p on p.id_paciente = e.id_Paciente " +
                "inner join Empleado em on em.id_empleado = e.id_Empleado";
            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string busqueda = textBox4.Text;

            //Carga todos los datos de la tabla expediente en el dataGridView1
            string sql = "select e.id_expediente, e.diagnostico, e.recomendacion, e.receta, e.notaAdici," +
                " e.id_Cita, p.nombre+' '+p.apellido as NPaciente, em.nombreEmp+' '+em.apellidoEmp as NEmpleado" +
                "  from Expediente e inner join Paciente p on p.id_paciente = e.id_Paciente" +
                " inner join Empleado em on em.id_empleado = e.id_Empleado" +
                " where p.nombre like '%" + busqueda + "%' ";
            dataGridView2.DataSource = consult.consulta(sql);
            dataGridView2.Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                string cod = textBox5.Text;

                string sql = "delete from Expediente where id_expediente = " + cod;

                consult.ejecutarComando(sql);

                limpiar3();
            }
            else
            {
                MessageBox.Show("Debe ingresar un código de expediente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            limpiar3();
        }

        private void limpiar3()
        {
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
