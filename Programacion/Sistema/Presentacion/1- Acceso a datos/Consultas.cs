using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

    public class Consultas : Conexion
    {

    MySqlDataAdapter consulta;
    string string_consulta;

    // las consultase se manejan con MySqlDataAdapter, y se define una variable string_consulta
    // para definir las mismas

    public Consultas()
        {
        consulta = new MySqlDataAdapter();
        string_consulta = "";
        }

    // valida si existe el usuario en base a un nombre y una contraseña
    // para proximas entregas, esta validacion se hará en base a roles y no se almacenará la contraseña en 
    // la base de datos
    public MySqlDataAdapter loginUsuario(String usuario, String contraseña)
        {
        try
        {
            string_consulta = "SELECT nombre_u FROM Usuarios WHERE nombre_u= '" + usuario + "' AND contraseña= '" + contraseña + "'";
            consulta = new MySqlDataAdapter(string_consulta, GetConexion());
            return consulta;
        }
        catch (Exception)
        {
            return consulta;
            throw;
        }
         

         }

    // se obtienen todos los datos de un usuario de la base de datos
    public MySqlDataAdapter obtenerDatosUnUsuario(String usuario)
    {
        try
        {
            string_consulta = "SELECT * FROM Usuarios WHERE nombre_u= '" + usuario + "'";
            consulta = new MySqlDataAdapter(string_consulta, GetConexion());
            return consulta;
        }
        catch (Exception)
        {
            return consulta;
            throw;
        }
    }

    // se obtienen todos los datos de todos los usuarios de la base de datos
    public MySqlDataAdapter obtenerListaUsuarios()
    {

        try
        {
            string_consulta = "SELECT * FROM Usuarios";
            consulta = new MySqlDataAdapter(string_consulta, GetConexion());
            return consulta;
        }
        catch (Exception)
        {
            return consulta;
            throw;
        }
    }

}
