using Entities;
using ApiClient;

namespace WindowsForms
{
    public partial class InscripcionesListaAlumno : Form
    {
        private readonly int idAlumno; // Almacenar el ID del alumno
        public InscripcionApiClient inscripcionApiClient;
        public InscripcionesListaAlumno(int idAlumno)
        {
            InitializeComponent();
            this.idAlumno = idAlumno; // Guardar el ID del alumno pasado como parámetro
            inscripcionApiClient = new InscripcionApiClient();
            //this.eliminarButton.Click += new EventHandler(eliminarButton_Click);
            //this.agregarButton.Click += new EventHandler(agregarButton_Click);
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            // Pasar el idAlumno al formulario de alta para que se asocie la inscripción a este alumno
            InscripcionAltaForm inscripcionForm = new InscripcionAltaForm(idAlumno);

            inscripcionForm.ShowDialog();

            GetAllAndLoad();

        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {

            if (this.SelectedItem() != null)
            {
                int id = this.SelectedItem().id_inscripcion;
                await ErrorHandler.ExecuteApiCallAsync(() => inscripcionApiClient.DeleteAsync(id));
            }
            else
            {
                return;
            }

            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            try
            {
                var inscripciones = await inscripcionApiClient.GetInscripcionesAlumnoAsync(idAlumno);

                if (inscripciones == null || !inscripciones.Any())
                {
                    MessageBox.Show("No se encontraron inscripciones para este alumno.");
                }

                this.inscripcionesDataGridView.DataSource = inscripciones;
                this.inscripcionesDataGridView.Refresh();

                if (this.inscripcionesDataGridView.Rows.Count > 0)
                {
                    this.inscripcionesDataGridView.Rows[0].Selected = true;
                    this.eliminarButton.Enabled = true;
                }
                else
                {
                    this.eliminarButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener inscripciones: {ex.Message}");
            }
        }

        private InscripcionAlumnoDto? SelectedItem()
        {
            if (this.inscripcionesDataGridView.SelectedRows.Count > 0)
            {
                return (InscripcionAlumnoDto)inscripcionesDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                return null;
            }

        }

        private void InscripcionesListaAlumno_Load_1(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void cerrarSesionbutton_Click(object sender, EventArgs e)
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
