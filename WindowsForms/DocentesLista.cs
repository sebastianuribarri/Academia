using Entities;
using ApiClient;

namespace WindowsForms
{
    public partial class DocentesLista : Form
    {
        DocenteApiClient docenteApiClient;
        public DocentesLista()
        {
            docenteApiClient = new DocenteApiClient();
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            DocenteRegistro usuarioDetalle = new DocenteRegistro();

            Usuario usuarioNuevo = new Usuario();

            usuarioDetalle.Usuario = usuarioNuevo;

            usuarioDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            DocenteRegistro usuarioDetalle = new DocenteRegistro();

            int id = this.SelectedItem().Id;

            Usuario? usuario = await docenteApiClient.GetAsync(id);

            if(usuario != null)
            {
                usuarioDetalle.EditMode = true;
                usuarioDetalle.Usuario = usuario;
                usuarioDetalle.ShowDialog();
                this.GetAllAndLoad();
            }
            
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id = this.SelectedItem().Id;
            await docenteApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {

            
            this.usuariosDataGridView.DataSource = null;
            this.usuariosDataGridView.DataSource = await docenteApiClient.GetAllAsync();
            this.usuariosDataGridView.Columns[0].Visible = false;
            if (this.usuariosDataGridView.Rows.Count > 0)
            {
                this.usuariosDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private DocenteDto SelectedItem()
        {
            DocenteDto usuario;

            usuario = (DocenteDto)usuariosDataGridView.SelectedRows[0].DataBoundItem;

            return usuario;
        }


    }
}