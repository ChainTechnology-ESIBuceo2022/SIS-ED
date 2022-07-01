using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Presentacion.BackOffice
{
    public partial class AñadirImagen : Form
    {
        public AñadirImagen()
        {
            InitializeComponent();

            pteImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal_BackOffice principalBO = new Principal_BackOffice();
            principalBO.Show();
            this.Hide();
        }


        // se agrega una imagen
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog busqueda = new OpenFileDialog();  // se despliega un ventana para buscar la imagen
            busqueda.Filter = "Image Files (*.png *.jpg *.bmp) |*.png; *.jpg; *.bmp|All Files(*.*) |*.*";  // se defien los tipos de archivos validos 
            if (busqueda.ShowDialog() == DialogResult.OK)  // en caso de el archivo seleccionado ser adecuado
            {
                txtNombreArchivo.Text= Path.GetFileName(busqueda.FileName);  // se obtiene el nombre del archivo y se asigna al text box
                txtDirectorioOrigen.Text = busqueda.FileName;  // se obtiene el directorio del archivo y se asigna a un label
                pteImagen.Image = new Bitmap(busqueda.FileName);  // se muestra en un picture box la imagen buscada
            }
        }

        // se ingresa la imagen buscada previamente al sistema
        private void btnAddBanner_Click(object sender, EventArgs e)
        {
            // se define la variable directorio, como la convinacion de dos directorios, el directorio relativo de ejecucion del programa
            // y a eso se le a grega la carpeta "00- Recursos"
            // luego se copia el archivo, combinando el directorio obtenido antes y agregando al final el nombre
            // del archivo que asignaremos a la imagen en el sistema
            var directorio = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            directorio = Path.Combine(directorio, "00- Recursos/");
            File.Copy(txtDirectorioOrigen.Text, Path.Combine(directorio, txtNombreArchivo.Text), true); 
        }
           
    }
}
