using ApiClient;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class DocenteForm : Form
    {
        private readonly int UsuarioId;
        public InscripcionApiClient inscripcionApiClient;
        private List<InscripcionDto> allInscripciones; // Almacena todas las inscripciones obtenidas

        public DocenteForm(int usuarioId)
        {
            UsuarioId = usuarioId;
            inscripcionApiClient = new InscripcionApiClient();
            InitializeComponent();
        }

        private async void modificarBtn_Click(object sender, EventArgs e)
        {
            InscripcionModificar inscripcionDetalle = new InscripcionModificar();
            int id = this.SelectedItem().id_inscripcion;

            // Obtenemos la inscripción desde la API
            Inscripcion? inscripcion = await inscripcionApiClient.GetAsync(id);

            if (inscripcion != null)
            {
                inscripcionDetalle.Inscripcion = inscripcion;

                inscripcionDetalle.ShowDialog();

                if (inscripcionDetalle.Inscripcion != null)
                {
                    this.GetAllAndLoad();
                }
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.inscripcionesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                allInscripciones = await inscripcionApiClient.GetInscripcionesDocenteAsync(UsuarioId);

                if (allInscripciones == null || !allInscripciones.Any())
                {
                    MessageBox.Show("No se encontraron inscripciones para este docente.");
                }

                // Mostrar todas las inscripciones al cargar
                this.inscripcionesDataGridView.DataSource = allInscripciones;
                this.inscripcionesDataGridView.Refresh();

                if (this.inscripcionesDataGridView.Rows.Count > 0)
                {
                    this.inscripcionesDataGridView.Rows[0].Selected = true;
                    this.modificarBtn.Enabled = true;
                }
                else
                {
                    this.modificarBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener inscripciones: {ex.Message}");
            }
        }

        private InscripcionDto? SelectedItem()
        {
            if (this.inscripcionesDataGridView.SelectedRows.Count > 0)
            {
                return (InscripcionDto)inscripcionesDataGridView.SelectedRows[0].DataBoundItem;
            }
            else
            {
                return null;
            }
        }

        private void DocenteForm_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }

        private void cerrarSesionButton_Click(object sender, EventArgs e)
        {
            // Cierra todas las ventanas hijas
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            // Cierra el formulario principal actual
            this.Hide();

            // Abre el formulario Login en una nueva instancia
            Login loginForm = new Login();
            loginForm.ShowDialog(); // Abre como diálogo modal

            // Cierra la aplicación si el login se cierra
            this.Close();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            // Filtrar la lista de inscripciones según el texto de búsqueda
            string searchText = searchBar.Text.ToLower();

            var filteredInscripciones = allInscripciones.Where(i =>
                (i.legajo.HasValue && i.legajo.ToString().Contains(searchText)) ||
                (!string.IsNullOrEmpty(i.nombre_apellido) && i.nombre_apellido.ToLower().Contains(searchText)) ||
                (!string.IsNullOrEmpty(i.especialidad) && i.especialidad.ToLower().Contains(searchText)) ||
                (!string.IsNullOrEmpty(i.plan) && i.plan.ToLower().Contains(searchText)) ||
                (!string.IsNullOrEmpty(i.materia) && i.materia.ToLower().Contains(searchText)) ||
                (!string.IsNullOrEmpty(i.comision) && i.comision.ToLower().Contains(searchText))

            ).ToList();
            this.inscripcionesDataGridView.Columns[0].Visible = false;
            // Actualizar el DataGridView con los resultados filtrados
            this.inscripcionesDataGridView.DataSource = filteredInscripciones;
            this.inscripcionesDataGridView.Refresh();

            // Configurar el estado del botón de modificar según haya resultados o no
            modificarBtn.Enabled = filteredInscripciones.Any();
        }
    }
}
