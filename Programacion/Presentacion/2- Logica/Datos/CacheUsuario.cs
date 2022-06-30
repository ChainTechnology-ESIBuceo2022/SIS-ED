using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto._2__Logica.Datos
{
    public class CacheUsuario
    {
        public CacheUsuario(string id_usuario, string nombre_u, string nombre, string apellido, string rol, string email, string contraseña){
            existe = true;
            this.id_usuario = id_usuario;
            this.nombre_u = nombre_u;
            this.nombre = nombre;
            this.apellido = apellido;
            this.rol = rol;
            this.email = email;
            this.contraseña = contraseña;
        }
        
        public CacheUsuario(bool existe)
        {
            this.existe = existe;
        }
        private bool existe { get; set; }
        private string id_usuario { get; set; }
        private string nombre_u { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string rol { get; set; }
        private string email { get; set; }
        private string contraseña { get; set; }
    }
}
