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
    public partial class DetServicio : Form
    {
        ConsultaBD consult = new ConsultaBD();
        public DetServicio()
        {
            InitializeComponent();
        }

        string idC = "";
        private void DetServicio_Load(object sender, EventArgs e)
        {
            //Carga el nombre en el comboBox1
            string sql2 = "select id_producto, nombreProd from Producto";
            comboBox1.DisplayMember = "nombreProd";
            comboBox1.ValueMember = "id_producto";
            comboBox1.DataSource = consult.consulta(sql2);

            //Toma el id de servicio
            string sql = "select distinct top 1 id_servicio from Servicio order by id_servicio desc";
            DataTable id = new DataTable();
            id = consult.consulta(sql);
            idC = id.Rows[0][0].ToString();

            cargar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string producto = comboBox1.SelectedValue.ToString();
            string sql = "insert into Detalle_Servicio values(" + idC + "," + producto + ")";
            consult.ejecutarComando(sql);

            cargar();
        }

        private void cargar()
        {
            //Imprime los dato en el dataGridview
            string sql = "select * from Detalle_Servicio";
            dataGridView1.DataSource = consult.ejecutarComando(sql);
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
