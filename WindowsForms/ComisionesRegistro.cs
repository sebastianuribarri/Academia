using Entities;
using ApiClient;

namespace WindowsForms
{
    public partial class ComisionRegistro : Form
    {
        private Comision comision;

        // Servicio de Comision y Plan para operaciones CRUD
        private ComisionApiClient comisionApiClient = new ComisionApiClient();
        private PlanApiClient planApiClient = new PlanApiClient();

        public Comision Comision
        {
            get { return comision; }
            set
            {
                comision = value;
                this.SetForm();
            }
        }

        public bool EditMode { get; set; } = false;

        public ComisionRegistro()
        {
            InitializeComponent();
            
            LoadPlanes();
        }

        private void ComisionRegistro_Load(object sender, EventArgs e)
        {
            this.SetForm();
        }

        private void SetComision()
        {
            if (this.Comision == null)
            {
                Comision = new Comision();
            }
           
            this.Comision.desc_comision = descripcionTB.Text;
            this.Comision.anio_especialidad = int.Parse(anioTB.Text);
            if (planCB.SelectedItem != null)
            {
                this.Comision.id_plan = ((PlanDto)planCB.SelectedItem).id_plan;
            }
            
        }

        private void SetForm()
        {
            if (this.Comision != null)
            {
                descripcionTB.Text = this.Comision.desc_comision;
                anioTB.Text = this.Comision.anio_especialidad.ToString();
                // Selecciona la plan en el ComboBox si existe en el comision
                if (this.Comision.id_plan != 0)
                {
                    planCB.SelectedValue = this.Comision.id_plan;
                }
            }
            anioTB.Text = DateTime.Now.Year.ToString();
        }

        private bool ValidateComision()
        {
            bool isValid = true;

            if (descripcionTB.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTB, "La descripción es requerida.");
            }

            if (planCB.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(planCB, "Debe seleccionar una plan.");
            }

            return isValid;
        }

        private async void LoadPlanes()
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


        private async void aceptarBtn_Click(object sender, EventArgs e)
        {
            if (ValidateComision())
            {

                SetComision();
                bool exito;
                if (EditMode)
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => comisionApiClient.UpdateAsync(Comision));
                }
                else
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => comisionApiClient.AddAsync(Comision));
                }
                if (exito)
                {
                    Close();
                }
                
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
