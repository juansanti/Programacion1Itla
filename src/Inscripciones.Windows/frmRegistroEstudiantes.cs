using Inscripciones.Windows.Model.Entities;
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
    public partial class frmRegistroEstudiantes : Form
    {
        public List<Escuela> Escuelas { get; set; }

        public frmRegistroEstudiantes()
        {
            InitializeComponent();

            Escuelas = CommonService.GetAllEscuelas();

            lbEscuela.DataSource = Escuelas;
        }

        private void frmRegistroEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Seguro que desea proceder?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (response == DialogResult.Yes)
            {
                var persona = new Persona();

                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;

                persona.Sexo = radioButtonFemenino.Checked ? "F" : "M";

                persona.EscuelaId = Convert.ToInt32(lbEscuela.SelectedValue);

                var rowAffected = PersonaService.InsertarPersona(persona);

                if (rowAffected > 0)
                {
                    MessageBox.Show("Persona Registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    //Limpiar();
                }
            }
        }

        private void Limpiar()
        {
         
        }
    }
}
