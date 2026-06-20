namespace WindowsForms
{
    partial class CursoRegistro
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
            anioTxtBox = new TextBox();
            anioLabel = new Label();
            idComisionLabel = new Label();
            idMateriaLabel = new Label();
            cupoLabel = new Label();
            cupoTextBox = new TextBox();
            aceptarButton = new Button();
            cancelarButton = new Button();
            materiaCB = new ComboBox();
            comisionCB = new ComboBox();
            SuspendLayout();
            // 
            // anioTxtBox
            // 
            anioTxtBox.Location = new Point(150, 135);
            anioTxtBox.Margin = new Padding(3, 4, 3, 4);
            anioTxtBox.Name = "anioTxtBox";
            anioTxtBox.Size = new Size(285, 26);
            anioTxtBox.TabIndex = 32;
            // 
            // anioLabel
            // 
            anioLabel.AutoSize = true;
            anioLabel.Location = new Point(32, 135);
            anioLabel.Name = "anioLabel";
            anioLabel.Size = new Size(37, 19);
            anioLabel.TabIndex = 33;
            anioLabel.Text = "Año:";
            // 
            // idComisionLabel
            // 
            idComisionLabel.AutoSize = true;
            idComisionLabel.Location = new Point(32, 85);
            idComisionLabel.Name = "idComisionLabel";
            idComisionLabel.Size = new Size(69, 19);
            idComisionLabel.TabIndex = 31;
            idComisionLabel.Text = "Comision:";
            idComisionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // idMateriaLabel
            // 
            idMateriaLabel.AutoSize = true;
            idMateriaLabel.Location = new Point(32, 38);
            idMateriaLabel.Name = "idMateriaLabel";
            idMateriaLabel.Size = new Size(59, 19);
            idMateriaLabel.TabIndex = 21;
            idMateriaLabel.Text = "Materia:";
            // 
            // cupoLabel
            // 
            cupoLabel.AutoSize = true;
            cupoLabel.Location = new Point(31, 187);
            cupoLabel.Name = "cupoLabel";
            cupoLabel.Size = new Size(45, 19);
            cupoLabel.TabIndex = 22;
            cupoLabel.Text = "Cupo:";
            // 
            // cupoTextBox
            // 
            cupoTextBox.Location = new Point(150, 187);
            cupoTextBox.Margin = new Padding(3, 4, 3, 4);
            cupoTextBox.Name = "cupoTextBox";
            cupoTextBox.Size = new Size(285, 26);
            cupoTextBox.TabIndex = 23;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(122, 249);
            aceptarButton.Margin = new Padding(3, 4, 3, 4);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(92, 29);
            aceptarButton.TabIndex = 28;
            aceptarButton.Text = "Aceptar";
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(236, 249);
            cancelarButton.Margin = new Padding(3, 4, 3, 4);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(84, 29);
            cancelarButton.TabIndex = 29;
            cancelarButton.Text = "Cancelar";
            cancelarButton.Click += cancelarButton_Click;
            // 
            // materiaCB
            // 
            materiaCB.FormattingEnabled = true;
            materiaCB.Location = new Point(150, 35);
            materiaCB.Name = "materiaCB";
            materiaCB.Size = new Size(285, 27);
            materiaCB.TabIndex = 34;
            // 
            // comisionCB
            // 
            comisionCB.FormattingEnabled = true;
            comisionCB.Location = new Point(150, 85);
            comisionCB.Name = "comisionCB";
            comisionCB.Size = new Size(285, 27);
            comisionCB.TabIndex = 35;
            // 
            // CursoRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 296);
            Controls.Add(comisionCB);
            Controls.Add(materiaCB);
            Controls.Add(anioTxtBox);
            Controls.Add(anioLabel);
            Controls.Add(idComisionLabel);
            Controls.Add(idMateriaLabel);
            Controls.Add(cupoLabel);
            Controls.Add(cupoTextBox);
            Controls.Add(aceptarButton);
            Controls.Add(cancelarButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CursoRegistro";
            Text = "Registro de curso";
            Load += CursoRegistro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox anioTxtBox;
        private Label anioLabel;
        private Label idComisionLabel;
        private Label idMateriaLabel;
        private Label cupoLabel;
        private TextBox cupoTextBox;
        private Button aceptarButton;
        private Button cancelarButton;
        private ComboBox materiaCB;
        private ComboBox comisionCB;
    }
}