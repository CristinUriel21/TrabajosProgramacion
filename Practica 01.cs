using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_01
{
    public partial class Form1 : Form
    {
        private object  vResultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(num1.Text) * Convert.ToInt32(num2.Text);
            lblResult.Text = vResultado.ToString();
            lblsigno.Text = "X";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnresta_Click(object sender, EventArgs e)
        {

            vResultado = Convert.ToInt32(num1.Text) - Convert.ToInt32(num2.Text);
            lblResult.Text = vResultado.ToString();
            lblsigno.Text = "-";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {

            vResultado = Convert.ToInt32(num1.Text) + Convert.ToInt32(num2.Text);
            lblResult.Text = vResultado.ToString();
            lblsigno.Text = "+";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            lblResult.Text = "";
            lblsigno.Text = "";
        }

        private void btndivi_Click(object sender, EventArgs e)
        {

            vResultado = Convert.ToInt32(num1.Text) / Convert.ToInt32(num2.Text);
            lblResult.Text = vResultado.ToString();
            lblsigno.Text = "/";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblsigno_Click(object sender, EventArgs e)
        {

        }
    }
}
