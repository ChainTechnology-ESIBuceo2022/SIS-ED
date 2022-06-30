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

        private void btnAddUser_Click(object sender, EventArgs e)
        {           
            string selected = "";
            if(chkListBoxRol.CheckedItems.Count != 0)
            {
                for (int x = 0; x < chkListBoxRol.CheckedItems.Count; x++)
                {
                    selected = selected + chkListBoxRol.CheckedItems[x];
                }
            }
            if (Controlador.agregarUsuario(txtUser.Text, txtName.Text, txtLastName.Text, selected, txtEmail.Text, txtPassword.Text) == true) { 
                MessageBox.Show("Ingresado correctamente");
            } else
            {
                MessageBox.Show("Nombre de usuario en uso");            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkListBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectedIndex = chkListBoxRol.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < chkListBoxRol.Items.Count; iIndex++)
                chkListBoxRol.SetItemCheckState(iIndex, CheckState.Unchecked);
            chkListBoxRol.SetItemCheckState(iSelectedIndex, CheckState.Checked);
        }

        private void btnEliminarTexto_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            chkListBoxRol.Text = "";
        }
    }
}
