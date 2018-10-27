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
    public partial class frmListadoPersonas : Form
    {
        public frmListadoPersonas()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            Refrescar();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        void Refrescar()
        {
            var personas = PersonaService.GetAllPersonas();
            dataGridView1.DataSource = personas;

            var escuelas = CommonService.GetAllEscuelas();

            Escuela.DataSource = escuelas;
            Escuela.DisplayMember = "Nombre";
            Escuela.ValueMember = "Id";
        }
    }
}
