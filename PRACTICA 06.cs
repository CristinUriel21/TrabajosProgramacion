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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Login()
        {
            SqlConnection conexion = new SqlConnection(@"server=CRISTIANRH\SQLEXPRESS; database=MiLogin; INTEGRATED SECURITY=true"
);
            conexion.Open();
            SqlCommand cmd = new SqlCommand(" SELECT Username, pass FROM registro WHERE Username=@Username AND pass=@pass",
                conexion);
            cmd.Parameters.AddWithValue("@Username", txtusuario.Text.Trim());
            cmd.Parameters.AddWithValue("@pass", txtpassword.Text.Trim());

            SqlDataReader Lector = cmd.ExecuteReader();

            if (Lector.Read())
            {
                conexion.Close();
                MessageBox.Show("Login Exitoso");
                Form1 Index = new Form1();
                Index.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You've entered incorrect login details", "ERROR",
                MessageBoxButtons.OK);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }
    }
}
