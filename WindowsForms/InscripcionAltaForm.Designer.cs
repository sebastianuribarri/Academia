namespace WindowsForms
{
    partial class InscripcionAltaForm
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
            idCursoLabel = new Label();
            aceptarButton = new Button();
            cancelarButton = new Button();
            idAlumnoLabel = new Label();
            materiaComboBox = new ComboBox();
            comisionComboBox = new ComboBox();
            SuspendLayout();
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new Point(27, 60);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new Size(61, 15);
            idCursoLabel.TabIndex = 51;
            idCursoLabel.Text = "Comision:";
            idCursoLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(81, 116);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(100, 30);
            aceptarButton.TabIndex = 48;
            aceptarButton.Text = "Aceptar";
            aceptarButton.Click += aceptarButton_Click_1;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(200, 116);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(100, 30);
            cancelarButton.TabIndex = 49;
            cancelarButton.Text = "Cancelar";
            cancelarButton.Click += cancelarButton_Click_1;
            // 
            // idAlumnoLabel
            // 
            idAlumnoLabel.AutoSize = true;
            idAlumnoLabel.Location = new Point(27, 23);
            idAlumnoLabel.Name = "idAlumnoLabel";
            idAlumnoLabel.Size = new Size(50, 15);
            idAlumnoLabel.TabIndex = 45;
            idAlumnoLabel.Text = "Materia:";
            // 
            // materiaComboBox
            // 
            materiaComboBox.FormattingEnabled = true;
            materiaComboBox.Location = new Point(136, 23);
            materiaComboBox.Margin = new Padding(3, 2, 3, 2);
            materiaComboBox.Name = "materiaComboBox";
            materiaComboBox.Size = new Size(250, 23);
            materiaComboBox.TabIndex = 54;
            // 
            // comisionComboBox
            // 
            comisionComboBox.FormattingEnabled = true;
            comisionComboBox.Location = new Point(136, 60);
            comisionComboBox.Margin = new Padding(3, 2, 3, 2);
            comisionComboBox.Name = "comisionComboBox";
            comisionComboBox.Size = new Size(250, 23);
            comisionComboBox.TabIndex = 55;
            // 
            // InscripcionAltaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 176);
            Controls.Add(comisionComboBox);
            Controls.Add(materiaComboBox);
            Controls.Add(idCursoLabel);
            Controls.Add(idAlumnoLabel);
            Controls.Add(aceptarButton);
            Controls.Add(cancelarButton);
            Name = "InscripcionAltaForm";
            Text = "Registro de inscripcion";
            Load += InscripcionAltaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label idCursoLabel;
        private Button aceptarButton;
        private Button cancelarButton;
        private Label idAlumnoLabel;
        private ComboBox materiaComboBox;
        private ComboBox comisionComboBox;
    }
}