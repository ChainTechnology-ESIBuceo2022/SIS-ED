using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Principal : Form
    {
        private Principal_UsuarioEstandar estandar;
        private Principal_BackOffice backoffice;
        public Principal()
        {
            InitializeComponent();
            estandar = new Principal_UsuarioEstandar();
            backoffice = new Principal_BackOffice();
        }

        private void btnBackoffice_Click(object sender, EventArgs e)
        {
            this.Hide();
            backoffice.ShowDialog();
            this.Show();
        }

        private void btnAppEstandar_Click(object sender, EventArgs e)
        {
            this.Hide();
            estandar.ShowDialog();
            this.Show();
        }
    }
}
