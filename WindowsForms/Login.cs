using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiClient;
using Entities;

namespace WindowsForms
{
    public partial class Login : Form
    {
        private readonly IUsuarioApiClient _usuarioApiClient;
        private int idUsuario; // Variable para guardar el id_alumno


        public Login()
        {
            InitializeComponent();
            _usuarioApiClient = new UsuarioApiClient();
        }

        private async Task IngresarAsync(string usuario, string contrasena)
        {
            try
            {
                // Llamada al método LoginAsync de UsuarioApiClient
                var user = await _usuarioApiClient.LoginAsync(usuario, contrasena);

                if (user != null)
                {
                    this.Hide();
                    if (user.tipo_usuario == 3) // Alumno
                    {
                        idUsuario = user.id_usuario; // Guarda el id_alumno
                        InscripcionesListaAlumno inscripcionForm = new InscripcionesListaAlumno(idUsuario);
                        inscripcionForm.ShowDialog();
                    }
                    else if (user.tipo_usuario == 2) // Docente
                    {
                        idUsuario = user.id_usuario;
                        DocenteForm docenteForm = new DocenteForm(idUsuario);
                        docenteForm.ShowDialog();
                    }
                    else if (user.tipo_usuario == 1) // Admin
                    {
                        AdminForm mainForm = new AdminForm();
                        mainForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecto");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private async void iniciarSesionButton_Click(object sender, EventArgs e)
        {
            await IngresarAsync(this.usuarioTextBox.Text, this.contrasenaTextBox.Text);
        }
    }
}

