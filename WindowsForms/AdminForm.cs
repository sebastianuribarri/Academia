

namespace WindowsForms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            IsMdiContainer = true; // Hacemos que el formulario principal sea contenedor MDI
        }

        // Evento que ocurre cuando se carga el formulario
        private void MainForm_Load(object sender, EventArgs e)
        {

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

        private void dictadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            DictadoLista dictadosListaForm = new DictadoLista();
            dictadosListaForm.MdiParent = this;
            dictadosListaForm.WindowState = FormWindowState.Maximized;
            dictadosListaForm.Show();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void comisionesToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar otros formularios MDI antes de abrir uno nuevo
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            DocentesLista docentesListaForm = new DocentesLista();
            docentesListaForm.MdiParent = this;
            docentesListaForm.WindowState = FormWindowState.Maximized;
            docentesListaForm.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }


            this.Hide();

            Login loginForm = new Login();
            loginForm.ShowDialog();

            this.Close();
        }

        private void administradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            AdministradoresLista docentesListaForm = new AdministradoresLista();
            docentesListaForm.MdiParent = this;
            docentesListaForm.WindowState = FormWindowState.Maximized;
            docentesListaForm.Show();
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cierra todas las ventanas hijas
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            // Cierra el formulario principal actual
            this.Hide();

            // Abre el formulario Login en una nueva instancia
            Login loginForm = new Login();
            loginForm.ShowDialog(); // Abre como diálogo modal

            // Cierra la aplicación si el login se cierra
            this.Close();
        }
    }
}


