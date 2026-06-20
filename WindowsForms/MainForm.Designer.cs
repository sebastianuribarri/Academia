namespace WindowsForms
{
    partial class MainForm
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
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            usuarioListado = new ToolStripMenuItem();
            usuarioAgregar = new ToolStripMenuItem();
            personaToolStripMenuItem = new ToolStripMenuItem();
            personaListado = new ToolStripMenuItem();
            personaAgregar = new ToolStripMenuItem();
            planesToolStripMenuItem = new ToolStripMenuItem();
            listadoToolStripMenuItem2 = new ToolStripMenuItem();
            planAgregar = new ToolStripMenuItem();
            especialidadesToolStripMenuItem = new ToolStripMenuItem();
            especialidadListado = new ToolStripMenuItem();
            especialidadAgregar = new ToolStripMenuItem();
            cursosMenuOption = new ToolStripMenuItem();
            MateriasMenuOption = new ToolStripMenuItem();
            AlumnosMenuOption = new ToolStripMenuItem();
            comisionesToolStripMenuItem = new ToolStripMenuItem();
            comisionListado = new ToolStripMenuItem();
            comisionAgregar = new ToolStripMenuItem();
            cursoListado = new ToolStripMenuItem();
            cursoAgregar = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, personaToolStripMenuItem, planesToolStripMenuItem, especialidadesToolStripMenuItem, cursosMenuOption, MateriasMenuOption, AlumnosMenuOption });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioListado, usuarioAgregar });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(74, 23);
            usuarioToolStripMenuItem.Text = "Usuarios";
            // 
            // usuarioListado
            // 
            usuarioListado.Name = "usuarioListado";
            usuarioListado.Size = new Size(127, 24);
            usuarioListado.Text = "Listado";
            usuarioListado.Click += usuarioListado_Click;
            // 
            // usuarioAgregar
            // 
            usuarioAgregar.Name = "usuarioAgregar";
            usuarioAgregar.Size = new Size(127, 24);
            usuarioAgregar.Text = "Agregar";
            usuarioAgregar.Click += usuarioAgregar_Click;
            // 
            // personaToolStripMenuItem
            // 
            personaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personaListado, personaAgregar });
            personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            personaToolStripMenuItem.Size = new Size(75, 23);
            personaToolStripMenuItem.Text = "Personas";
            // 
            // personaListado
            // 
            personaListado.Name = "personaListado";
            personaListado.Size = new Size(127, 24);
            personaListado.Text = "Listado";
            personaListado.Click += personaListado_Click;
            // 
            // personaAgregar
            // 
            personaAgregar.Name = "personaAgregar";
            personaAgregar.Size = new Size(127, 24);
            personaAgregar.Text = "Agregar";
            personaAgregar.Click += personaAgregar_Click;
            // 
            // planesToolStripMenuItem
            // 
            planesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadoToolStripMenuItem2, planAgregar });
            planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            planesToolStripMenuItem.Size = new Size(60, 23);
            planesToolStripMenuItem.Text = "Planes";
            // 
            // listadoToolStripMenuItem2
            // 
            listadoToolStripMenuItem2.Name = "listadoToolStripMenuItem2";
            listadoToolStripMenuItem2.Size = new Size(127, 24);
            listadoToolStripMenuItem2.Text = "Listado";
            listadoToolStripMenuItem2.Click += planListado_Click;
            // 
            // planAgregar
            // 
            planAgregar.Name = "planAgregar";
            planAgregar.Size = new Size(127, 24);
            planAgregar.Text = "Agregar";
            planAgregar.Click += planAgregar_Click;
            // 
            // especialidadesToolStripMenuItem
            // 
            especialidadesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { especialidadListado, especialidadAgregar });
            especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            especialidadesToolStripMenuItem.Size = new Size(107, 23);
            especialidadesToolStripMenuItem.Text = "Especialidades";
            // 
            // especialidadListado
            // 
            especialidadListado.Name = "especialidadListado";
            especialidadListado.Size = new Size(127, 24);
            especialidadListado.Text = "Listado";
            especialidadListado.Click += especialidadListado_Click;
            // 
            // especialidadAgregar
            // 
            especialidadAgregar.Name = "especialidadAgregar";
            especialidadAgregar.Size = new Size(127, 24);
            especialidadAgregar.Text = "Agregar";
            // 
            // cursosMenuOption
            // 
            cursosMenuOption.Name = "cursosMenuOption";
            cursosMenuOption.Size = new Size(63, 23);
            cursosMenuOption.Text = "Cursos";
            cursosMenuOption.Click += cursosMenuOption_Click;
            // 
            // MateriasMenuOption
            // 
            MateriasMenuOption.Name = "MateriasMenuOption";
            MateriasMenuOption.Size = new Size(74, 23);
            MateriasMenuOption.Text = "Materias";
            MateriasMenuOption.Click += MateriasMenuOption_Click;
            // 
            // AlumnosMenuOption
            // 
            AlumnosMenuOption.Name = "AlumnosMenuOption";
            AlumnosMenuOption.Size = new Size(75, 23);
            AlumnosMenuOption.Text = "Alumnos";
            AlumnosMenuOption.Click += AlumnosMenuOption_Click;
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
            comisionListado.Size = new Size(127, 24);
            comisionListado.Text = "Listado";
            comisionListado.Click += comisionListado_Click;
            // 
            // comisionAgregar
            // 
            comisionAgregar.Name = "comisionAgregar";
            comisionAgregar.Size = new Size(127, 24);
            comisionAgregar.Text = "Agregar";
            comisionAgregar.Click += comisionAgregar_Click;
            // 
            // cursoListado
            // 
            cursoListado.Name = "cursoListado";
            cursoListado.Size = new Size(180, 22);
            cursoListado.Text = "Listado";
            cursoListado.Click += cursoListado_Click;
            // 
            // cursoAgregar
            // 
            cursoAgregar.Name = "cursoAgregar";
            cursoAgregar.Size = new Size(180, 22);
            cursoAgregar.Text = "Agregar";
            cursoAgregar.Click += cursoAgregar_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 570);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Academia";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem personaToolStripMenuItem;
        private ToolStripMenuItem usuarioListado;
        private ToolStripMenuItem usuarioAgregar;
        private ToolStripMenuItem personaListado;
        private ToolStripMenuItem personaAgregar;
        private ToolStripMenuItem planesToolStripMenuItem;
#pragma warning disable CS0169 // El campo 'MainForm.planListado' nunca se usa
        private ToolStripMenuItem planListado;
#pragma warning restore CS0169 // El campo 'MainForm.planListado' nunca se usa
#pragma warning disable CS0169 // El campo 'MainForm.agregarPlanToolStripMenuItem2' nunca se usa
        private ToolStripMenuItem agregarPlanToolStripMenuItem2;
#pragma warning restore CS0169 // El campo 'MainForm.agregarPlanToolStripMenuItem2' nunca se usa
        private ToolStripMenuItem listadoToolStripMenuItem2;
        private ToolStripMenuItem planAgregar;
        private ToolStripMenuItem especialidadesToolStripMenuItem;
        private ToolStripMenuItem especialidadListado;
        private ToolStripMenuItem especialidadAgregar;
        private ToolStripMenuItem comisionesToolStripMenuItem;
        private ToolStripMenuItem comisionListado;
        private ToolStripMenuItem comisionAgregar;
        private ToolStripMenuItem cursosMenuOption;
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
    }
}