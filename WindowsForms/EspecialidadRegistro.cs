using Entities;
using ApiClient;
using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class EspecialidadRegistro : Form
    {
        private Especialidad especialidad;

        // El servicio de Especialidad para las operaciones CRUD
        private EspecialidadesApiClient especialidadApiClient = new EspecialidadesApiClient();

        public Especialidad Especialidad
        {
            get { return especialidad; }
            set
            {
                especialidad = value;
                this.SetForm();
            }
        }

        public bool EditMode { get; set; } = false;

        public EspecialidadRegistro()
        {
            InitializeComponent();
        }

        private void SetEspecialidad()
        {
            if (this.Especialidad != null)
            {
                this.Especialidad.desc_especialidad = descripcionTB.Text;
            }
        }
        private void SetForm()
        {
            if (this.Especialidad != null)
            {
                descripcionTB.Text = this.Especialidad.desc_especialidad;
            }
        }

        private bool ValidateEspecialidad()
        {
            bool isValid = true;


            if (this.descripcionTB.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(descripcionTB, "la descripcion es requerida.");
            }


            return isValid;
        }

  


        private void InitializeComponent()
        {
            descripcionTB = new TextBox();
            label1 = new Label();
            aceptarBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // descripcionTB
            // 
            descripcionTB.Location = new Point(147, 30);
            descripcionTB.Name = "descripcionTB";
            descripcionTB.Size = new Size(231, 26);
            descripcionTB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 33);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 1;
            label1.Text = "Descripcion:";
            // 
            // aceptarBtn
            // 
            aceptarBtn.Location = new Point(210, 95);
            aceptarBtn.Name = "aceptarBtn";
            aceptarBtn.Size = new Size(75, 33);
            aceptarBtn.TabIndex = 2;
            aceptarBtn.Text = "Aceptar";
            aceptarBtn.UseVisualStyleBackColor = true;
            aceptarBtn.Click += aceptarBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(90, 95);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 33);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "cancelar";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // EspecialidadRegistro
            // 
            ClientSize = new Size(395, 155);
            Controls.Add(cancelBtn);
            Controls.Add(aceptarBtn);
            Controls.Add(label1);
            Controls.Add(descripcionTB);
            Name = "EspecialidadRegistro";
            Load += EspecialidadRegistro_Load_2;
            ResumeLayout(false);
            PerformLayout();
        }

        private void EspecialidadRegistro_Load_2(object sender, EventArgs e)
        {
            this.SetForm();

        }

        private async void aceptarBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateEspecialidad())
            {
                this.SetEspecialidad();
                bool exito;
                if (EditMode)
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => especialidadApiClient.UpdateAsync(Especialidad));
                }
                else
                {
                    exito = await ErrorHandler.ExecuteApiCallAsync(() => especialidadApiClient.AddAsync(Especialidad));
                }
                if (exito)
                {
                    Close();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
