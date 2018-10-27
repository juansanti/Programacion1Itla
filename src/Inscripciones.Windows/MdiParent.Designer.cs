namespace Inscripciones.Windows
{
    partial class MdiParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudioantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otraMasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudioantesToolStripMenuItem,
            this.listaEstudiantesToolStripMenuItem,
            this.otraToolStripMenuItem,
            this.otraMasToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // estudioantesToolStripMenuItem
            // 
            this.estudioantesToolStripMenuItem.Name = "estudioantesToolStripMenuItem";
            this.estudioantesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estudioantesToolStripMenuItem.Text = "Estudiantes";
            this.estudioantesToolStripMenuItem.Click += new System.EventHandler(this.estudioantesToolStripMenuItem_Click);
            // 
            // listaEstudiantesToolStripMenuItem
            // 
            this.listaEstudiantesToolStripMenuItem.Name = "listaEstudiantesToolStripMenuItem";
            this.listaEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaEstudiantesToolStripMenuItem.Text = "Lista Estudiantes";
            this.listaEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.listaEstudiantesToolStripMenuItem_Click);
            // 
            // otraToolStripMenuItem
            // 
            this.otraToolStripMenuItem.Name = "otraToolStripMenuItem";
            this.otraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otraToolStripMenuItem.Text = "Otra";
            // 
            // otraMasToolStripMenuItem
            // 
            this.otraMasToolStripMenuItem.Name = "otraMasToolStripMenuItem";
            this.otraMasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otraMasToolStripMenuItem.Text = "Otra mas";
            // 
            // MdiParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiParent";
            this.Text = "Sistema de Inscripcion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudioantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otraMasToolStripMenuItem;
    }
}