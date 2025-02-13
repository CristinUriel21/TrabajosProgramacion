using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_03
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtradio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnperimetro_Click(object sender, EventArgs e)
        {
            Double ResultadoPe;
            Double Pi = 3.1416;

            ResultadoPe = 2 * Pi * Convert.ToDouble(txtradio.Text);
            resultadop.Text= ResultadoPe.ToString();


        }

        private void btnarea_Click(object sender, EventArgs e)
        {
            Double ResultadoA;
            Double pi = 3.1416;

            ResultadoA = Math.Pow(Convert.ToDouble(txtradio.Text), 2) * pi;
            resultador.Text= ResultadoA.ToString();
        }

        private void resultador_Click(object sender, EventArgs e)
        {

        }

        private void resultadop_Click(object sender, EventArgs e)
        {

        }
    }
}
