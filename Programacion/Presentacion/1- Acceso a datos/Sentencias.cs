using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Presentacion._1__Acceso_a_datos
{
    public class Sentencias : Conexion
    {
        MySqlCommand sentencia;
        public void agregarUsuario(String nombre_u, String nombre, String apellido, String rol, String email, String contraseña)
        {
            sentencia = new MySqlCommand("INSERT INTO `Usuarios`(`nombre_u`, `nombre`, `apellido`, `rol`, `email`, `contraseña`) " +
                "VALUES (@nombre_u,@nombre,@apellido,@rol,@email,@contraseña)", GetConexion());
            sentencia.Parameters.Add("@nombre_u", MySqlDbType.VarChar).Value = nombre_u;
            sentencia.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombre;
            sentencia.Parameters.Add("@apellido", MySqlDbType.VarChar).Value = apellido;
            sentencia.Parameters.Add("@rol", MySqlDbType.VarChar).Value = rol;
            sentencia.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            sentencia.Parameters.Add("@contraseña", MySqlDbType.VarChar).Value = contraseña;
            sentencia.ExecuteNonQuery();       
        }

            public bool editarUsuario(String nombre_u, String nuevoNombre_u, String nuevoNombre,
                 String nuevoApellido, String nuevoEmail, String nuevaContraseña)
            {
            try
            {
                sentencia = new MySqlCommand("UPDATE `Usuarios` SET nombre_u = @nuevoNombre_u, nombre=@nuevoNombre," +
                               "apellido=@nuevoApellido, email=@nuevoEmail, contraseña=@nuevaContraseña " +
                               "WHERE (nombre_u=@nombre_u)", GetConexion());
                sentencia.Parameters.Add("@nombre_u", MySqlDbType.VarChar).Value = nombre_u;
                sentencia.Parameters.Add("@nuevoNombre_u", MySqlDbType.VarChar).Value = nuevoNombre_u;
                sentencia.Parameters.Add("@nuevoNombre", MySqlDbType.VarChar).Value = nuevoNombre;
                sentencia.Parameters.Add("@nuevoApellido", MySqlDbType.VarChar).Value = nuevoApellido;
                sentencia.Parameters.Add("@nuevoEmail", MySqlDbType.VarChar).Value = nuevoEmail;
                sentencia.Parameters.Add("@nuevaContraseña", MySqlDbType.VarChar).Value = nuevaContraseña;
                sentencia.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
           

            }
        public bool eliminarUsuario(String id_u)
        {

            sentencia = new MySqlCommand("DELETE FROM `Usuarios` WHERE (id_usuario=@id_u)", GetConexion());
            sentencia.Parameters.Add("@id_u", MySqlDbType.VarChar).Value = id_u;
            sentencia.ExecuteNonQuery();

            return true;
        }
            
        }

  
    }



