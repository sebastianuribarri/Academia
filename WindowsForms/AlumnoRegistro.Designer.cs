

namespace WindowsForms
{
    
    partial class AlumnoRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            usernameTB = new TextBox();
            nombreAlumnoLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            claveLabel = new Label();
            claveTB = new TextBox();
            legajoLabel = new Label();
            legajoTB = new TextBox();
            idPlanLabel = new Label();
            planCB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(189, 22);
            usernameTB.Margin = new Padding(2, 1, 2, 1);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(258, 26);
            usernameTB.TabIndex = 0;
            // 
            // nombreAlumnoLabel
            // 
            nombreAlumnoLabel.AutoSize = true;
            nombreAlumnoLabel.Location = new Point(38, 25);
            nombreAlumnoLabel.Margin = new Padding(2, 0, 2, 0);
            nombreAlumnoLabel.Name = "nombreAlumnoLabel";
            nombreAlumnoLabel.Size = new Size(130, 19);
            nombreAlumnoLabel.TabIndex = 1;
            nombreAlumnoLabel.Text = "Nombre de usuario:";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(249, 237);
            aceptarButton.Margin = new Padding(2, 1, 2, 1);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(93, 28);
            aceptarButton.TabIndex = 2;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(101, 237);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(93, 28);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new Point(38, 73);
            claveLabel.Margin = new Padding(2, 0, 2, 0);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new Size(45, 19);
            claveLabel.TabIndex = 7;
            claveLabel.Text = "Clave:";
            // 
            // claveTB
            // 
            claveTB.Location = new Point(189, 70);
            claveTB.Margin = new Padding(2, 1, 2, 1);
            claveTB.Name = "claveTB";
            claveTB.PasswordChar = '*';
            claveTB.Size = new Size(258, 26);
            claveTB.TabIndex = 12;
            // 
            // legajoLabel
            // 
            legajoLabel.AutoSize = true;
            legajoLabel.Location = new Point(40, 116);
            legajoLabel.Margin = new Padding(2, 0, 2, 0);
            legajoLabel.Name = "legajoLabel";
            legajoLabel.Size = new Size(52, 19);
            legajoLabel.TabIndex = 17;
            legajoLabel.Text = "Legajo:";
            // 
            // legajoTB
            // 
            legajoTB.Location = new Point(189, 116);
            legajoTB.Margin = new Padding(2, 1, 2, 1);
            legajoTB.Name = "legajoTB";
            legajoTB.Size = new Size(258, 26);
            legajoTB.TabIndex = 18;
            // 
            // idPlanLabel
            // 
            idPlanLabel.AutoSize = true;
            idPlanLabel.Location = new Point(40, 171);
            idPlanLabel.Margin = new Padding(2, 0, 2, 0);
            idPlanLabel.Name = "idPlanLabel";
            idPlanLabel.Size = new Size(38, 19);
            idPlanLabel.TabIndex = 19;
            idPlanLabel.Text = "Plan:";
            // 
            // planCB
            // 
            planCB.FormattingEnabled = true;
            planCB.Location = new Point(189, 168);
            planCB.Name = "planCB";
            planCB.Size = new Size(258, 27);
            planCB.TabIndex = 20;
            // 
            // AlumnoRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 288);
            Controls.Add(planCB);
            Controls.Add(idPlanLabel);
            Controls.Add(legajoTB);
            Controls.Add(legajoLabel);
            Controls.Add(claveTB);
            Controls.Add(claveLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreAlumnoLabel);
            Controls.Add(usernameTB);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AlumnoRegistro";
            Text = "Registro alumno";
            Load += AlumnoRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTB;
        private Label nombreAlumnoLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label claveLabel;
#pragma warning disable CS0169 // El campo 'AlumnoRegistro.maskedTextBox1' nunca se usa
        private MaskedTextBox maskedTextBox1;
        private TextBox claveTB;
#pragma warning disable CS0169 // El campo 'AlumnoRegistro.tipoUserLabel' nunca se usa
        private Label tipoUserLabel;
#pragma warning restore CS0169 // El campo 'AlumnoRegistro.tipoUserLabel' nunca se usa
#pragma warning disable CS0169 // El campo 'AlumnoRegistro.TipoUsercomboBox' nunca se usa
        private ComboBox TipoUsercomboBox;
#pragma warning restore CS0169 // El campo 'AlumnoRegistro.TipoUsercomboBox' nunca se usa
        private Label legajoLabel;
        private Label idPlanLabel;
        private TextBox legajoTB;
        private ComboBox planCB;
    }
}