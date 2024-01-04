using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoFinal_DAE
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string direccion = abrir.FileName;

                Process proceso = new Process();
                proceso.StartInfo.FileName = direccion;
                proceso.Start();
            }

            
        }
    }
}
