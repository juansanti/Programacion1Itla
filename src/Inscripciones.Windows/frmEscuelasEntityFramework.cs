using Inscripciones.Windows.Model.Context;
using Inscripciones.Windows.Model.Entities;
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
    public partial class frmEscuelasEntityFramework : Form
    {
        public InscripcionesContext db { get; set; }
        public List<Escuela> Escuelas { get; set; }
        public bool Editando { get; set; }

        public frmEscuelasEntityFramework()
        {
            InitializeComponent();

            db = new InscripcionesContext();
            Editando = false;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           this.Escuelas = db.Escuelas.ToList();

            dataGridView1.DataSource = this.Escuelas;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Lambda Expressions

            if (Editando)
            {
                var id = int.Parse(txtId.Text);

                var escuela = Escuelas.Single(es => es.Id == id);

                escuela.Nombre = txtNombre.Text;

                db.SaveChanges();

            }
            else
            {
                var myEscuela = new Escuela();

                myEscuela.Nombre = txtNombre.Text;

                db.Escuelas.Add(myEscuela);

                db.SaveChanges();

                MessageBox.Show("Registro guardado satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button1_Click(null, null);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var escuela = Escuelas[e.RowIndex];

            txtId.Text = escuela.Id.ToString();
            txtNombre.Text = escuela.Nombre;

            Editando = true;

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
     
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var index = dataGridView1.SelectedRows[0].Index;

                var escuela = Escuelas[index];

                db.Escuelas.Remove(escuela);

                MessageBox.Show("Escuela eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
