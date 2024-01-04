using ProyectoFinal_DAE.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_DAE
{
    public partial class Login : Form
    {
        ConsultaBD consult = new ConsultaBD();
        Encriptar encrip = new Encriptar();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        //Codigo del boton de cerrar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Código del boton que permite logearse
        private void button3_Click(object sender, EventArgs e)
        {
            //varias que guardan los datos del usuario y la contraseña
            string usuario = textBox1.Text;
            string contraseña = encrip.encriptar(textBox2.Text,"Trabajo Final");

            ///Evalua si los campos de contraseña y usuario no estan vacios
            if (usuario.Length > 0 && contraseña.Length > 0)
            {
                //variable que contiene el codigo sql para realizar la consulta
                string sql = "SELECT usuario, contraseña, cargoEmp, estadoEmp  FROM Empleado WHERE usuario = '" + usuario + "' and contraseña = '" + contraseña + "' and estadoEmp = 'Activo'";

                //Variable que guarda el resultado de obtenido de la consulta en base de datos
                DataTable lector = consult.consulta(sql);

                if (lector.Rows.Count == 1)
                {

                    /*Este código permite cerrar este formulario y llevarnos al menú de inicio*/
                    this.Hide();
                    ///Evalua si el usuario es del tipo dueño
                    if (lector.Rows[0][2].ToString() == "Dueño")
                    {
                        PrincipalDueño pd = new PrincipalDueño();
                        pd.ShowDialog();
                    }
                    ///Evalua si el usuario es del tipo doctor
                    else if (lector.Rows[0][2].ToString() == "Doctor")
                    {
                        PrincipalDoctor pdc = new PrincipalDoctor();
                        pdc.ShowDialog();
                    }
                    ///Evalua si el usuario es del tipo secretaria
                    else if (lector.Rows[0][2].ToString() == "Secretaria")
                    {
                        Principal ventana = new Principal();
                        ventana.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al iniciar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un usuario y una contraseña","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }
    }
}
