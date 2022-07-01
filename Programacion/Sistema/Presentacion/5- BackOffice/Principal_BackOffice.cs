using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Presentacion.BackOffice;

namespace Presentacion
{
    public partial class Principal_BackOffice : Form
    {
        AgregarUsuario agregarUsuario;
        EditarUsuario editarUsuario;

        AñadirImagen añadirImagen;
                
        
        
        public DataTable tabla = new DataTable();
        private String celda;




        public Principal_BackOffice()
        {
            InitializeComponent();
            dataUsuarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMo‌​de.Fill);
            actualizarTabla();
            agregarUsuario = new AgregarUsuario();
            editarUsuario = new EditarUsuario();
            añadirImagen = new AñadirImagen();

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregarUsuario.ShowDialog();
            actualizarTabla();
            this.Show();
            
        }

        // se elimina un usuario en base a la celda seleccionada
        // en base a ella, se define el primer elemento de esa tupla, el cual siempre será el id del usuario
        // la eliminacion del usuario se ejecuta a traves del parametro id_usuario
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Controlador.eliminarUsuario(dataUsuarios.CurrentCell.OwningRow.Cells[0].Value.ToString()) == true)
            {
                MessageBox.Show("Usuario eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Hubo un error al eliminar el, intente nuevamente");
            }          
            actualizarTabla();
        }

        private void dataUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Text = "Eliminar Usuario con ID:  " + dataUsuarios.CurrentCell.OwningRow.Cells[0].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            editarUsuario.ShowDialog();
            actualizarTabla();
            this.Show();
        }

        private void btnAddbanner_Click(object sender, EventArgs e)
        {
            this.Hide();
            añadirImagen.ShowDialog();
            this.Show();
        }

        private void actualizarTabla() {       

            dataUsuarios.DataSource = Controlador.obtenerListaUsuarios();
        }

        private void lblAdministrador_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
