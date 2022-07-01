using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.BackOffice
{
    public partial class AgregarUsuario : Form
    {
        
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // añadir un usuario
        private void btnAddUser_Click(object sender, EventArgs e)
        {

            string selected = "";
            // se verifica si hay algun rol seleccionado, en ese caso se ejecuta el ingreso del usuario
            // de lo contrario aparece un mensaje detallando que se debe ingresar un rol
            if (chkListBoxRol.CheckedItems.Count != 0)
            {
                // se itera en cada item del checklist chkListRol, si está seleccionado se asigna a la variable selected
                for (int x = 0; x < chkListBoxRol.CheckedItems.Count; x++)
                {
                    selected = chkListBoxRol.CheckedItems[x].ToString();
                }
                if (Controlador.agregarUsuario(txtUser.Text, txtName.Text, txtLastName.Text, selected, txtEmail.Text, txtPassword.Text) == true)
                {
                    MessageBox.Show("Ingresado correctamente");
                }
                else
                {
                    MessageBox.Show("Nombre de usuario en uso");
                }
            } else
            {
                MessageBox.Show("Debe especificar un rol");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkListBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

            // se verifica si hay un rol seleccionado, en tal caso al seleccionar uno diferente el anterior seleccionado
            // se desmarca, imposibilitando la asignacion de mas de un rol a un mismo usuario
            int iSelectedIndex = chkListBoxRol.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < chkListBoxRol.Items.Count; iIndex++)
                chkListBoxRol.SetItemCheckState(iIndex, CheckState.Unchecked);
            chkListBoxRol.SetItemCheckState(iSelectedIndex, CheckState.Checked);
        }
    }
}
