using Entities;
using ApiClient;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MateriaRegistro : Form
    {
        private Materia materia;
        private MateriaApiClient materiaApiClient = new MateriaApiClient();
        private PlanApiClient planApiClient = new PlanApiClient();
        private ErrorProvider errorProvider;

        public Materia Materia
        {
            get { return materia; }
            set
            {
                materia = value;
                this.SetMateria();
            }
        }
        public bool EditMode { get; set; } = false;

        public MateriaRegistro()
        {
            InitializeComponent();

            errorProvider = new ErrorProvider
            {
                BlinkStyle = ErrorBlinkStyle.NeverBlink
            };

            if (this.Materia == null)
            {
                this.Materia = new Materia();
            }
            LoadPlanesAsync();
        }

        // Método para cargar planes en el ComboBox
        private async Task LoadPlanesAsync()
        {
            try
            {
                var plans = await planApiClient.GetAllAsync();
                planCB.Items.Clear();
                foreach (var plan in plans)
                {
                    // Concatenar las descripciones
                    string displayText = $"{plan.desc_especialidad} ({plan.desc_plan})";
                    planCB.Items.Add(new ComboBoxItem(displayText, plan.id_plan));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los planes: {ex.Message.Replace("\"", "")}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateMateria())
            {
                this.SetMateria();
                bool exito = true;
                if (this.EditMode)
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => materiaApiClient.UpdateAsync(Materia));
                }
                else
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => materiaApiClient.AddAsync(Materia));
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

        private void SetMateria()
        {
            if (this.Materia != null)
            {
                int hsSem, hsTot;

                // Obtener el id_plan del ComboBox seleccionado
                if (planCB.SelectedItem is ComboBoxItem selectedPlan)
                {
                    this.Materia.id_plan = selectedPlan.Value;
                }
                if (!string.IsNullOrWhiteSpace(descTB.Text))
                {
                    this.Materia.desc_materia = descTB.Text;
                }

                if (Int32.TryParse(hsSemTB.Text, out hsSem))
                {
                    this.Materia.hs_semanales = hsSem;
                }

                if (Int32.TryParse(hsTotTB.Text, out hsTot))
                {
                    this.Materia.hs_totales = hsTot;
                }
            }
        }

        private bool ValidateMateria()
        {
            bool isValid = true;

            // Limpiar errores previos
            errorProvider.SetError(planCB, string.Empty);
            errorProvider.SetError(descTB, string.Empty);
            errorProvider.SetError(hsSemTB, string.Empty);
            errorProvider.SetError(hsTotTB, string.Empty);

            if (planCB.SelectedItem == null)
            {
                isValid = false;
                errorProvider.SetError(planCB, "Debe seleccionar un plan.");
            }

            if (string.IsNullOrWhiteSpace(descTB.Text))
            {
                isValid = false;
                errorProvider.SetError(descTB, "La descripcion de la materia es requerida.");
            }

            if (string.IsNullOrWhiteSpace(hsSemTB.Text))
            {
                isValid = false;
                errorProvider.SetError(hsSemTB, "Las horas semanales son requeridas.");
            }

            if (string.IsNullOrWhiteSpace(hsTotTB.Text))
            {
                isValid = false;
                errorProvider.SetError(hsTotTB, "Las horas totales son requeridas.");
            }

            return isValid;
        }

        private void SetForm()
        {
            if (this.Materia != null)
            {
                // Seleccionar el plan correspondiente en el ComboBox
                planCB.SelectedItem = planCB.Items
                    .Cast<ComboBoxItem>()
                    .FirstOrDefault(item => item.Value == this.Materia.id_plan);

                descTB.Text = this.Materia.desc_materia?.ToString();
                hsSemTB.Text = this.Materia.hs_semanales.ToString();
                hsTotTB.Text = this.Materia.hs_totales.ToString();
            }
        }

        private void MateriaRegistro_Load(object sender, EventArgs e)
        {
            if (this.EditMode && this.Materia != null)
            {
                this.SetForm();
            }
        }
    }

    // Clase auxiliar para representar items en el ComboBox
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
