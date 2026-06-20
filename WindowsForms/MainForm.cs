

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true; // Hacemos que el formulario principal sea contenedor MDI
        }

        // Evento que ocurre cuando se carga el formulario
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // Evento para mostrar el formulario PersonaLista
        private void personaListado_Click(object sender, EventArgs e)
        {
            // Cerrar otros formularios MDI antes de abrir uno nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            PersonasLista personaListaForm = new PersonasLista();
            personaListaForm.MdiParent = this;
            personaListaForm.WindowState = FormWindowState.Maximized;
            personaListaForm.Show();
        }

        // Evento para mostrar el formulario AgregarPersona
        private void personaAgregar_Click(object sender, EventArgs e)
        {
            // Cerrar otros formularios MDI antes de abrir uno nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            PersonaRegistro agregarPersonaForm = new PersonaRegistro();
            agregarPersonaForm.MdiParent = this;
            agregarPersonaForm.WindowState = FormWindowState.Maximized;
            agregarPersonaForm.Show();
        }

        // Evento para mostrar el formulario UsuarioLista
        private void usuarioListado_Click(object sender, EventArgs e)
        {
            // Cerrar otros formularios MDI antes de abrir uno nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            DocentesLista usuarioListaForm = new DocentesLista();
            usuarioListaForm.MdiParent = this;
            usuarioListaForm.WindowState = FormWindowState.Maximized;
            usuarioListaForm.Show();
        }

        // Evento para mostrar el formulario AgregarUsuario
        private void usuarioAgregar_Click(object sender, EventArgs e)
        {
            // Cerrar otros formularios MDI antes de abrir uno nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            DocenteRegistro agregarUsuarioForm = new DocenteRegistro();
            agregarUsuarioForm.MdiParent = this;
            agregarUsuarioForm.WindowState = FormWindowState.Maximized;
            agregarUsuarioForm.Show();
        }

        private void especialidadListado_Click(object sender, EventArgs e)
        {
            // Cerrar otros formularios MDI antes de abrir uno nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            EspecialidadesLista especialidadListaForm = new EspecialidadesLista();
            especialidadListaForm.MdiParent = this;
            especialidadListaForm.WindowState = FormWindowState.Maximized;
            especialidadListaForm.Show();
        }

        // Evento para mostrar el formulario AgregarEspecialidad
        private void especialidadAgregar_Click(object sender, EventArgs e)
        {
            // Cerrar otros formularios MDI antes de abrir uno nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            EspecialidadRegistro agregarEspecialidadForm = new EspecialidadRegistro();
            agregarEspecialidadForm.MdiParent = this;
            agregarEspecialidadForm.WindowState = FormWindowState.Maximized;
            agregarEspecialidadForm.Show();
        }
        private void planListado_Click(object sender, EventArgs e)
        {
            // Cerrar otros formularios MDI antes de abrir uno nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            PlanesLista planListaForm = new PlanesLista();
            planListaForm.MdiParent = this;
            planListaForm.WindowState = FormWindowState.Maximized;
            planListaForm.Show();
        }

        // Evento para mostrar el formulario AgregarEspecialidad
        private void planAgregar_Click(object sender, EventArgs e)
        {
            // Cerrar otros formularios MDI antes de abrir uno nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            PlanRegistro agregarPlanForm = new PlanRegistro();
            agregarPlanForm.MdiParent = this;
            agregarPlanForm.WindowState = FormWindowState.Maximized;
            agregarPlanForm.Show();
        }
        private void comisionListado_Click(object sender, EventArgs e)
        {
            // Cerrar otros formularios MDI antes de abrir uno nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            ComisionesLista comisionListaForm = new ComisionesLista();
            comisionListaForm.MdiParent = this;
            comisionListaForm.WindowState = FormWindowState.Maximized;
            comisionListaForm.Show();
        }

        // Evento para mostrar el formulario AgregarEspecialidad
        private void comisionAgregar_Click(object sender, EventArgs e)
        {
            // Cerrar otros formularios MDI antes de abrir uno nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            ComisionRegistro agregarComisionForm = new ComisionRegistro();
            agregarComisionForm.MdiParent = this;
            agregarComisionForm.WindowState = FormWindowState.Maximized;
            agregarComisionForm.Show();
        }
        private void cursoListado_Click(object sender, EventArgs e)
        {
            // Cerrar otros formularios MDI antes de abrir uno nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            CursoLista cursoListaForm = new CursoLista();
            cursoListaForm.MdiParent = this;
            cursoListaForm.WindowState = FormWindowState.Maximized;
            cursoListaForm.Show();
        }

        // Evento para mostrar el formulario AgregarEspecialidad
        private void cursoAgregar_Click(object sender, EventArgs e)
        {
            // Cerrar otros formularios MDI antes de abrir uno nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            CursoRegistro agregarCursoForm = new CursoRegistro();
            agregarCursoForm.MdiParent = this;
            agregarCursoForm.WindowState = FormWindowState.Maximized;
            agregarCursoForm.Show();
        }

        private void MateriasMenuOption_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            MateriaLista materiaListaForm = new MateriaLista();
            materiaListaForm.MdiParent = this;
            materiaListaForm.WindowState = FormWindowState.Maximized;
            materiaListaForm.Show();
        }

        private void AlumnosMenuOption_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            AlumnosLista alumnosListaForm = new AlumnosLista();
            alumnosListaForm.MdiParent = this;
            alumnosListaForm.WindowState = FormWindowState.Maximized;
            alumnosListaForm.Show();
        }

        private void cursosMenuOption_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            CursoLista cursosListaForm = new CursoLista();
            cursosListaForm.MdiParent = this;
            cursosListaForm.WindowState = FormWindowState.Maximized;
            cursosListaForm.Show();

        }
    }
}


