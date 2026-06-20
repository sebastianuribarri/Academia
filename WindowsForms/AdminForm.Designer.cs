namespace WindowsForms
{
    partial class AdminForm
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
            menuStrip1 = new MenuStrip();
            personaToolStripMenuItem = new ToolStripMenuItem();
            administradoresToolStripMenuItem = new ToolStripMenuItem();
            AlumnosMenuOption = new ToolStripMenuItem();
            docentesToolStripMenuItem = new ToolStripMenuItem();
            planesToolStripMenuItem = new ToolStripMenuItem();
            especialidadesToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            MateriasMenuOption = new ToolStripMenuItem();
            dictadosToolStripMenuItem = new ToolStripMenuItem();
            comisionesToolStripMenuItem1 = new ToolStripMenuItem();
            comisionesToolStripMenuItem = new ToolStripMenuItem();
            comisionListado = new ToolStripMenuItem();
            comisionAgregar = new ToolStripMenuItem();
            cursoListado = new ToolStripMenuItem();
            cursoAgregar = new ToolStripMenuItem();
            cuentaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSessionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { personaToolStripMenuItem, administradoresToolStripMenuItem, AlumnosMenuOption, docentesToolStripMenuItem, planesToolStripMenuItem, especialidadesToolStripMenuItem, cursosToolStripMenuItem, MateriasMenuOption, dictadosToolStripMenuItem, comisionesToolStripMenuItem1, cuentaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1025, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // personaToolStripMenuItem
            // 
            personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            personaToolStripMenuItem.Size = new Size(75, 23);
            personaToolStripMenuItem.Text = "Personas";
            personaToolStripMenuItem.Click += personaToolStripMenuItem_Click;
            // 
            // administradoresToolStripMenuItem
            // 
            administradoresToolStripMenuItem.Name = "administradoresToolStripMenuItem";
            administradoresToolStripMenuItem.Size = new Size(121, 23);
            administradoresToolStripMenuItem.Text = "Administradores";
            administradoresToolStripMenuItem.Click += administradoresToolStripMenuItem_Click;
            // 
            // AlumnosMenuOption
            // 
            AlumnosMenuOption.Name = "AlumnosMenuOption";
            AlumnosMenuOption.Size = new Size(75, 23);
            AlumnosMenuOption.Text = "Alumnos";
            AlumnosMenuOption.Click += AlumnosMenuOption_Click;
            // 
            // docentesToolStripMenuItem
            // 
            docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            docentesToolStripMenuItem.Size = new Size(78, 23);
            docentesToolStripMenuItem.Text = "Docentes";
            docentesToolStripMenuItem.Click += docentesToolStripMenuItem_Click;
            // 
            // planesToolStripMenuItem
            // 
            planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            planesToolStripMenuItem.Size = new Size(60, 23);
            planesToolStripMenuItem.Text = "Planes";
            planesToolStripMenuItem.Click += planesToolStripMenuItem_Click;
            // 
            // especialidadesToolStripMenuItem
            // 
            especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            especialidadesToolStripMenuItem.Size = new Size(107, 23);
            especialidadesToolStripMenuItem.Text = "Especialidades";
            especialidadesToolStripMenuItem.Click += especialidadesToolStripMenuItem_Click;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(63, 23);
            cursosToolStripMenuItem.Text = "Cursos";
            cursosToolStripMenuItem.Click += cursosToolStripMenuItem_Click;
            // 
            // MateriasMenuOption
            // 
            MateriasMenuOption.Name = "MateriasMenuOption";
            MateriasMenuOption.Size = new Size(74, 23);
            MateriasMenuOption.Text = "Materias";
            MateriasMenuOption.Click += MateriasMenuOption_Click;
            // 
            // dictadosToolStripMenuItem
            // 
            dictadosToolStripMenuItem.Name = "dictadosToolStripMenuItem";
            dictadosToolStripMenuItem.Size = new Size(74, 23);
            dictadosToolStripMenuItem.Text = "Dictados";
            dictadosToolStripMenuItem.Click += dictadosToolStripMenuItem_Click;
            // 
            // comisionesToolStripMenuItem1
            // 
            comisionesToolStripMenuItem1.Name = "comisionesToolStripMenuItem1";
            comisionesToolStripMenuItem1.Size = new Size(91, 23);
            comisionesToolStripMenuItem1.Text = "Comisiones";
            comisionesToolStripMenuItem1.Click += comisionesToolStripMenuItem1_Click;
            // 
            // comisionesToolStripMenuItem
            // 
            comisionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comisionListado, comisionAgregar });
            comisionesToolStripMenuItem.Name = "comisionesToolStripMenuItem";
            comisionesToolStripMenuItem.Size = new Size(91, 23);
            comisionesToolStripMenuItem.Text = "Comisiones";
            // 
            // comisionListado
            // 
            comisionListado.Name = "comisionListado";
            comisionListado.Size = new Size(69, 22);
            // 
            // comisionAgregar
            // 
            comisionAgregar.Name = "comisionAgregar";
            comisionAgregar.Size = new Size(69, 22);
            // 
            // cursoListado
            // 
            cursoListado.Name = "cursoListado";
            cursoListado.Size = new Size(180, 22);
            cursoListado.Text = "Listado";
            // 
            // cursoAgregar
            // 
            cursoAgregar.Name = "cursoAgregar";
            cursoAgregar.Size = new Size(180, 22);
            cursoAgregar.Text = "Agregar";
            // 
            // cuentaToolStripMenuItem
            // 
            cuentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSessionToolStripMenuItem });
            cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            cuentaToolStripMenuItem.Size = new Size(65, 23);
            cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // cerrarSessionToolStripMenuItem
            // 
            cerrarSessionToolStripMenuItem.Name = "cerrarSessionToolStripMenuItem";
            cerrarSessionToolStripMenuItem.Size = new Size(180, 24);
            cerrarSessionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSessionToolStripMenuItem.Click += cerrarSessionToolStripMenuItem_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 570);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminForm";
            Text = "Academia";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
#pragma warning disable CS0169 // El campo 'MainForm.planListado' nunca se usa
        private ToolStripMenuItem planListado;
#pragma warning restore CS0169 // El campo 'MainForm.planListado' nunca se usa
#pragma warning disable CS0169 // El campo 'MainForm.agregarPlanToolStripMenuItem2' nunca se usa
        private ToolStripMenuItem agregarPlanToolStripMenuItem2;
        private ToolStripMenuItem especialidadesToolStripMenuItem;
        private ToolStripMenuItem comisionesToolStripMenuItem;
        private ToolStripMenuItem comisionListado;
        private ToolStripMenuItem comisionAgregar;
        private ToolStripMenuItem cursoListado;
        private ToolStripMenuItem cursoAgregar;
#pragma warning disable CS0169 // El campo 'MainForm.materiasToolStripMenuItem' nunca se usa
        private ToolStripMenuItem materiasToolStripMenuItem;
#pragma warning restore CS0169 // El campo 'MainForm.materiasToolStripMenuItem' nunca se usa
#pragma warning disable CS0169 // El campo 'MainForm.materiaListado' nunca se usa
        private ToolStripMenuItem materiaListado;
#pragma warning restore CS0169 // El campo 'MainForm.materiaListado' nunca se usa
#pragma warning disable CS0169 // El campo 'MainForm.materiaAgregar' nunca se usa
        private ToolStripMenuItem materiaAgregar;
#pragma warning restore CS0169 // El campo 'MainForm.materiaAgregar' nunca se usa
        private ToolStripMenuItem MateriasMenuOption;
        private ToolStripMenuItem AlumnosMenuOption;
        private ToolStripMenuItem dictadosToolStripMenuItem;
        private ToolStripMenuItem planesToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem personaToolStripMenuItem;
        private ToolStripMenuItem docentesToolStripMenuItem;
        private ToolStripMenuItem comisionesToolStripMenuItem1;
        private ToolStripMenuItem administradoresToolStripMenuItem;
        private ToolStripMenuItem cuentaToolStripMenuItem;
        private ToolStripMenuItem cerrarSessionToolStripMenuItem;
    }
}