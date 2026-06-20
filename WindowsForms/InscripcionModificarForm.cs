using Entities;
using ApiClient;
using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class InscripcionModificar : Form
    {
        private Inscripcion inscripcion;
        private InscripcionApiClient inscripcionApiClient = new InscripcionApiClient();

        public Inscripcion Inscripcion
        {
            get { return inscripcion; }
            set
            {
                inscripcion = value;
                this.SetForm();
            }
        }

        public InscripcionModificar()
        {
            InitializeComponent();
        }

        private void SetForm()
        {
            if (this.Inscripcion != null)
            {
                notaTB.Text = this.Inscripcion.nota?.ToString() ?? string.Empty;
                condicionCB.SelectedItem = this.Inscripcion.condicion;
            }
        }

        private bool ValidateInscripcion()
        {
            bool isValid = true;

            // Validar condición
            string selectedCondition = condicionCB.SelectedItem as string;

            // Si la condición es "Aprobado", verificar que la nota esté presente
            if (selectedCondition == "Aprobado")
            {
                if (int.TryParse(notaTB.Text, out int nota) && nota >= 0 && nota <= 10)
                {
                    this.Inscripcion.nota = nota;
                }
                else
                {
                    MessageBox.Show("Debe ingresar una nota válida entre 0 y 10 para condición Aprobado.");
                    isValid = false;
                }
            }
            else
            {
                this.Inscripcion.nota = null;
            }

            this.Inscripcion.condicion = selectedCondition;

            return isValid;
        }

        private void InscripcionModificar_Load(object sender, EventArgs e)
        {
            // Configurar las opciones del ComboBox
            condicionCB.Items.Add("Cursando");
            condicionCB.Items.Add("Regular");
            condicionCB.Items.Add("Aprobado");
            condicionCB.Items.Add("Recursa");

            this.SetForm();
        }

        private async void aceptarBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateInscripcion())
            {
                bool exito = await ErrorHandler.ExecuteApiCallAsync(() => inscripcionApiClient.UpdateAsync(this.Inscripcion));
                if(exito) this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            notaTB = new TextBox();
            label1 = new Label();
            aceptarBtn = new Button();
            cancelBtn = new Button();
            condicionCB = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // notaTB
            // 
            notaTB.Location = new Point(141, 141);
            notaTB.Name = "notaTB";
            notaTB.Size = new Size(231, 26);
            notaTB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 141);
            label1.Name = "label1";
            label1.Size = new Size(42, 19);
            label1.TabIndex = 1;
            label1.Text = "Nota:";
            // 
            // aceptarBtn
            // 
            aceptarBtn.Location = new Point(203, 198);
            aceptarBtn.Name = "aceptarBtn";
            aceptarBtn.Size = new Size(75, 33);
            aceptarBtn.TabIndex = 2;
            aceptarBtn.Text = "Aceptar";
            aceptarBtn.UseVisualStyleBackColor = true;
            aceptarBtn.Click += aceptarBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(102, 198);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 33);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "cancelar";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // condicionCB
            // 
            condicionCB.FormattingEnabled = true;
            condicionCB.Location = new Point(141, 70);
            condicionCB.Name = "condicionCB";
            condicionCB.Size = new Size(231, 27);
            condicionCB.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 73);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 5;
            label2.Text = "Condicion:";
            // 
            // InscripcionModificar
            // 
            ClientSize = new Size(395, 243);
            Controls.Add(label2);
            Controls.Add(condicionCB);
            Controls.Add(cancelBtn);
            Controls.Add(aceptarBtn);
            Controls.Add(label1);
            Controls.Add(notaTB);
            Name = "InscripcionModificar";
            Load += InscripcionModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
