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
    public partial class MdiParent : Form
    {
        public MdiParent()
        {
            InitializeComponent();

            this.FormClosed += MdiParent_FormClosed;
        }

        private void MdiParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void estudioantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEstudiantes frm = new frmRegistroEstudiantes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listaEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm =  new frmListadoPersonas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void escuelasEntityToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            frmEscuelasEntityFramework frm = new frmEscuelasEntityFramework();
            frm.MdiParent = this;

            frm.Show();
        }
    }
}
