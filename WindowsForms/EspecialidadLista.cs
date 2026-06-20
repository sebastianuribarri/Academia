using Entities;
using ApiClient;

namespace WindowsForms
{
    public partial class EspecialidadesLista : Form
    {
        public EspecialidadesApiClient especialidadApiClient;

        public EspecialidadesLista()
        {
            
            InitializeComponent();
            especialidadApiClient = new EspecialidadesApiClient();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            EspecialidadRegistro especialidadDetalle = new EspecialidadRegistro();

            Especialidad especialidadNueva = new Especialidad();

            especialidadDetalle.Especialidad = especialidadNueva;

            especialidadDetalle.ShowDialog();

            if (especialidadDetalle.Especialidad != null)
            {
                this.GetAllAndLoad();
            }
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            EspecialidadRegistro especialidadDetalle = new EspecialidadRegistro();

            Especialidad? especialidad = null;

            if (this.SelectedItem() != null)
            {
                int id = this.SelectedItem().id_especialidad;
                especialidad = await especialidadApiClient.GetAsync(id);

                if (especialidad != null)
                {
                    especialidadDetalle.EditMode = true;
                    especialidadDetalle.Especialidad = especialidad;

                    especialidadDetalle.ShowDialog();

                    GetAllAndLoad();
                }
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            if (this.SelectedItem() != null)
            {
                int id = this.SelectedItem().id_especialidad;
                await ErrorHandler.ExecuteApiCallAsync(() => especialidadApiClient.DeleteAsync(id));
            }
            else
            {
                return;
            }

            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            
            this.especialidadesDataGridView.DataSource = await especialidadApiClient.GetAllAsync();
            this.especialidadesDataGridView.Refresh();
            this.especialidadesDataGridView.Columns[0].Visible = false;
            if (this.especialidadesDataGridView.Rows.Count > 0)
            {
                this.especialidadesDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private EspecialidadDto SelectedItem()
        {
            EspecialidadDto especialidad;

            especialidad = (EspecialidadDto)especialidadesDataGridView.SelectedRows[0].DataBoundItem;

            return especialidad;
        }

    }
}
