using Inscripciones.Windows.Model.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscripciones.Windows
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            var login = txtUsuario.Text;
            var password = txtPassword.Text;

            var usuario = SecurityService.Login(login, password);

            if (usuario == null)
            {
                MessageBox.Show("Nombre de usuario y/o Contraseña inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MdiParent form = new MdiParent();
                this.Hide();
                form.Show();
                form.WindowState = FormWindowState.Maximized;
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
        
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                new HashPassword().ShowDialog();
            }
        }
    }
}
