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



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog busqueda = new OpenFileDialog();
            busqueda.Filter = "Image Files (*.png *.jpg *.bmp) |*.png; *.jpg; *.bmp|All Files(*.*) |*.*";
            if (busqueda.ShowDialog() == DialogResult.OK)
            {
                txtNombreArchivo.Text= Path.GetFileName(busqueda.FileName);
                txtDirectorioOrigen.Text = busqueda.FileName;
                pteImagen.Image = new Bitmap(busqueda.FileName);
            }
        }

        private void btnAddBanner_Click(object sender, EventArgs e)
        {
            var directorio = Path.Combine(Environment.CurrentDirectory, Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName);
            directorio = Path.Combine(directorio, "00- Recursos/");
            File.Copy(txtDirectorioOrigen.Text, Path.Combine(directorio, txtNombreArchivo.Text), true); 
        }
           
    }
}
