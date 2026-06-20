using Entities;
using System;
using System.Windows.Forms;
using ApiClient;
using Newtonsoft.Json.Linq;

namespace WindowsForms
{
    public partial class PersonaRegistro : Form
    {
        private Persona persona;
        private Usuario usuario;
        private PersonaApiClient personaApiClient = new PersonaApiClient();

        public Persona Persona
        {
            get { return persona; }
            set
            {
                persona = value;
                this.SetPersona();
            }
        }
        public bool EditMode { get; set; } = false;

        public PersonaRegistro()
        {

            InitializeComponent();
            if (this.Persona == null)
            {
                this.Persona = new Persona();
            }
            fechaNacimientoPicker.Value = DateTime.Now;
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidatePersona())
            {
                this.SetPersona();
                Persona newPersona = new Persona();
                bool exito = true;
                if (this.EditMode)
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => personaApiClient.UpdateAsync(Persona));
                }
                else
                {
                    // Si es una nueva persona, la agregamos
                    newPersona = await personaApiClient.AddAsync(Persona);
                    exito = true;
                }
                if (exito)
                {
                    Close();
                    if (!this.EditMode)
                    {
                        int selectedValue;
                        if (tipoCB.SelectedValue is int tipoUsuario)
                        {
                            selectedValue = tipoUsuario;
                        }
                        else
                        {
                            selectedValue = 4;
                        }
                        
                        // Abrir diferentes formularios según el valor seleccionado
                        switch (selectedValue)
                        {
                            case 3:
                                var alumnoForm = new AlumnoRegistro();
                                Usuario alumnoNuevo = new Usuario();
                                alumnoNuevo.id_persona = newPersona.id_persona;
                                alumnoForm.Alumno = alumnoNuevo;
                                alumnoForm.ShowDialog();
                                break;

                            case 2:
                                var docenteForm = new DocenteRegistro();
                                Usuario docenteNuevo = new Usuario();
                                docenteNuevo.id_persona = newPersona.id_persona;
                                docenteForm.Usuario = docenteNuevo;
                                docenteForm.ShowDialog();
                                break;

                            case 1:
                                var adminForm = new AdministradorRegistro();
                                Usuario adminNuevo = new Usuario();
                                adminNuevo.id_persona = newPersona.id_persona;
                                adminForm.Usuario = adminNuevo;
                                adminForm.ShowDialog();
                                break;

                            default:
                                MessageBox.Show("Selección no válida.");
                                break;
                        }
                       
                    }
                    
                    
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetPersona()
        {
            if (this.Persona != null)
            {
                if (!string.IsNullOrWhiteSpace(nombreTB.Text))
                {
                    this.Persona.nombre = nombreTB.Text;
                }
                if (!string.IsNullOrWhiteSpace(txtBoxApellido.Text))
                {
                    this.Persona.apellido = txtBoxApellido.Text;
                }
                if (!string.IsNullOrWhiteSpace(txtBoxDireccion.Text))
                {
                    this.Persona.direccion = txtBoxDireccion.Text;
                }
                if (!string.IsNullOrWhiteSpace(emailTB.Text))
                {
                    this.Persona.email = emailTB.Text;
                }

                if (!string.IsNullOrWhiteSpace(telefonoTB.Text))
                {
                    this.Persona.telefono = telefonoTB.Text;
                }

                this.Persona.fecha_nac = fechaNacimientoPicker.Value;

               
            }
        }

        private bool ValidatePersona()
        {
            bool isValid = true;

            // Limpiar errores previos
            errorProvider.SetError(nombreTB, string.Empty);
            errorProvider.SetError(emailTB, string.Empty);

            // Validación del campo nombre
            if (this.nombreTB.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTB, "El nombre es requerido.");
            }

            // Validación del campo email
            if (this.emailTB.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(emailTB, "El email es requerido.");
            }



            return isValid;
        }

        private void SetForm()
        {
            tipoCB.SelectedValue = 3;
            if (this.Persona != null)
            {
                nombreTB.Text  = this.Persona.nombre;
                txtBoxApellido.Text  = this.Persona.apellido;
                txtBoxDireccion.Text =  this.Persona.direccion;
                emailTB.Text  = this.Persona.email;
                telefonoTB.Text =  this.Persona.telefono;
                fechaNacimientoPicker.Value =  this.Persona.fecha_nac;
            }
        }

        private void PersonaRegistro_Load(object sender, EventArgs e)
        {

            tipoCB.Items.Clear();
            tipoCB.DisplayMember = "Display";
            tipoCB.ValueMember = "Value";
            var tipos = new List<Tipo>()
            {
               new Tipo { Value = 1, Display = "ADMINISTRADOR" },
                new Tipo { Value = 2, Display = "DOCENTE" },
                new Tipo { Value = 3, Display = "ALUMNO" }
            };
            
            tipoCB.DataSource = tipos;
            tipoCB.SelectedValue = 3;
            this.SetForm();
        }
    }

    public class Tipo
    {
        public int Value { get; set; }
        public string Display { get; set; }
    }
}

