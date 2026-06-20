using Entities;
using ApiClient;

namespace WindowsForms
{
    public partial class AdministradorRegistro : Form
    {
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                this.SetUsuario();
            }
        }

        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        public AdministradorRegistro()
        {
            InitializeComponent();
        }

        private void UsuarioRegistro_Load(object sender, EventArgs e) { }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            UsuarioApiClient client = new UsuarioApiClient();

            if (this.ValidateUsuario())
            {
                this.Usuario.nombre_usuario = usernameTB.Text;
                this.Usuario.clave = claveTB.Text;
                this.Usuario.tipo_usuario = 1;
                bool exito;
                if (this.EditMode)
                {
                     exito = await ErrorHandler.ExecuteApiCallAsync(() => client.UpdateAsync(this.Usuario));
                }
                else
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => client.AddAsync(this.Usuario));
                }
                if (exito)
                {
                    this.Close();
                }
                
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetUsuario()
        {
            this.usernameTB.Text = this.Usuario.nombre_usuario;
            this.claveTB.Text = this.Usuario.clave;

        }

        private bool ValidateUsuario()
        {
            bool isValid = true;

            errorProvider.SetError(usernameTB, string.Empty);

            if (this.usernameTB.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(usernameTB, "El nombre de usuario es Requerido");
            }
            errorProvider.SetError(claveTB, string.Empty);

            if (this.claveTB.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(claveTB, "La clave es Requerida");
            }

            return isValid;
        }
    }
}
