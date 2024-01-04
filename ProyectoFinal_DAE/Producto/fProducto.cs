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

namespace ProyectoFinal_DAE.Producto
{
    public partial class fProducto : Form
    {
        ConsultaBD consult = new ConsultaBD();
        public fProducto()
        {
            InitializeComponent();
        }

        private void fProducto_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {   ///Actualizar
                //Carga el nombre completo en el comboBox2
                string sql2 = "select id_producto, nombreProd from Producto";
                comboBox2.DisplayMember = "nombreProd";
                comboBox2.ValueMember = "id_producto";
                comboBox2.DataSource = consult.consulta(sql2);

            ///Consultar
                //Carga todos los datos de la tabla producto en el dataGridView1
                string sql = "SELECT * FROM Producto";
                dataGridView1.DataSource = consult.consulta(sql);
                dataGridView1.Refresh();

                //Carga el nombre completo en el comboBox1
                string sql3 = "select id_producto, nombreProd from Producto";
                comboBox1.DisplayMember = "nombreProd";
                comboBox1.ValueMember = "id_producto";
                comboBox1.DataSource = consult.consulta(sql3);

            ///Eliminar
                //Carga todos los datos de la tabla producto en el dataGridView1
                string sql4 = "SELECT * FROM Producto";
                dataGridView2.DataSource = consult.consulta(sql4);
                dataGridView2.Refresh();

                //Muestra los nombre de los pacientes en el comboBox
                string sql5 = "select id_producto, nombreProd from Producto";
                comboBox3.DisplayMember = "nombreProd";
                comboBox3.ValueMember = "id_producto";
                comboBox3.DataSource = consult.consulta(sql5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && richTextBox1.Text != "" && numericUpDown1.Value > 1)
            {
                string nombre = textBox1.Text;
                string descripcion = richTextBox1.Text;
                string cantidad = numericUpDown1.Value.ToString();

                string sql = "INSERT INTO Producto VALUES ('" + nombre + "','" + descripcion + "','" + cantidad + "')";

                consult.ejecutarComando(sql);

                cargar();
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            if (comboBox2.SelectedIndex != -1)
            {
                string dNombre = comboBox2.SelectedValue.ToString();

                string sql = "SELECT * FROM Producto WHERE id_producto = " + dNombre + "";

                DataTable tabla = consult.consulta(sql);

                richTextBox2.Text = tabla.Rows[0][2].ToString();
                numericUpDown2.Value = (int)tabla.Rows[0][3];
            }
            else
            {
                MessageBox.Show("Seleccione el producto a actualizar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text != "" && numericUpDown2.Value > 1 && comboBox2.SelectedIndex != -1)
            {
                string descrip = richTextBox2.Text;
                string cant = numericUpDown2.Value.ToString();
                string dNombre = comboBox2.SelectedValue.ToString();

                string sql = "UPDATE Producto SET descripcionProd = '" + descrip + "', cantidadProd = '" + cant + "' WHERE id_producto = '" + dNombre + "'";
                consult.ejecutarComando(sql);

                cargar();
                limpiar2();
            }
            else
            {
                MessageBox.Show("Todos los campos tienen que estar llenos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar2();
        }

        private void limpiar2()
        {
            richTextBox2.Text = "";
            numericUpDown2.Value = 0;
            comboBox2.SelectedIndex = -1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string dNombre = comboBox1.SelectedValue.ToString();

                string sql = "SELECT * FROM Producto WHERE id_producto = '" + dNombre + "'";
                dataGridView1.DataSource = consult.consulta(sql);
                dataGridView1.Refresh();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Producto WHERE cantidadProd = (SELECT MAX(cantidadProd) FROM Producto)";
            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Producto WHERE cantidadProd = (SELECT MIN(cantidadProd) FROM Producto)";
            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Producto";
            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                string Eliminar = comboBox3.Text;

                string sql = "DELETE FROM Producto WHERE nombreProd = '" + Eliminar + "'";
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

        private void button11_Click(object sender, EventArgs e)
        {
            limpiar3();
        }

        private void limpiar3()
        {
            comboBox3.SelectedIndex = -1;
        }
    }
}
