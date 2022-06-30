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

    public static bool editarUsuario(String nombre_u, String nuevoNombre_u, String nuevoNombre,
        String nuevoApellido, String nuevoEmail, String nuevaContraseña)
    {
       return sentencia.editarUsuario(nombre_u, nuevoNombre_u, nuevoNombre, nuevoApellido, nuevoEmail, nuevaContraseña);
        
    }

    public static bool eliminarUsuario(String id_u)
    {
        tabla.Clear();
        sentencia.eliminarUsuario(id_u);
        
        return true;
    }

    public static DataTable obtenerListaUsuarios()
    {
        tabla.Clear();
        consulta.obtenerListaUsuarios().Fill(tabla);
        return tabla;
    }


}
