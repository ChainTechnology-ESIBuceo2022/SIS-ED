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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Controlador.eliminarUsuario(dataUsuarios.CurrentCell.OwningRow.Cells[0].Value.ToString());
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

        private void Principal_BackOffice_Load(object sender, EventArgs e)
        {

        }
    }
}
