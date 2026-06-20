using Entities;
using ApiClient;

namespace WindowsForms
{
    public partial class PlanesLista : Form
    {
        public PlanApiClient planApiClient;

        public PlanesLista()
        {
            InitializeComponent();
            planApiClient = new PlanApiClient();

        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            PlanRegistro planDetalle = new PlanRegistro();

            Plan planNuevo = new Plan();

            planDetalle.Plan = planNuevo;

            planDetalle.ShowDialog();

            if (planDetalle.Plan != null)
            {
                this.GetAllAndLoad();
            }
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            PlanRegistro planDetalle = new PlanRegistro();
            Plan? plan = null;


            if (this.SelectedItem() != null)
            {

                int id = this.SelectedItem().id_plan;
                plan = await planApiClient.GetAsync(id);

                if (plan != null)
                {
                    planDetalle.EditMode = true;
                    planDetalle.Plan = plan;

                    planDetalle.ShowDialog();

                    GetAllAndLoad();
                }
            }
        }


        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            if (this.SelectedItem() != null)
            {
                int id = this.SelectedItem().id_plan;
                await ErrorHandler.ExecuteApiCallAsync(() => planApiClient.DeleteAsync(id));
            }
            else
            {
                return;
            }

            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            
            this.planesDataGridView.DataSource = await planApiClient.GetAllAsync();
            this.planesDataGridView.Refresh();
            this.planesDataGridView.Columns[0].Visible = false;
            if (this.planesDataGridView.Rows.Count > 0)
            {
                this.planesDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private PlanDto? SelectedItem()
        {
            if (this.planesDataGridView.SelectedRows.Count > 0)
            {
                return (PlanDto)planesDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                return null;
            }
        }
    }
}
