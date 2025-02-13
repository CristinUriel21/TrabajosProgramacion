using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_2
{
    public partial class Form1 : Form
    {
        int resultadoc;
        int resultadof;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            resultadoc = Convert.ToInt32(celsius.Text) * 9 / 5 + 32;
            btnresultado.Text = resultadoc.ToString();

        }

        private void celsius_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnresultado_Click(object sender, EventArgs e)
        {

        }

        private void btnconvert2_Click(object sender, EventArgs e)
        {
            resultadof = Convert.ToInt32(farenheit.Text) - 32 * 5 / 9;
            lblresultado.Text = resultadof.ToString();
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }
    }
}
