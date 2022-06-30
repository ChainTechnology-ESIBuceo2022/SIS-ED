using Newtonsoft.Json;
using Proyecto._2__Logica.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
            int wparam, int Iparam);
        APILogin apiLogin;

        private List<string> datosUsuario;
        public Login()
        {
            InitializeComponent();
            apiLogin = new APILogin();
            datosUsuario = new List<string>();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            datosUsuario = JsonConvert.DeserializeObject<List<String>>(apiLogin.loginUsuario(txtNombre.Text, txtContraseña.Text));
            if (datosUsuario[0] == "false")
            {
                MessageBox.Show("Credenciales incorrectas");
                CacheUsuarioPresentacion.existe = false;
            } else
            {
                CacheUsuarioPresentacion.existe = true;
                CacheUsuarioPresentacion.nombre_u = datosUsuario[0];
                CacheUsuarioPresentacion.id_usuario = datosUsuario[1];
                CacheUsuarioPresentacion.nombre = datosUsuario[2];
                CacheUsuarioPresentacion.apellido = datosUsuario[3];
                CacheUsuarioPresentacion.rol = datosUsuario[4];
                CacheUsuarioPresentacion.email = datosUsuario[5];
                CacheUsuarioPresentacion.contraseña = datosUsuario[6];

                this.Close();
                
            }
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text ==  "")
            {
                txtNombre.Text = "Usuario";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if(txtNombre.Text == "Usuario")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void btnAcceder_MouseHover(object sender, EventArgs e)
        {
            btnAcceder.BackColor = Color.Black;
        }
    }
}
