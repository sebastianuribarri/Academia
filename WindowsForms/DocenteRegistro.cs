using Entities;
using ApiClient;

namespace WindowsForms
{
    public partial class DocenteRegistro : Form
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

        public DocenteRegistro()
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
                this.Usuario.tipo_usuario = 2;

                int legajo;
                if (Int32.TryParse(legajoTextBox.Text, out legajo))
                {
                    this.Usuario.legajo = legajo;
                }
                else
                {
                    this.Usuario.legajo = null;
                }

                bool exito;
                if (EditMode)
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => client.UpdateAsync(Usuario));
                }
                else
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => client.AddAsync(Usuario));
                }
                if (exito)
                {
                    Close();
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
            this.legajoTextBox.Text = this.Usuario.legajo.ToString();

        }

        private bool ValidateUsuario()
        {
            bool isValid = true;

            errorProvider.SetError(usernameTB, string.Empty);

            if (this.usernameTB.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(usernameTB, "El nombre_usuario es Requerido");
            }

            return isValid;
        }
    }
}
