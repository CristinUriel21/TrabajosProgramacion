using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Practica_5
{
    public partial class Form1 : Form
    {
        int promedio;//Declaro la variable promedio en la cual ira la ecuacion para sacar el promedio de los 3 parciales
       
        string Estatus;//La variable estatus definira que dependiendo de la calificacion evaluara si les corresponde Exento,Ordinario,Extraordinario,o Especial
        
        public Form1()
        {
            InitializeComponent();
            //Esta parte de aqui es para crear las columnas donde iran el nombre del alumno,calificacion de los 3 parciales,promedio y estatus
            //Se ponen dos veces el nombre ya que uno es para lo que se mostrara en pantalla y el otro es con lo que se identifica en el codigo
            dgvDatos.Columns.Add("Alumno","Alumno");
            dgvDatos.Columns.Add("Parcial 1","Parcial 1");
            dgvDatos.Columns.Add("Parcial 2","Parcial 2");
            dgvDatos.Columns.Add("Parcail 3","Parcial 3");
            dgvDatos.Columns.Add("Promedio","Promedio");
            dgvDatos.Columns.Add("Estatus","Estatus");
        }



        private void txtalumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnevaluar_Click(object sender, EventArgs e)
        //en este if lo que se hace es que en dado case del que el nombre del alumno y las calificaciones esten en blanco mandara un messagebox
        {
            if (string.IsNullOrWhiteSpace(txtalumno.Text) ||
                string.IsNullOrWhiteSpace(txtp1.Text) ||
                string.IsNullOrWhiteSpace(txtp2.Text) ||
                string.IsNullOrWhiteSpace(txtp3.Text))
            {
                //este messagebox es el mostrado en dado caso que se cumpla la condicion del if anterior
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //en esta parte se hace la hace la ecuacion que le corresponde a promedio sumando los 3 calificaciones y dividiendola entre 3
            promedio = (Convert.ToInt32(txtp1.Text) + Convert.ToInt32(txtp2.Text) + Convert.ToInt32(txtp3.Text)) / 3;
            //esta parte es donde hago la creacion de todos los if y pongo condiciones a la variable promedio,que depende del valor ya sea mayor o igual es el estatus que les corresponde
            if (promedio >= 95)
            {
                Estatus = "Exento";
            }
            if (promedio >= 70 && promedio <= 94)
            {
                Estatus = "Ordinario";
            }
            if (promedio >= 50 && promedio <= 69)
            {
                Estatus = "Extraordinario";
            }
            if (promedio <= 49)
            {
                Estatus = "Especial";
            }
            //con la variable vIndice voy añadiendo nuevas filas
            //En esta parte de aqui voy creando celdas y les doy un valor a cada una en el caso de la primera seria el valor guardado en txtalumno.Text
            int vIndice = dgvDatos.Rows.Add();
            dgvDatos.Rows[vIndice].Cells[0].Value = txtalumno.Text;
            dgvDatos.Rows[vIndice].Cells[1].Value = Convert.ToInt32(txtp1.Text);
            dgvDatos.Rows[vIndice].Cells[2].Value = Convert.ToInt32(txtp2.Text);
            dgvDatos.Rows[vIndice].Cells[3].Value = Convert.ToInt32(txtp3.Text);
            dgvDatos.Rows[vIndice].Cells[4].Value = promedio;
            dgvDatos.Rows[vIndice].Cells[5].Value = Estatus;

        //Esta parte de aqui es para que cuando presione el boton llamado calcular automaticamente queden las cassilas en blanco
            txtalumno.Text = "";
            txtp1.Text = "";
            txtp2.Text = "";
            txtp3.Text = "";


        }

        private void txtp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtp3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }

