using ApiClient;
using Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class CursoLista : Form
    {
        private readonly CursoApiClient _apiClient;  // Cambiamos el tipo a ApiClient

        private List<CursoDto>? Cursos { get; set; }

        public CursoLista()
        {
            InitializeComponent();
            _apiClient = new CursoApiClient(); // Instanciamos el ApiClient

            //this.Load += new EventHandler(CursoLista_Load);
            this.eliminarButton.Click += new EventHandler(eliminarButton_Click);
            this.modificarButton.Click += new EventHandler(modificarButton_Click);
            //this.agregarButton.Click += new EventHandler(agregarButton_Click);
        }

        private async void agregarButton_Click(object sender, EventArgs e)
        {
            CursoRegistro cursoDetalle = new CursoRegistro();
            Curso cursoNueva = new Curso();
            cursoDetalle.Curso = cursoNueva;

            cursoDetalle.ShowDialog();

            if (cursoDetalle.Curso != null)
            {
                this.GetAllAndLoad();
            }
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            CursoRegistro cursoDetalle = new CursoRegistro();
            int id = this.SelectedItem().id_curso;

            // Obtenemos el curso desde la API
            Curso? curso = await _apiClient.GetAsync(id);

            if (curso != null)
            {
                cursoDetalle.EditMode = true;
                cursoDetalle.Curso = curso;

                cursoDetalle.ShowDialog();

                if (cursoDetalle.Curso != null)
                {
                    this.GetAllAndLoad();
                }
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id = this.SelectedItem().id_curso;
            await _apiClient.DeleteAsync(id);
            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            Cursos = await _apiClient.GetAllAsync();
            
            this.cursosDataGridView.DataSource = Cursos;
            this.cursosDataGridView.Refresh();
            this.cursosDataGridView.Columns[0].Visible = false;
            if (this.cursosDataGridView.Rows.Count > 0)
            {
                this.cursosDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private CursoDto SelectedItem()
        {
            return (CursoDto)cursosDataGridView.SelectedRows[0].DataBoundItem;
        }

        private void CursoLista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void generarReporteBtn_Click(object sender, EventArgs e)
        {
            ReporteCursosGenerator ReporteCursosGenerator = new ReporteCursosGenerator();
            string filePath = @"C:\Reportes\ReporteCursos.pdf";

            ReporteCursosGenerator.CreatePDFReport(filePath, Cursos);
            MessageBox.Show("Reporte generado en " + filePath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
