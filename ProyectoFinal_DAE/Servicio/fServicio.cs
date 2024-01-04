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

namespace ProyectoFinal_DAE.Servicio
{
    public partial class fServicio : Form
    {
        ConsultaBD consult = new ConsultaBD();
        public fServicio()
        {
            InitializeComponent();
        }

        private void fServicio_Load(object sender, EventArgs e)
        {
            cargar();      
        }

        private void cargar()
        {
            ///Actualizar
                string sql = "select id_servicio, nombreServ from Servicio";
                comboBox2.DisplayMember = "nombreServ";
                comboBox2.ValueMember = "id_servicio ";
                comboBox2.DataSource = consult.consulta(sql);

            ///Consultar
                //Carga todos los datos de la tabla servicio en el dataGridView1
                string sql3 = "SELECT * FROM Servicio";
                dataGridView1.DataSource = consult.consulta(sql3);
                dataGridView1.Refresh();

                //Carga el nombre completo en el comboBox1
                string sql2 = "select id_servicio, nombreServ from Servicio";
                comboBox1.DisplayMember = "nombreServ";
                comboBox1.ValueMember = "id_servicio";
                comboBox1.DataSource = consult.consulta(sql2);

            ///Eliminar
                //Carga todos los datos de la tabla servicio en el dataGridView2
                string sql4 = "SELECT * FROM Servicio";
                dataGridView2.DataSource = consult.consulta(sql4);
                dataGridView2.Refresh();

                //Muestra los nombre de los pacientes en el comboBox3
                string sql5 = "select id_servicio, nombreServ from Servicio";
                comboBox3.DisplayMember = "nombreServ";
                comboBox3.ValueMember = "id_servicio";
                comboBox3.DataSource = consult.consulta(sql5);
        }

        //Código para agregar
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && richTextBox1.Text != "" && numericUpDown1.Value > 1)
            {
                string nombre = textBox1.Text;
                string descrip = richTextBox1.Text;
                string precio = numericUpDown1.Value.ToString();

                string sql = "INSERT INTO Servicio VALUES ('" + nombre + "','" + descrip + "','" + precio + "')";

                consult.ejecutarComando(sql);

                DetServicio det = new DetServicio();
                det.ShowDialog();

                cargar();
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
            numericUpDown1.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text != "" && numericUpDown2.Value > 0 && comboBox2.SelectedIndex != -1)
            {
                string descripción = richTextBox2.Text;
                string precio = numericUpDown2.Value.ToString();
                string dNombre = comboBox2.SelectedText;

                string sql = "UPDATE Servicio SET descripcionServ = '" + descripción + "', precioServ = " + precio + " WHERE nombreServ = '" + dNombre + "'";

                consult.ejecutarComando(sql);

                cargar();
                limpiar2();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar2();
        }

        private void limpiar2()
        {
            richTextBox2.Text = "";
            numericUpDown2.Value = 0;
            comboBox2.SelectedIndex = -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string dNombre = comboBox1.SelectedValue.ToString();

                string sql = "SELECT * FROM Servicio WHERE id_servicio = '" + dNombre + "'";
                dataGridView1.DataSource = consult.consulta(sql);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("DSeleccione un servicio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Servicio";
            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                string Eliminar = comboBox3.Text;

                string sql = "DELETE FROM Servicio WHERE nombreServ = '" + Eliminar + "'";
                if (consult.ejecutarComando(sql) == true)
                {
                    MessageBox.Show("Eliminado con exito", "Imformación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cargar();
                limpiar3();
            }
            else
            {
                MessageBox.Show("Seleccione un productoa eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            limpiar3();
        }

        private void limpiar3()
        {
            comboBox3.SelectedIndex = -1;
        }
    }
}
