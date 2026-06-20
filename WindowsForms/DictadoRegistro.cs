using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entities;
using ApiClient;
using System.Numerics;
using Newtonsoft.Json.Linq;

namespace WindowsForms
{
    public partial class DictadoRegistro : Form
    {
        private Dictado dictado;
        private DictadoApiClient dictadoApiClient = new DictadoApiClient();
        private CursoApiClient cursoApiClient = new CursoApiClient();
        private ErrorProvider errorProvider;

        public Dictado Dictado
        {
            get { return dictado; }
            set
            {
                dictado = value;
            }
        }

        public bool EditMode { get; set; } = false;

        public DictadoRegistro()
        {
            InitializeComponent();

            errorProvider = new ErrorProvider()
            {
                BlinkStyle = ErrorBlinkStyle.NeverBlink
            };

            if (this.Dictado == null)
            {
                this.Dictado = new Dictado();
            }

        }

        private async Task SetDictado()
        {
            if (this.Dictado != null)
            {
                int legajoDocente;


                if (cursoCB.SelectedItem != null)
                {
                    this.Dictado.id_curso = ((CursoCBItem)cursoCB.SelectedItem).value;
                }
                if (cursoCB.SelectedItem != null)
                {
                    this.Dictado.cargo = ((Cargo)cargoCB.SelectedItem).Value;
                }
                if (int.TryParse(legajoDocenteTB.Text, out legajoDocente))
                {
                    var usuario = await new UsuarioApiClient().GetByLegajoAsync(legajoDocente); // Obtener usuario por legajo
                    if (usuario != null)
                    {
                        this.Dictado.id_docente = usuario.id_usuario; // Asignar id_usuario
                    }
                    else
                    {
                        MessageBox.Show("Docente no encontrado.");
                    }
                }


            }
        }

        private bool ValidateDictado()
        {
            bool isValid = true;

            // Limpiar errores previos
            errorProvider.SetError(legajoDocenteTB, string.Empty);

            


            // Validación del campo idDocente
            if (string.IsNullOrWhiteSpace(legajoDocenteTB.Text) || !int.TryParse(legajoDocenteTB.Text, out int idDocente))
            {
                isValid = false;
                errorProvider.SetError(legajoDocenteTB, "El ID del docente es requerido y debe ser numérico.");
            }

            return isValid;
        }

        private void SetForm()
        {
            if (this.Dictado != null)
            {
                
                legajoDocenteTB.Text = this.Dictado.Usuario.legajo.ToString();

                cargoCB.SelectedValue = this.Dictado.cargo;
                
                if (this.Dictado.id_curso != 0)
                {
                    cursoCB.SelectedValue = this.Dictado.id_curso;
                }
            }
        }

        private void DictadoRegistro_Load(object sender, EventArgs e)
        {
            cargoCB.Items.Clear();
            cargoCB.DisplayMember = "Display";
            cargoCB.ValueMember = "Value";
            var tipos = new List<Cargo>()
            {
               new Cargo { Value ="DOCENTE", Display = "DOCENTE" },
                new Cargo { Value = "JEFE DE CATEDRA", Display = "JEFE DE CATEDRA" },
                new Cargo { Value = "AYUDANTE", Display = "AYUDANTE" }
            };

            cargoCB.DataSource = tipos;
            cargoCB.SelectedItem = new Cargo  { Value = "DOCENTE", Display = "DOCENTE" };
            this.LoadCursosAsync();
            if (this.EditMode && this.Dictado != null)
            {
                this.SetForm();
            }
        }


     

        private async void aceptarButton_Click_1(object sender, EventArgs e)
        {
            if (this.ValidateDictado())
            {
                await this.SetDictado();
                bool exito = true;
                if (this.EditMode)
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => dictadoApiClient.UpdateAsync(Dictado));
                }
                else
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => dictadoApiClient.AddAsync(Dictado));
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

        private async Task LoadCursosAsync()
        {
            try
            {
                // Use GetByUsuarioAsync to get available courses for the user
                var cursos = await cursoApiClient.GetAllAsync();

                // Create a list of CursoCBItem for the ComboBox
                var cursosItems = new List<CursoCBItem>();
                foreach (var curso in cursos)
                {
                    cursosItems.Add(new CursoCBItem
                    {
                        value = curso.id_curso,
                        display = $"{curso.Materia} - {curso.Comision}",
                    });
                }

                // Assign the cursosItems list to the ComboBox
                cursoCB.DataSource = cursosItems;
                cursoCB.DisplayMember = "display";
                cursoCB.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading materias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    public class Cargo
    {
        public string Value { get; set; }
        public string Display { get; set; }
    }

    public class CursoCBItem
    {
        public int value { get; set; }
        public string display { get; set; }
    }


}
