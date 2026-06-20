using Entities;
using ApiClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class PlanRegistro : Form
    {
        private Plan plan;

        // Servicio de Plan y Especialidad para operaciones CRUD
        private PlanApiClient planApiClient = new PlanApiClient();
        private EspecialidadesApiClient especialidadApiClient = new EspecialidadesApiClient();

        public Plan Plan
        {
            get { return plan; }
            set
            {
                plan = value;
            }
        }

        public bool EditMode { get; set; } = false;

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public PlanRegistro()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
            InitializeComponent();
        }


        private void SetPlan()
        {
            if (this.Plan != null)
            {
                this.Plan.desc_plan = descripcionTB.Text;

                // Verificar si se ha seleccionado una especialidad
                if (especialidadCB.SelectedItem is EspecialidadDto especialidad)
                {
                    // Asignar la entidad completa de Especialidad al objeto Plan
                    this.Plan.id_especialidad = especialidad.id_especialidad;
                    this.Plan.Especialidad = new Especialidad
                    {
                        id_especialidad = especialidad.id_especialidad,
                        desc_especialidad = especialidad.desc_especialidad,
                    };
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una especialidad válida.");
                }
            }
        }





        private void SetForm()
        {
            if (this.Plan != null)
            {
                descripcionTB.Text = this.Plan.desc_plan;

                // Selecciona la especialidad en el ComboBox si existe en el plan
                if (this.Plan.id_especialidad != 0)
                {
                    especialidadCB.SelectedValue = this.Plan.id_especialidad;
                }
            }
        }

        private bool ValidatePlan()
        {
            bool isValid = true;

            if (descripcionTB.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTB, "La descripción es requerida.");
            }

            if (especialidadCB.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(especialidadCB, "Debe seleccionar una especialidad.");
            }

            return isValid;
        }

        private async void LoadEspecialidades()
        {
            try
            {
                // Use GetByUsuarioAsync to get available courses for the user

                List<EspecialidadDto> especialidades = await especialidadApiClient.GetAllAsync();


                // Agregar el ítem "Seleccione una opción" al ComboBox
                //especialidades.Insert(0, new EspecialidadDto { id_especialidad = 0, desc_especialidad = "Seleccione una opción" });

                especialidadCB.DataSource = especialidades;
                especialidadCB.DisplayMember = "desc_especialidad";
                especialidadCB.ValueMember = "id_especialidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las especialidades: " + ex.Message);
            }
        }


        private async void aceptarBtn_Click(object sender, EventArgs e)
        {
            if (ValidatePlan())
            {
                // Inicializar Plan si está en modo de creación y es null
                if (Plan == null)
                {
                    Plan = new Plan();
                }

                SetPlan();

                bool exito;
                if (EditMode)
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => planApiClient.UpdateAsync(Plan));
                }
                else
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => planApiClient.AddAsync(Plan));
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

        private void PlanRegistro_Load(object sender, EventArgs e)
        {
            LoadEspecialidades();
            this.SetForm();

        }

    }
}






