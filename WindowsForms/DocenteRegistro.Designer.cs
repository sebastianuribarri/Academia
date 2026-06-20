

namespace WindowsForms
{
    
    partial class DocenteRegistro
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
            nombreUsuarioLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            claveLabel = new Label();
            claveTB = new TextBox();
            legajoLabel = new Label();
            legajoTextBox = new TextBox();
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
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Location = new Point(38, 25);
            nombreUsuarioLabel.Margin = new Padding(2, 0, 2, 0);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new Size(130, 19);
            nombreUsuarioLabel.TabIndex = 1;
            nombreUsuarioLabel.Text = "Nombre de usuario:";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(243, 188);
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
            cancelarButton.Location = new Point(117, 188);
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
            claveLabel.Location = new Point(38, 80);
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
            claveTB.Size = new Size(258, 26);
            claveTB.TabIndex = 12;
            // 
            // legajoLabel
            // 
            legajoLabel.AutoSize = true;
            legajoLabel.Location = new Point(38, 128);
            legajoLabel.Margin = new Padding(2, 0, 2, 0);
            legajoLabel.Name = "legajoLabel";
            legajoLabel.Size = new Size(52, 19);
            legajoLabel.TabIndex = 17;
            legajoLabel.Text = "Legajo:";
            // 
            // legajoTextBox
            // 
            legajoTextBox.Location = new Point(189, 128);
            legajoTextBox.Margin = new Padding(2, 1, 2, 1);
            legajoTextBox.Name = "legajoTextBox";
            legajoTextBox.Size = new Size(258, 26);
            legajoTextBox.TabIndex = 18;
            // 
            // DocenteRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 236);
            Controls.Add(legajoTextBox);
            Controls.Add(legajoLabel);
            Controls.Add(claveTB);
            Controls.Add(claveLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreUsuarioLabel);
            Controls.Add(usernameTB);
            Margin = new Padding(2, 1, 2, 1);
            Name = "DocenteRegistro";
            Text = "V";
            Load += UsuarioRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTB;
        private Label nombreUsuarioLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label claveLabel;
#pragma warning disable CS0169 // El campo 'UsuarioRegistro.maskedTextBox1' nunca se usa
        private MaskedTextBox maskedTextBox1;
        private TextBox claveTB;
        private Label legajoLabel;
        private TextBox legajoTextBox;
    }
}