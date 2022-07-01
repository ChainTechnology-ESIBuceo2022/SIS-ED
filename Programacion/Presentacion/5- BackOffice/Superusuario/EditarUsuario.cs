using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.BackOffice
{
    public partial class EditarUsuario : Form
    {
        private List<string> datosUsuario;
        public EditarUsuario()
        {
            InitializeComponent();
            datosUsuario = new List<string>();
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

         private void btnBuscar_Click(object sender, EventArgs e)
         {
            datosUsuario = Controlador.obtenerDatosUsuario(txtUsuario.Text);
            if (datosUsuario[0] == "false")
            {
                MessageBox.Show("Usuario no encontrado");
            }
            else
            {
                txtNuevoNombre_u.Text = datosUsuario[1];
                txtNuevoNombre.Text = datosUsuario[2];
                txtNuevoApellido.Text = datosUsuario[3];
                txtNuevoEmail.Text = datosUsuario[5];
                txtNuevaContraseña.Text = datosUsuario[6];
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (Controlador.editarUsuario(txtUsuario.Text, txtNuevoNombre_u.Text, txtNuevoNombre.Text, txtNuevoApellido.Text,
            txtNuevoEmail.Text, txtNuevaContraseña.Text) == true)
            {
                MessageBox.Show("Datos actualizados correctamente");

            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar la informacion, intente nuevamente");
            }

           }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
