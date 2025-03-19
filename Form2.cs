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

namespace LOGIN_Y_BASE_DE_DATOS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void funRegistro()
        {
            SqlConnection conexion = new SqlConnection(@"server=CRISTIANRH\SQLEXPRESS; database = MiLogin ;
INTEGRATED SECURITY = true");
            conexion.Open();
            string vConsultaSQL = "INSERT INTO registro (Username, pass) VALUES ('" +
            textuser.Text.Trim() + "', '" + textPassword.Text.Trim() + "')";
            SqlCommand cmdRegistro = new SqlCommand(vConsultaSQL, conexion);
            cmdRegistro.ExecuteNonQuery();
            conexion.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            funRegistro();
            if (txtConfirmPass.Text == textPassword.Text)
            {
                MessageBox.Show("You've signed a new user", "NEW REGISTER", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("You've entered incorrect login details", "ERROR", MessageBoxButtons.OK);
            }
        }

     
        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            funRegistro();
            if (textConfirmPass.Text == textPassword.Text)
            {
                MessageBox.Show("You've signed a new user", "NEW REGISTER", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("You've entered incorrect login details", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
    }

