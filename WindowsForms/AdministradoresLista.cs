using Entities;
using ApiClient;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class AdministradoresLista : Form
    {
        UsuarioApiClient usuarioApiClient = new UsuarioApiClient();
        public AdministradoresLista()
        {
            UsuarioApiClient usuarioApiClient = new UsuarioApiClient();
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            AdministradorRegistro usuarioDetalle = new AdministradorRegistro();

            Usuario usuarioNuevo = new Usuario();

            usuarioDetalle.Usuario = usuarioNuevo;

            usuarioDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            AdministradorRegistro usuarioDetalle = new AdministradorRegistro();

            int id = this.SelectedItem().id_usuario;

            Usuario? usuario = await usuarioApiClient.GetAsync(id);

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
            int id = this.SelectedItem().id_usuario;
            await usuarioApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            

            this.administradoresDataGridView.DataSource = null;
            this.administradoresDataGridView.DataSource = await usuarioApiClient.GetAllAsync();
            this.administradoresDataGridView.Columns[0].Visible = false;
            if (this.administradoresDataGridView.Rows.Count > 0)
            {
                this.administradoresDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private UsuarioDto SelectedItem()
        {
            UsuarioDto usuario;

            usuario = (UsuarioDto)administradoresDataGridView.SelectedRows[0].DataBoundItem;

            return usuario;
        }


    }
}