using Entities;
using ApiClient;

namespace WindowsForms
{
    public partial class MateriaLista : Form
    {

        public MateriaApiClient materiaApiClient;
        public MateriaLista()
        {
            InitializeComponent();

            materiaApiClient = new MateriaApiClient();

            this.Load += new EventHandler(MateriaLista_Load);
            this.eliminarButton.Click += new EventHandler(eliminarButton_Click);
            this.modificarButton.Click += new EventHandler(modificarButton_Click);
            this.agregarButton.Click += new EventHandler(agregarButton_Click);
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            MateriaRegistro materiaDetalle = new MateriaRegistro();

            Materia materiaNueva = new Materia();

            materiaDetalle.Materia = materiaNueva;

            materiaDetalle.ShowDialog();

            if (materiaDetalle.Materia != null)
            {
                this.GetAllAndLoad(); // Solo recargar la lista de cursos
            }
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            MateriaRegistro materiaDetalle = new MateriaRegistro();
            Materia? materia = null;

            if (this.SelectedItem() != null)
            {
                int id = this.SelectedItem().Id;
                materia = await materiaApiClient.GetAsync(id);
            }

            if (materia != null)
            {
                materiaDetalle.EditMode = true;
                materiaDetalle.Materia = materia;

                materiaDetalle.ShowDialog();

                GetAllAndLoad();
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            
            if(this.SelectedItem() != null)
            {
                int id = this.SelectedItem().Id;
                await ErrorHandler.ExecuteApiCallAsync(() => materiaApiClient.DeleteAsync(id));
            }
            else
            {
                return;
            }

            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
           
            this.materiasDataGridView.DataSource = await materiaApiClient.GetAllAsync();
            this.materiasDataGridView.Refresh();
            this.materiasDataGridView.Columns[0].Visible = false;

            if (this.materiasDataGridView.Rows.Count > 0)
            {
                this.materiasDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private MateriaDto? SelectedItem()
        {
            if (this.materiasDataGridView.SelectedRows.Count > 0)
            {
                return (MateriaDto)materiasDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                return null;
            }

        }

        private void MateriaLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
    }
}
