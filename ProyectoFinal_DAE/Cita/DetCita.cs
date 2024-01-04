using ProyectoFinal_DAE.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_DAE.Cita
{
    public partial class DetCita : Form
    {
        ConsultaBD consult = new ConsultaBD();
        public DetCita()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string idC = "";
        private void DetCita_Load(object sender, EventArgs e)
        {
            //Toma el id de cita
            string sql = "select distinct top 1 id_cita from cita order by id_cita desc";
            DataTable id = new DataTable();
            id = consult.consulta(sql);
            idC = id.Rows[0][0].ToString();

            //Carga el nombre del servicio en el comboBox1
            string sql2 = "select id_servicio, nombreServ from Servicio";
            comboBox1.DisplayMember = "nombreServ";
            comboBox1.ValueMember = "id_servicio";
            comboBox1.DataSource = consult.consulta(sql2);

            agregarP();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string producto = comboBox1.SelectedValue.ToString();
            string sql = "insert into Detalle_Cita values(" + idC + "," + producto + ")";
            consult.ejecutarComando(sql);

            agregarP();
        }

        private void agregarP()
        {
            string sql = "SELECT dc.id_Cita,s.nombreServ  FROM Detalle_Cita dc " +
                "inner join Servicio s on s.id_servicio = dc.id_Servicio where id_Cita = "+idC;
            dataGridView1.DataSource = consult.consulta(sql);
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
