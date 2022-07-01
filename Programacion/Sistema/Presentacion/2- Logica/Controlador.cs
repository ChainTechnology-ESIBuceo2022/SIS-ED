using Newtonsoft.Json;
using Presentacion._1__Acceso_a_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using Proyecto._2__Logica.Datos;

public static class Controlador
    {
        private static Consultas consulta;
        private static Sentencias sentencia;

        private static CacheUsuario cacheUsuario;
        private static List<string> listaDatosUsuario;
        private static DataTable tabla; 
        static Controlador(){
            consulta = new Consultas();
            sentencia = new Sentencias();
            tabla = new DataTable();
            listaDatosUsuario = new List<string>();
    }

    // Se obtiene el resultado de la consulta del login en base al nombre de usuario y la contraseña.
    // Se transforma de MySqlDataAdapter a un DataTable, y se recorren sus elementos para asignarlos a cada variable
    // Luego de esto, se crea una nueva instancia de la clase CacheUsuario con todos estos datos
    // Por ultimo, se asignan estos datos de manera secuencial a una lista de strings, y esto sera el Return
    // de la funcion
    public static List<string> loginUsuario(String user, String pass)
    {
        tabla.Clear();
        listaDatosUsuario.Clear();
        consulta.loginUsuario(user, pass).Fill(tabla);
        if (!(tabla.Rows.Count == 0))
        {
            tabla.Clear();
            tabla.Dispose();
            consulta.obtenerDatosUnUsuario(user).Fill(tabla);

            var id_usuario = tabla.Rows[0].ItemArray[0].ToString();
            var nombre_u = tabla.Rows[0].ItemArray[1].ToString();
            var nombre = tabla.Rows[0].ItemArray[2].ToString();
            var apellido = tabla.Rows[0].ItemArray[3].ToString();
            var rol = tabla.Rows[0].ItemArray[4].ToString();
            var email = tabla.Rows[0].ItemArray[5].ToString();
            var contraseña = tabla.Rows[0].ItemArray[6].ToString();
            cacheUsuario = new CacheUsuario(id_usuario, nombre_u, nombre, apellido, rol, email, contraseña);

            for (int j = 0; j < tabla.Columns.Count; j++)
            {
                listaDatosUsuario.Add(tabla.Rows[0].ItemArray[j].ToString());
            }

        } else
        {
            cacheUsuario = new CacheUsuario(false);
            listaDatosUsuario.Add("false");
        }     
        
        return listaDatosUsuario;
    }

    // se utiliza desde el backoffice para obtener la informacion de un usuario a la hora de buscarlo por su nombre de usuario
    // esto ocurre en la inferfaz de edicion de usuario
    public static List<string> obtenerDatosUsuario(string nombre_u)
    {
        tabla.Clear();
        listaDatosUsuario.Clear();
        consulta.obtenerDatosUnUsuario(nombre_u).Fill(tabla);
        if (!(tabla.Rows.Count == 0))
        {
            for (int j = 0; j < tabla.Columns.Count; j++)
            {
                listaDatosUsuario.Add(tabla.Rows[0].ItemArray[j].ToString());
             }
        }
        else
        {
            listaDatosUsuario.Add("false");
        }
            return listaDatosUsuario;
    }

    // se ejecuta una sentencia para agregar un usuaro, devuelve true o false, desde la interfaz de backoffice de agregar un usuario
    public static bool agregarUsuario(String nombre_u, String nombre, String apellido, String rol, String email, String contraseña)
    {
        tabla.Clear();
        consulta.obtenerDatosUnUsuario(nombre_u).Fill(tabla);
        if ((tabla.Rows.Count == 0))
        {
            sentencia.agregarUsuario(nombre_u, nombre, apellido, rol, email, contraseña);
        }
        else
        {
            return false;
        }
        return true;
    }

    // se ejecuta una sentencia para editar la informacion de un usuario, devuelve true o false, desde la interfaz de backoffice de editar un usuario
    public static bool editarUsuario(String nombre_u, String nuevoNombre_u, String nuevoNombre,
        String nuevoApellido, String nuevoEmail, String nuevaContraseña)
    {
       return sentencia.editarUsuario(nombre_u, nuevoNombre_u, nuevoNombre, nuevoApellido, nuevoEmail, nuevaContraseña);
        
    }

    // se ejecuta una sentencia para eliminar un usuario, el metodo devuelve true o false
    public static bool eliminarUsuario(String id_u)
    {
        tabla.Clear();
        return sentencia.eliminarUsuario(id_u);
        
    }

    // se llama a esta funcion cuando el formulario de backoffice principal es instanciado
    // por defecto, se muestra una lista con todos los usuarios de la base de datos
    public static DataTable obtenerListaUsuarios()
    {
        tabla.Clear();
        consulta.obtenerListaUsuarios().Fill(tabla);
        return tabla;
    }


}
