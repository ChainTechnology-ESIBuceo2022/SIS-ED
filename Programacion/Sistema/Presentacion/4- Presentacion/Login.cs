using Newtonsoft.Json;
using Proyecto._2__Logica.Datos;
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
    public partial class Login : Form
    {
        APILogin apiLogin;

        private List<string> datosUsuario;
        public Login()
        {
            InitializeComponent();
            apiLogin = new APILogin();
            datosUsuario = new List<string>();
        }

        // se obtiene una lista de string con la informacion de inicio de sesion en base a los parametros ingresados en el formulario
        // luego se deserializa, si el primer elemento de la lista es "false" significa que el login no fue correcto por fallo de credenciales
        // en caso contrario, el login fue correcto y se asigna cada dato de la lista de string a la clas estatica CacheUsuarioPersistencia
        // de esta manera se almacena la informacion del usuario
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
    }
}
