using Entities;

using ApiClient;

namespace WindowsForms
{
    public partial class ComisionesLista : Form
    {
        public ComisionApiClient comisionApiClient;

        public ComisionesLista()
        {
            InitializeComponent();
            comisionApiClient = new ComisionApiClient();
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            ComisionRegistro comisionDetalle = new ComisionRegistro();

            Comision comisionNueva = new Comision();

            comisionDetalle.Comision = comisionNueva;

            comisionDetalle.ShowDialog();

            if (comisionDetalle.Comision != null)
            {
                this.GetAllAndLoad();
            }
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            ComisionRegistro comisionDetalle = new ComisionRegistro();

            Comision? comision = null;

            if (this.SelectedItem() != null)
            {
                int id = this.SelectedItem().id_comision;
                comision = await comisionApiClient.GetAsync(id);
            }

            if (comision != null)
            {
                comisionDetalle.EditMode = true;
                comisionDetalle.Comision = comision;

                comisionDetalle.ShowDialog();

                GetAllAndLoad();
            }

        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            if (this.SelectedItem() != null)
            {
                int id = this.SelectedItem().id_comision;
                await ErrorHandler.ExecuteApiCallAsync(() => comisionApiClient.DeleteAsync(id));
            }
            else
            {
                return;
            }

            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            this.comisionesDataGridView.DataSource = await comisionApiClient.GetAllAsync();
            this.comisionesDataGridView.Columns[0].Visible = false;
            this.comisionesDataGridView.Refresh();

            if (this.comisionesDataGridView.Rows.Count > 0)
            {
                this.comisionesDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private ComisionDto? SelectedItem()
        {
            if (this.comisionesDataGridView.SelectedRows.Count > 0)
            {
                return (ComisionDto)comisionesDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                return null;
            }
        }

        private void comisionesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
