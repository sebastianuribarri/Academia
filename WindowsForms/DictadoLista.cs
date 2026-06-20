using Entities;
using ApiClient;

namespace WindowsForms
{
    public partial class DictadoLista : Form
    {
        public DictadoApiClient dictadoApiClient;
        public DictadoLista()
        {
            InitializeComponent();

            dictadoApiClient = new DictadoApiClient();

            this.Load += new EventHandler(DictadoLista_Load);
            this.eliminarButton.Click += new EventHandler(eliminarButton_Click);
            this.modificarButton.Click += new EventHandler(modificarButton_Click);
            this.agregarButton.Click += new EventHandler(agregarButton_Click);
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            DictadoRegistro dictadoDetalle = new DictadoRegistro();

            Dictado dictadoNuevo = new Dictado();

            dictadoDetalle.Dictado = dictadoNuevo;

            dictadoDetalle.ShowDialog();

            if (dictadoDetalle.Dictado != null)
            {
                this.GetAllAndLoad(); // Solo recargar la lista
            }
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            DictadoRegistro dictadoDetalle = new DictadoRegistro();
            Dictado? dictado = null;

            if (this.SelectedItem() != null)
            {
                int id = this.SelectedItem().id_dictado;
                dictado = await dictadoApiClient.GetAsync(id);
            }

            if (dictado != null)
            {
                dictadoDetalle.EditMode = true;
                dictadoDetalle.Dictado = dictado;

                dictadoDetalle.ShowDialog();

                GetAllAndLoad();
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {

            if (this.SelectedItem() != null)
            {
                int id = this.SelectedItem().id_dictado;
                await ErrorHandler.ExecuteApiCallAsync(() => dictadoApiClient.DeleteAsync(id));
            }
            else
            {
                return;
            }

            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            
            this.dictadosDataGridView.DataSource = await dictadoApiClient.GetAllAsync();
            this.dictadosDataGridView.Refresh();

            this.dictadosDataGridView.Columns[0].Visible = false;
            if (this.dictadosDataGridView.Rows.Count > 0)
            {
                this.dictadosDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private DictadoDto? SelectedItem()
        {
            if (this.dictadosDataGridView.SelectedRows.Count > 0)
            {
                return (DictadoDto)dictadosDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                return null;
            }

        }
        private void DictadoLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void dictadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
