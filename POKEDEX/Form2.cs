using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace POKEDEX
{
    public partial class Form2 : Form
    {
        private int registroActual = 0;
        private DataTable datos = new DataTable();
        private List<string> imagenes = new List<string>(); // Lista para almacenar las rutas de las imágenes
        private int imagenActual = 0; // Índice para controlar la imagen actual
        private string rutaImagenes = @"C:\\Users\\alexi\\OneDrive\\Imágenes\\VISUAL STUDIO\\images"; // Ruta de la carpeta de imágenes


        public Form2()
        {
            InitializeComponent();
            CargarDatos();
            CargarImagenes(); // Llamada para cargar imágenes al iniciar
        }
        private void CargarDatos()
        {
            SqlConnection conexion = new SqlConnection(@"server=CRISTIANRH\SQLEXPRESS; database=Pokemon; INTEGRATED SECURITY=true");
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT nDexNa,Nombre,Descripcion,Habilidad1,Habilidad2,Habilidadoculta,Tipo1,Tipo2 FROM pokemon", conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void MostrarRegistro()
        {
            if (datos.Rows.Count > 0 && registroActual < datos.Rows.Count)
            {
                DataRow fila = datos.Rows[registroActual];
                lbldatos.Text = $"nDexNa: {fila["nDexNa:"]}\nNombre: {fila["Nombre"]}\nDescripcion: {fila["Descripcion"]}\nHabilidad1: {fila["Habilidad1"]}\nHabilidad2: {fila["Habilidad2"]}\nHabilidadoculta: {fila["Habilidadoculta"]}\nTipo1: {fila["Tipo1"]}\nTipo2: {fila["Tipo2"]}";
            }
            else
            {
                MessageBox.Show("No hay más registros.");
            }
        }
        private void CargarImagenes()
        {
            // Verifica si la carpeta de imágenes existe
            if (Directory.Exists(rutaImagenes))
            {
                // Obtiene todas las imágenes con extensión .jpg y .png
                imagenes = Directory.GetFiles(rutaImagenes, "*.jpg").ToList();
                imagenes.AddRange(Directory.GetFiles(rutaImagenes, "*.png"));
                imagenes.AddRange(Directory.GetFiles(rutaImagenes, "*.gif"));
            }
        }

        private void MostrarImagen()

        {
            // Verifica si hay imágenes en la lista y muestra la imagen actual
            if (imagenes.Count > 1 && imagenActual < imagenes.Count)
            {
                pictureBox2.Image = Image.FromFile(imagenes[imagenActual]);
            }

            else
            {
                MessageBox.Show("No hay más imágenes.");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              {
                if (registroActual < datos.Rows.Count - 1)
                {
                    registroActual++;
                    MostrarRegistro();
                }
                else
                {
                    MessageBox.Show("No hay más registros.");
                }

                // Verifica si hay imágenes en la lista antes de mostrar
                if (imagenes.Count == 0 && imagenActual > 0)
                {
                    MessageBox.Show("No se encontraron imágenes en la carpeta.");
                    return;
                }
                if (imagenes.Count > 0) // Si hay imágenes disponibles
                {
                    // 🔥 Cambia la imagen en el mismo clic SIN NECESIDAD DE UN SEGUNDO CLIC
                    imagenActual = registroActual % imagenes.Count; // Sincroniza la imagen con el registro actual
                    MostrarImagen(); // Muestra la imagen correspondiente
                }
            }

        

    }

        private void btnregreso_Click(object sender, EventArgs e)
        {
            if (registroActual > 0)
            {
                registroActual--;
                MostrarRegistro();
            }
            else
            {
                MessageBox.Show("Este es el primer registro.");
            }

            // Regresa a la imagen anterior si no estamos en la primera
            if (imagenes.Count > 0 )
            {
                imagenActual--; // Retrocede a la imagen anterior
                MostrarImagen(); // Muestra la imagen actual
            }
            else
            {
                MessageBox.Show("Ya estás en la primera imagen.");
            }
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            MostrarRegistro();
            // Muestra la primera imagen al presionar el botón
            if (imagenes.Count > 0)
            {
                imagenActual = 0; // Establece el índice de la primera imagen
                MostrarImagen();  // Muestra la primera imagen
            }
            else
            {
                MessageBox.Show("No se encontraron imágenes en la carpeta.");
            }
        
    }

        private void lbldatos_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
