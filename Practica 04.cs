using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_04
{
    public partial class enter : Form
    {
        public enter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text=="Admin" && txtpass.Text=="Pass")
            {
                Form formulario = new Form2();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Contraseña y Usuarios incorrectos");
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
