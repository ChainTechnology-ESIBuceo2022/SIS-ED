using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal_UsuarioEstandar : Form
    {

        private Login login;
        public Principal_UsuarioEstandar()
        {
            InitializeComponent();
            login = new Login();
        }

        private void btnVerMas_MouseHover(object sender, EventArgs e)
        {
            btnVerMas.BackColor = Color.Black;
            btnVerMas.ForeColor = Color.White;
        }
             
        private void btnVerMas_MouseLeave(object sender, EventArgs e)
        {
            btnVerMas.BackColor = Color.White;
            btnVerMas.ForeColor = Color.Black;
        }

        // se muestra el formulario de login, y al finalizar este se retoma el formulario principal 
        // haciendo una comprobacion de si el login fue satisfactorio o no con actualizarInformacionUsuario()
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.ShowDialog();
            this.Show();            
            actualizarInformacionUsuario();
        }

        // se llama a este metodo para actualizar el formulario principal del usuario
        // si el atributo de CacheUsuarioPresentacion es true, significa que el logueo fue correcto
        // en ese caso, se desactiva la funcionalidad del boton de login del formulario, y se asignan
        // los valores de la clase estatica a diferentes labels de la inferfaz
        private void actualizarInformacionUsuario()
        {
            if (CacheUsuarioPresentacion.existe = true)
            {
                btnPerfil.Click -= btnPerfil_Click;
                btnPerfil.Text = "Nombre de usuario: " + CacheUsuarioPresentacion.id_usuario;
                lblNombreApellido.Text = "Nombre: " + CacheUsuarioPresentacion.nombre + " " + CacheUsuarioPresentacion.apellido;
                lblEmail.Text = "Correo electrónico:  " + CacheUsuarioPresentacion.email;                
            }
        }
    }
}
