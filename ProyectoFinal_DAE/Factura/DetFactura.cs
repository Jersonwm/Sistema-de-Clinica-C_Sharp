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

namespace ProyectoFinal_DAE.Factura
{
    public partial class DetFactura : Form
    {
        ConsultaBD consult = new ConsultaBD();

        public DetFactura()
        {
            InitializeComponent();
        }
        string idf = "";
        private void DetFactura_Load(object sender, EventArgs e)
        {
            //Toma el id de cita
            string sql = "select distinct top 1 id_factura from Factura order by id_factura desc";
            DataTable id = new DataTable();
            id = consult.consulta(sql);
            idf = Convert.ToString((int)id.Rows[0][0]);


            //Carga el nombre en el comboBox1
            string sql2 = "select id_servicio, nombreServ from Servicio";
            comboBox4.DisplayMember = "nombreServ";
            comboBox4.ValueMember = "id_servicio";
            comboBox4.DataSource = consult.consulta(sql2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string producto = comboBox4.SelectedValue.ToString();
            string cantidad = numericUpDown1.Value.ToString();

            string sql = "insert into Detalle_Factura values("+cantidad+","+ idf + "," + producto + ")";
            consult.ejecutarComando(sql);

            agregarP();
        }

        private void agregarP()
        {
            string sql = "SELECT f.id_factura, s.nombreServ, dc.cantidad FROM Detalle_Factura dc" +
                " inner join Factura f on f.id_factura = dc.id_Factura" +
                " inner join Servicio s on s.id_servicio = dc.id_Servicio" +
                " where f.id_factura =" + idf;
            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
