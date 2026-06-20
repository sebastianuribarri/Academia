using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
namespace WindowsForms
{
    partial class PlanRegistro
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ErrorProvider errorProvider;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            descripcionTB = new TextBox();
            label1 = new Label();
            aceptarBtn = new Button();
            cancelBtn = new Button();
            especialidadCB = new ComboBox();
            label2 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // descripcionTB
            // 
            descripcionTB.Location = new Point(127, 50);
            descripcionTB.Name = "descripcionTB";
            descripcionTB.Size = new Size(231, 23);
            descripcionTB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Descripción:";
            // 
            // aceptarBtn
            // 
            aceptarBtn.Location = new Point(195, 160);
            aceptarBtn.Name = "aceptarBtn";
            aceptarBtn.Size = new Size(75, 33);
            aceptarBtn.TabIndex = 2;
            aceptarBtn.Text = "Aceptar";
            aceptarBtn.UseVisualStyleBackColor = true;
            aceptarBtn.Click += aceptarBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(84, 160);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 33);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancelar";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // especialidadCB
            // 
            especialidadCB.Location = new Point(127, 90);
            especialidadCB.Name = "especialidadCB";
            especialidadCB.Size = new Size(231, 23);
            especialidadCB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "Especialidad:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // PlanRegistro
            // 
            ClientSize = new Size(374, 220);
            Controls.Add(cancelBtn);
            Controls.Add(aceptarBtn);
            Controls.Add(label2);
            Controls.Add(especialidadCB);
            Controls.Add(label1);
            Controls.Add(descripcionTB);
            Name = "PlanRegistro";
            Text = "Registro de Plan";
            Load += PlanRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

#pragma warning disable CS0169 // El campo 'PlanRegistro.txtBoxDescripcion' nunca se usa
        private TextBox txtBoxDescripcion;
#pragma warning restore CS0169 // El campo 'PlanRegistro.txtBoxDescripcion' nunca se usa
        private TextBox descripcionTB;
        private Label label1;
        private Button aceptarBtn;
        private Button cancelBtn;
        private Label label2;
        private ComboBox especialidadCB;
    }
}
