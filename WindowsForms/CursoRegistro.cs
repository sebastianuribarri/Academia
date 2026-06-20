using Entities;
using ApiClient;
using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class CursoRegistro : Form
    {
        private Curso curso;

        // El servicio de Curso para las operaciones CRUD
        private CursoApiClient cursoApiClient = new CursoApiClient();
        private MateriaApiClient materiaApiClient = new MateriaApiClient();
        private ComisionApiClient comisionApiClient = new ComisionApiClient();
        private ErrorProvider errorProvider;

        public Curso Curso
        {
            get { return curso; }
            set
            {
                curso = value;
                this.SetCurso();
            }
        }

        public bool EditMode { get; set; } = false;

        public CursoRegistro()
        {
            InitializeComponent();

            errorProvider = new ErrorProvider();

            if (this.Curso == null)
            {
                this.Curso = new Curso();
            }

            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateCurso())
            {
                this.SetCurso();
                bool exito;
                if (EditMode)
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => cursoApiClient.UpdateAsync(Curso));
                }
                else
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => cursoApiClient.AddAsync(Curso));
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

        private void SetCurso()
        {
            if (this.Curso != null)
            {
                int anioCalendario, cupo;

                if (materiaCB.SelectedValue is int materiaId)
                {
                    this.Curso.id_materia = materiaId;
                }
                if (materiaCB.SelectedValue is int comisionId)
                {
                    this.Curso.id_comision = comisionId;
                }

                if (Int32.TryParse(anioTxtBox.Text, out anioCalendario))
                {
                    this.Curso.anio_calendario = anioCalendario;
                }

                if (Int32.TryParse(cupoTextBox.Text, out cupo))
                {
                    this.Curso.cupo = cupo;
                }
            }
        }



        private bool ValidateCurso()
        {
            bool isValid = true;

            errorProvider.Clear();

            // Validación del campo idComision
            if (materiaCB.SelectedItem == null)
            {
                errorProvider.SetError(materiaCB, "Debe seleccionar una materia.");
                isValid = false;
            }
            if (comisionCB.SelectedItem == null)
            {
                errorProvider.SetError(comisionCB, "Debe seleccionar una comision.");
                isValid = false;
            }

            // Validación del campo anioCalendario
            if (string.IsNullOrWhiteSpace(anioTxtBox.Text))
            {
                isValid = false;
                errorProvider.SetError(anioTxtBox, "El año calendario es requerido.");
            }

            // Validación del campo cupo
            if (string.IsNullOrWhiteSpace(cupoTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(cupoTextBox, "El cupo es requerido.");
            }



            return isValid;
        }

        private void SetForm()
        {
            if (this.Curso != null)
            {
                comisionCB.SelectedValue = this.Curso.id_comision;

                materiaCB.SelectedValue = this.Curso.id_materia;

                anioTxtBox.Text = this.Curso.anio_calendario.ToString();

                cupoTextBox.Text = this.Curso.cupo.ToString();
            }
        }


        private void CursoRegistro_Load(object sender, EventArgs e)
        {
            LoadCursosAsync();
            if (this.EditMode && this.Curso != null)
            {
                this.SetForm();
            }
        }

        private async Task LoadCursosAsync()
        {
            try
            {
                // Use GetByUsuarioAsync to get available courses for the user

                List<MateriaDto> materias = await materiaApiClient.GetAllAsync();
                List<ComisionDto> comisiones = await comisionApiClient.GetAllAsync();


                // Agregar el ítem "Seleccione una opción" al ComboBox
                materias.Insert(0, new MateriaDto { Id = 0, Descripcion = "Seleccione una opción" });

                materiaCB.DataSource = materias;
                materiaCB.DisplayMember = "Descripcion";
                materiaCB.ValueMember = "Id";

                comisiones.Insert(0, new ComisionDto { id_comision = 0, desc_comision = "Seleccione una opción" });

                comisionCB.DataSource = comisiones;
                comisionCB.DisplayMember = "desc_comision";
                comisionCB.ValueMember = "id_comision";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

    }


}
