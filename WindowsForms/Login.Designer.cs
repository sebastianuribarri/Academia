namespace WindowsForms
{
    partial class Login
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
            usuarioTextBox = new TextBox();
            contrasenaTextBox = new TextBox();
            usuarioLabel = new Label();
            contrasenaLabel = new Label();
            iniciarSesionButton = new Button();
            SuspendLayout();
            // 
            // usuarioTextBox
            // 
            usuarioTextBox.Location = new Point(312, 81);
            usuarioTextBox.Margin = new Padding(3, 4, 3, 4);
            usuarioTextBox.Name = "usuarioTextBox";
            usuarioTextBox.Size = new Size(348, 26);
            usuarioTextBox.TabIndex = 0;
            // 
            // contrasenaTextBox
            // 
            contrasenaTextBox.Location = new Point(312, 185);
            contrasenaTextBox.Margin = new Padding(3, 4, 3, 4);
            contrasenaTextBox.Name = "contrasenaTextBox";
            contrasenaTextBox.Size = new Size(348, 26);
            contrasenaTextBox.TabIndex = 1;
            contrasenaTextBox.UseSystemPasswordChar = true;
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new Point(134, 81);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new Size(59, 19);
            usuarioLabel.TabIndex = 2;
            usuarioLabel.Text = "Usuario:";
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Location = new Point(134, 189);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new Size(82, 19);
            contrasenaLabel.TabIndex = 3;
            contrasenaLabel.Text = "Contraseña:";
            // 
            // iniciarSesionButton
            // 
            iniciarSesionButton.Location = new Point(358, 290);
            iniciarSesionButton.Margin = new Padding(3, 4, 3, 4);
            iniciarSesionButton.Name = "iniciarSesionButton";
            iniciarSesionButton.Size = new Size(133, 29);
            iniciarSesionButton.TabIndex = 4;
            iniciarSesionButton.Text = "Iniciar Sesion";
            iniciarSesionButton.UseVisualStyleBackColor = true;
            iniciarSesionButton.Click += iniciarSesionButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 419);
            Controls.Add(iniciarSesionButton);
            Controls.Add(contrasenaLabel);
            Controls.Add(usuarioLabel);
            Controls.Add(contrasenaTextBox);
            Controls.Add(usuarioTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Iniciar Sesion";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usuarioTextBox;
        private TextBox contrasenaTextBox;
        private Label usuarioLabel;
        private Label contrasenaLabel;
        private Button iniciarSesionButton;
    }
}