using Inscripciones.Windows.Model.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscripciones.Windows
{
    public partial class HashPassword : Form
    {
        public HashPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = txtInput.Text;

            if (string.IsNullOrEmpty(text))
            {
                txtResult.Clear();
                MessageBox.Show("Debe introducir un texto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return;
            }

            var result = SecurityService.Hash(text);

            txtResult.Text = result;
        }
    }
}
