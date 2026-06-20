using Entities;
using ApiClient;

namespace WindowsForms
{
    public partial class PersonasLista : Form
    {
        public PersonaApiClient personaApiClient;

        public PersonasLista()
        {
            InitializeComponent();
            personaApiClient = new PersonaApiClient();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            PersonaRegistro personaDetalle = new PersonaRegistro();

            Persona personaNueva = new Persona();

            personaDetalle.Persona = personaNueva;

            personaDetalle.ShowDialog();

            if (personaDetalle.Persona != null)
            {
                this.GetAllAndLoad(); // Solo recargar la lista de personas
            }
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            PersonaRegistro personaDetalle = new PersonaRegistro();
            Persona? persona = null;

            if (this.SelectedItem() != null)
            {
                int id = this.SelectedItem().id_persona;
                persona = await personaApiClient.GetAsync(id);

            }


            if (persona != null)
            {
                personaDetalle.EditMode = true;
                personaDetalle.Persona = persona;

                personaDetalle.ShowDialog();
                this.GetAllAndLoad();
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            if (this.SelectedItem() != null)
            {
                int id = this.SelectedItem().id_persona;
                await ErrorHandler.ExecuteApiCallAsync(() => personaApiClient.DeleteAsync(id));
            }
            else
            {
                return;
            }

            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
           
            this.personasDataGridView.DataSource = await personaApiClient.GetAllAsync();
            this.personasDataGridView.Columns[0].Visible = false;
            this.personasDataGridView.Refresh();    

            if (this.personasDataGridView.Rows.Count > 0)
            {
                this.personasDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private PersonaDto SelectedItem()
        {
            PersonaDto persona;

            persona = (PersonaDto)personasDataGridView.SelectedRows[0].DataBoundItem;

            return persona;
        }

        private void personasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
