using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02
{
    public partial class Form1 : Form
    {
        int vIndice;
       
        public Form1()
        {
            InitializeComponent();
        

            dgvDatos.Columns.Add("Nombre", "Nombre");
            dgvDatos.Columns.Add("Apellido", "Apellido");
            dgvDatos.Columns.Add("Pais", "Pais");

            cbboxpais.Items.Add("Mexico");
            cbboxpais.Items.Add("España");
            cbboxpais.Items.Add("Canada");
            cbboxpais.Items.Add("Japon");
            cbboxpais.Items.Add("Argentina");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbboxpais_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vSeleccion;
            vSeleccion = Convert.ToString(cbboxpais.Text);
            int vIndice = dgvDatos.Rows.Add();
            dgvDatos.Rows[vIndice].Cells[0].Value = txtname.Text;
            dgvDatos.Rows[vIndice].Cells[1].Value = txtlastname.Text;
            dgvDatos.Rows[vIndice].Cells[2].Value = vSeleccion;

            txtname.Text = "";
            txtlastname.Text = "";
            cbboxpais.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(vIndice !=-1)
            {
                dgvDatos.Rows.RemoveAt(vIndice);
            }
            else
            {
                MessageBox.Show("Selected Item Incorrect");
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            vIndice =e.RowIndex;
        }
    }
}
