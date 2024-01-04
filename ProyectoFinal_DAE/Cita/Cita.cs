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

namespace ProyectoFinal_DAE.Cita
{
    public partial class Cita : Form
    {
        ConsultaBD consult = new ConsultaBD();
        public Cita()
        {
            InitializeComponent();
        }

        private void Cita_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ///Agregar
            //Muestra todos los pacientes en el comboBox1
            string sql = "select id_paciente,nombre +' '+ apellido as nombrePa from Paciente";
            comboBox1.DisplayMember = "nombrePa";
            comboBox1.ValueMember = "id_paciente";
            comboBox1.DataSource = consult.consulta(sql);

            //Muestra todos los empleados en el comboBox2
            string sql2 = "select id_empleado,nombreEmp +' '+ apellidoEmp as nombreEm from Empleado";
            comboBox2.DisplayMember = "nombreEm";
            comboBox2.ValueMember = "id_empleado";
            comboBox2.DataSource = consult.consulta(sql2);

            ///Actualizar
            //LLena el comboBox3 con el nombre de la persona que hizo la cita
            string sql5 = "select id_paciente, nombre+' '+apellido as Nombre from Paciente";
            comboBox3.DisplayMember = "Nombre";
            comboBox3.ValueMember = "id_paciente";
            comboBox3.DataSource = consult.consulta(sql5);

            ///Consultar
            //LLena el dataGridView con todas las citas
            string sql6 = "select c.id_cita, c.fechaCita, c.horaCita, p.nombre+' '+p.apellido as NPaciente, e.nombreEmp+' '+e.apellidoEmp as NEmpleado from Cita c" +
                " inner join Paciente p on p.id_paciente = c.id_Paciente" +
                " inner join Empleado e on e.id_empleado = c.id_Empleado";
            dataGridView1.DataSource = consult.consulta(sql6);
            dataGridView1.Refresh();

            //Muestra el nombre de las personas en el comboBox1
            string sql7 = "SELECT id_paciente, nombre+' '+apellido as nombreCompleto from Paciente";
            comboBox7.DisplayMember = "nombreCompleto";
            comboBox7.ValueMember = "id_paciente";
            comboBox7.DataSource = consult.consulta(sql7);

            ///Eliminar
            //LLena el comboBox3 con el nombre de la persona que hizo la cita
            string sql8 = "select id_paciente, nombre+' '+apellido as Nombre from Paciente";
            comboBox9.DisplayMember = "Nombre";
            comboBox9.ValueMember = "id_paciente";
            comboBox9.DataSource = consult.consulta(sql8);

            //carga todos los datos en datagridview
            string sql9 = "select c.id_cita, c.fechaCita, c.horaCita, p.nombre+' '+p.apellido as NPaciente, e.nombreEmp+' '+e.apellidoEmp as NEmpleado from Cita c" +
                " inner join Paciente p on p.id_paciente = c.id_Paciente" +
                " inner join Empleado e on e.id_empleado = c.id_Empleado";
            dataGridView2.DataSource = consult.consulta(sql9);
            dataGridView2.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                try
                {
                    string fechaCita = dateTimePicker1.Value.ToString();
                    string horaCita = dateTimePicker2.Value.ToString();
                    string paciente = comboBox1.SelectedValue.ToString();
                    string empleado = comboBox2.SelectedValue.ToString();

                    string sql = "INSERT INTO Cita VALUES ('" + fechaCita + "','" + horaCita + "'," + paciente + "," + empleado + ")";

                    consult.ejecutarComando(sql);

                    DetCita detalle = new DetCita();
                    detalle.ShowDialog();

                    cargar();
                    limpiar();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Debe agregar un paciente anteriormente y seleccionarlo en el control", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique que este usando correctamente el programa", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al agregar cita","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        //Código para actualizar
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                string fecha = dateTimePicker3.Value.ToString();
                string paci = comboBox3.SelectedValue.ToString();

                string sql = "select c. id_cita, p.nombre+' '+p.apellido as NombreCompleto, c.fechaCita from Cita c" +
                    " inner join paciente p on p.id_paciente = c.id_Paciente" +
                    " where c.fechaCita = '" + fecha + "' and p.id_paciente = " + paci;
                comboBox4.DisplayMember = "NombreCompleto";
                comboBox4.ValueMember = "id_cita";
                comboBox4.DataSource = consult.consulta(sql);
            }
            else
            {
                MessageBox.Show("Ingrese los datos requeridos para evaluar","Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != -1)
            {
                string citaAnt = comboBox4.SelectedValue.ToString();

                string fecha = dateTimePicker5.Value.ToString();
                string hora = dateTimePicker4.Value.ToString();

                string sql = "UPDATE Cita SET fechaCita = '" + fecha + "', horaCita = '" + hora + "' WHERE id_cita = " + citaAnt + "";

                consult.ejecutarComando(sql);

                cargar();
                limpiar2();
            }
            else
            {
                MessageBox.Show("Ingrese los datos requeridos para actualizar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar2();
        }

        private void limpiar2()
        {
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            dateTimePicker3.Value = DateTime.Today;
            dateTimePicker4.Value = DateTime.Today;
            dateTimePicker5.Value = DateTime.Today;
        }
        //Código para consultar
        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex != -1)
            {
                string persona = comboBox7.SelectedValue.ToString();

                string sql = "select c.id_cita, c.fechaCita, c.horaCita, p.nombre+' '+p.apellido as NPaciente, e.nombreEmp+' '+e.apellidoEmp as NEmpleado from Cita c" +
                    " inner join Paciente p on p.id_paciente = c.id_Paciente" +
                    " inner join Empleado e on e.id_empleado = c.id_Empleado" +
                    " where c.id_Paciente = " + persona;
                dataGridView1.DataSource = consult.consulta(sql);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Seleccione un nombre","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }  
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker7.Value.ToString();
            string sql = "select c.id_cita, c.fechaCita, c.horaCita, p.nombre+' '+p.apellido as NPaciente, e.nombreEmp+' '+e.apellidoEmp as NEmpleado from Cita c" +
                " inner join Paciente p on p.id_paciente = c.id_Paciente" +
                " inner join Empleado e on e.id_empleado = c.id_Empleado" +
                " where c.fechaCita = '" + fecha + "'";
            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string hora = dateTimePicker6.Value.ToString();
            string sql = "select c.id_cita, c.fechaCita, c.horaCita, p.nombre+' '+p.apellido as NPaciente, e.nombreEmp+' '+e.apellidoEmp as NEmpleado from Cita c" +
                " inner join Paciente p on p.id_paciente = c.id_Paciente" +
                " inner join Empleado e on e.id_empleado = c.id_Empleado" +
                " where c.horaCita = '" + hora + "'";
            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //LLena el dataGridView con todas las citas
            string sql = "select c.id_cita, c.fechaCita, c.horaCita, p.nombre+' '+p.apellido as NPaciente, e.nombreEmp+' '+e.apellidoEmp as NEmpleado from Cita c" +
                " inner join Paciente p on p.id_paciente = c.id_Paciente" +
                " inner join Empleado e on e.id_empleado = c.id_Empleado";
            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker8.Value.ToString();
            string paci = comboBox9.SelectedValue.ToString();

            string sql = "select c. id_cita, p.nombre+' '+p.apellido as NombreCompleto, c.fechaCita from Cita c" +
                " inner join paciente p on p.id_paciente = c.id_Paciente" +
                " where c.fechaCita = '" + fecha + "' and p.id_paciente = " + paci;
            comboBox8.DisplayMember = "NombreCompleto";
            comboBox8.ValueMember = "id_cita";
            comboBox8.DataSource = consult.consulta(sql);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox8.SelectedIndex != -1)
            {
                string dato = comboBox8.SelectedValue.ToString();

                string sql = "delete from Cita where id_cita = " + dato;
                if (consult.ejecutarComando(sql) == true)
                {
                    MessageBox.Show("Eliminado con exito", "Imformación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dataGridView1.Refresh();

                cargar();
                limpiar4();
            }
            else
            {
                MessageBox.Show("Ingrese los datos requeridos para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            limpiar4();
        }

        private void limpiar4()
        {
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            dateTimePicker8.Value = DateTime.Now;
        }
    }
}
