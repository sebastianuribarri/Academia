using Entities;
using ApiClient;
using System.Numerics;

namespace WindowsForms
{
    public partial class AlumnoRegistro : Form
    {
        private Usuario alumno;

        AlumnoApiClient alumnoApiClient = new AlumnoApiClient();
        PlanApiClient planApiClient = new PlanApiClient();

        public Usuario Alumno
        {
            get { return alumno; }
            set
            {
                alumno = value;
                alumno.tipo_usuario = 3;
                this.SetForm();
            }
        }
        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        public AlumnoRegistro()
        {
            alumnoApiClient = new AlumnoApiClient();
            InitializeComponent();
        }

        private void AlumnoRegistro_Load(object sender, EventArgs e) {
            LoadPlanesAsync();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {

            SetAlumno();

            if (ValidateAlumno())
            {
                bool exito = true;
                if (EditMode)
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => alumnoApiClient.UpdateAsync(Alumno));
                }
                else
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => alumnoApiClient.AddAsync(Alumno));
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

        private void SetForm()
        {
            this.usernameTB.Text = this.Alumno.nombre_usuario;
            this.claveTB.Text = this.Alumno.clave;
            this.legajoTB.Text = this.Alumno.legajo.ToString();
            this.planCB.SelectedValue = this.Alumno.id_plan;
        }

        private void SetAlumno()
        {
            this.Alumno.nombre_usuario = this.usernameTB.Text;
            this.Alumno.clave = this.claveTB.Text;

            if (int.TryParse(this.legajoTB.Text, out int legajo))
            {
                this.Alumno.legajo = legajo;
            }

            if (planCB.SelectedItem != null)
            {
                this.Alumno.id_plan = ((PlanDto)planCB.SelectedItem).id_plan;
            }
        }


        private bool ValidateAlumno()
        {
            bool isValid = true;

            errorProvider.SetError(usernameTB, string.Empty);

            if (this.usernameTB.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(usernameTB, "El nombre de usuario es Requerido");
            }

            return isValid;
        }

        private async Task LoadPlanesAsync()
        {
            try
            {
                var planes = await planApiClient.GetAllAsync();
                planCB.Items.Clear();
                planCB.DisplayMember = "desc_plan";
                planCB.ValueMember = "id_plan";
                foreach (var plan in planes)
                {
                    // Concatenar las descripciones
                    plan.desc_plan = $"{plan.desc_especialidad} ({plan.desc_plan})";
                }
                planCB.DataSource = planes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los planes: {ex.Message.Replace("\"", "")}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
