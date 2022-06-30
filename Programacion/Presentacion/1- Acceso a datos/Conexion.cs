using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

    public class Conexion
    {

    private readonly MySqlConnection conexion;
        public Conexion()
        {
        try
        {
            conexion = new MySqlConnection("Server=localhost;username=root;password=;database=ChainTechnology");
            conexion.Open();
        }
        catch (Exception)
        {
            MessageBox.Show("No se pudo realizar la conexion a la base de datos");
            throw;
        }  
        }

        public MySqlConnection GetConexion()
        {
            return conexion;
        }

    }
