using Entities;
using ApiClient;

namespace WindowsForms
{
    public partial class AlumnosLista : Form
    {
        AlumnoApiClient alumnoApiClient;
        public AlumnosLista()
        {
            alumnoApiClient = new AlumnoApiClient();
            InitializeComponent();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            AlumnoRegistro alumnoDetalle = new AlumnoRegistro();

            Usuario alumnoNuevo = new Usuario();

            alumnoDetalle.Alumno = alumnoNuevo;

            alumnoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            AlumnoRegistro alumnoDetalle = new AlumnoRegistro();

            int id = this.SelectedItem().Id;

            Usuario? alumno = await alumnoApiClient.GetAsync(id);

            if (alumno != null)
            {
                alumnoDetalle.EditMode = true;
                alumnoDetalle.Alumno = alumno;
                alumnoDetalle.ShowDialog();
                this.GetAllAndLoad();
            }

        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id = this.SelectedItem().Id;
            await alumnoApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {


            this.alumnosDataGridView.DataSource = null;
            this.alumnosDataGridView.DataSource = await alumnoApiClient.GetAllAsync();
            this.alumnosDataGridView.Columns[0].Visible = false;
            if (this.alumnosDataGridView.Rows.Count > 0)
            {
                this.alumnosDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private AlumnoDto SelectedItem()
        {
            AlumnoDto alumno;

            alumno = (AlumnoDto)alumnosDataGridView.SelectedRows[0].DataBoundItem;

            return alumno;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}