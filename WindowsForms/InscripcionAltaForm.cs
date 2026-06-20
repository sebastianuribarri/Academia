using Entities;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiClient;

namespace WindowsForms
{
    public partial class InscripcionAltaForm : Form
    {
        private InscripcionRequest inscripcion;
        private InscripcionApiClient inscripcionApiClient = new InscripcionApiClient();
        private CursoApiClient cursosApiClient = new CursoApiClient();
        private ErrorProvider errorProvider;
        private int idUsuario;

        public bool EditMode { get; set; } = false;

        public InscripcionAltaForm(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;

            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            this.inscripcion = new InscripcionRequest();
            LoadCursosAsync();
        }

        private async Task LoadCursosAsync()
        {
            try
            {
                // Use GetByUsuarioAsync to get available courses for the user
                var cursos = await cursosApiClient.GetByUsuarioAsync(idUsuario);
                var materias = cursos.Select(c => c.Materia).Distinct().ToList();
                var comisiones = cursos

                    .Select(c => c.Comision)
                    .Distinct().ToList();

                // Agregar el ítem "Seleccione una opción" al ComboBox
                materias.Insert(0, new Materia { id_materia = 0, desc_materia = "Seleccione una opción" });

                materiaComboBox.DataSource = materias;
                materiaComboBox.DisplayMember = "desc_materia";
                materiaComboBox.ValueMember = "id_materia";

                comisiones.Insert(0, new Comision { id_comision = 0, desc_comision = "Seleccione una opción" });

                comisionComboBox.DataSource = comisiones;
                comisionComboBox.DisplayMember = "desc_comision";
                comisionComboBox.ValueMember = "id_comision";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading materias: {ex.Message}");
            }
        }





        private void SetInscripcionRequest()
        {
            if (this.inscripcion != null)
            {
                if (materiaComboBox.SelectedValue is int materiaId)
                    this.inscripcion.id_materia = materiaId;

                if (comisionComboBox.SelectedValue is int comisionId)
                    this.inscripcion.id_comision = comisionId;



                this.inscripcion.id_usuario = idUsuario;
            }
        }

        private bool ValidateInscripcionRequest()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (materiaComboBox.SelectedItem == null)
            {
                errorProvider.SetError(materiaComboBox, "Debe seleccionar una materia.");
                isValid = false;
            }
            if (comisionComboBox.SelectedItem == null)
            {
                errorProvider.SetError(comisionComboBox, "Debe seleccionar una comisión.");
                isValid = false;
            }


            return isValid;
        }


        private void InscripcionAltaForm_Load(object sender, EventArgs e)
        {
            materiaComboBox.SelectedIndex = -1; // No seleccionar nada por defecto
            comisionComboBox.SelectedIndex = -1; // No seleccionar nada por defecto
        }

        private async void aceptarButton_Click_1(object sender, EventArgs e)
        {
            if (ValidateInscripcionRequest())
            {
                SetInscripcionRequest();

                bool exito = await ErrorHandler.ExecuteApiCallAsync(() => inscripcionApiClient.AddAsync(this.inscripcion));
                if(exito) this.Close();
            }
        }

        private async void cancelarButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
