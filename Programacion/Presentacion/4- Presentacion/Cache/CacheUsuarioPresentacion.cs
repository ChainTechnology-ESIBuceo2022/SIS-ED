using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// clase estatica la cual sirve para, en el entorno del usuario publico
// poder almacenar la informacion en caso de logueare correctamente
// la clase es estatica ya que solo se necesita una instancia de esta ejecutandose
    public static class CacheUsuarioPresentacion
    {
      
        public static bool existe { get; set; }
        public static string id_usuario { get; set; }
        public static string nombre_u { get; set; }
        public static string nombre { get; set; }
        public static string apellido { get; set; }
        public static string rol { get; set; }
        public static string email { get; set; }
        public static string contraseña { get; set; }
    }
