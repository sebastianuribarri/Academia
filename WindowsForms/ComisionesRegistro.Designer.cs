using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
namespace WindowsForms
{
    partial class ComisionRegistro
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
            planCB = new ComboBox();
            label2 = new Label();
            errorProvider = new ErrorProvider(components);
            label3 = new Label();
            anioTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // descripcionTB
            // 
            descripcionTB.Location = new Point(127, 50);
            descripcionTB.Name = "descripcionTB";
            descripcionTB.Size = new Size(231, 26);
            descripcionTB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 57);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 1;
            label1.Text = "Descripción:";
            // 
            // aceptarBtn
            // 
            aceptarBtn.Location = new Point(199, 223);
            aceptarBtn.Name = "aceptarBtn";
            aceptarBtn.Size = new Size(75, 33);
            aceptarBtn.TabIndex = 2;
            aceptarBtn.Text = "Aceptar";
            aceptarBtn.UseVisualStyleBackColor = true;
            aceptarBtn.Click += aceptarBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(83, 223);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 33);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancelar";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // planCB
            // 
            planCB.Location = new Point(127, 90);
            planCB.Name = "planCB";
            planCB.Size = new Size(231, 27);
            planCB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 98);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 5;
            label2.Text = "Plan:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 141);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 6;
            label3.Text = "Año lectivo:";
            // 
            // anioTB
            // 
            anioTB.Location = new Point(127, 138);
            anioTB.Name = "anioTB";
            anioTB.Size = new Size(231, 26);
            anioTB.TabIndex = 7;
            // 
            // ComisionRegistro
            // 
            ClientSize = new Size(374, 279);
            Controls.Add(anioTB);
            Controls.Add(label3);
            Controls.Add(cancelBtn);
            Controls.Add(aceptarBtn);
            Controls.Add(label2);
            Controls.Add(planCB);
            Controls.Add(label1);
            Controls.Add(descripcionTB);
            Name = "ComisionRegistro";
            Text = "Registro de Comision";
            Load += ComisionRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

#pragma warning disable CS0169 // El campo 'ComisionRegistro.txtBoxDescripcion' nunca se usa
        private TextBox txtBoxDescripcion;
#pragma warning restore CS0169 // El campo 'ComisionRegistro.txtBoxDescripcion' nunca se usa
        private TextBox descripcionTB;
        private Label label1;
        private Button aceptarBtn;
        private Button cancelBtn;
        private Label label2;
        private ComboBox planCB;
        private TextBox anioTB;
        private Label label3;
    }
}
