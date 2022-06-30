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


       public Consultas()
        {
        consulta = new MySqlDataAdapter();
        string_consulta = "";
        }

        //valida si existe el usuario
        public MySqlDataAdapter loginUsuario(String usuario, String contraseña)
        {
          string_consulta = "SELECT nombre_u FROM Usuarios WHERE nombre_u= '" + usuario + "' AND contraseña= '" + contraseña + "'";
          consulta = new MySqlDataAdapter(string_consulta, GetConexion());
          return consulta;

         }
                

    public MySqlDataAdapter obtenerDatosUnUsuario(String usuario)
    {
        string_consulta = "SELECT * FROM Usuarios WHERE nombre_u= '" + usuario + "'";
        consulta = new MySqlDataAdapter(string_consulta, GetConexion());
        return consulta;
    }
        

    public MySqlDataAdapter obtenerListaUsuarios()
    {
        string_consulta = "SELECT * FROM Usuarios";
        consulta = new MySqlDataAdapter(string_consulta, GetConexion());
        return consulta; 
    }

}
