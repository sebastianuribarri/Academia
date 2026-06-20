using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
namespace WindowsForms
{
    partial class PersonaRegistro
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            nombreTB = new TextBox();
            nombreLabel = new Label();
            aceptarButton = new Button();
            cancelarButton = new Button();
            errorProvider = new ErrorProvider(components);
            label1 = new Label();
            emailLabel = new Label();
            emailTB = new TextBox();
            telefonoLabel = new Label();
            telefonoTB = new TextBox();
            fechaNacimientoLabel = new Label();
            fechaNacimientoPicker = new DateTimePicker();
            txtBoxApellido = new TextBox();
            txtBoxDireccion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tipoCB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // nombreTB
            // 
            nombreTB.Location = new Point(200, 29);
            nombreTB.Name = "nombreTB";
            nombreTB.Size = new Size(250, 26);
            nombreTB.TabIndex = 0;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(31, 29);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(62, 19);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(234, 333);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(100, 30);
            aceptarButton.TabIndex = 14;
            aceptarButton.Text = "Aceptar";
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(108, 333);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(100, 30);
            cancelarButton.TabIndex = 15;
            cancelarButton.Text = "Cancelar";
            cancelarButton.Click += cancelarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            errorProvider.SetIconAlignment(label1, ErrorIconAlignment.BottomLeft);
            label1.Location = new Point(31, 66);
            label1.Name = "label1";
            label1.Size = new Size(61, 19);
            label1.TabIndex = 17;
            label1.Text = "Apellido:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(30, 147);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(44, 19);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // emailTB
            // 
            emailTB.Location = new Point(200, 147);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(250, 26);
            emailTB.TabIndex = 3;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new Point(30, 187);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(63, 19);
            telefonoLabel.TabIndex = 4;
            telefonoLabel.Text = "Teléfono:";
            // 
            // telefonoTB
            // 
            telefonoTB.Location = new Point(200, 184);
            telefonoTB.Name = "telefonoTB";
            telefonoTB.Size = new Size(250, 26);
            telefonoTB.TabIndex = 5;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new Point(30, 227);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new Size(139, 19);
            fechaNacimientoLabel.TabIndex = 6;
            fechaNacimientoLabel.Text = "Fecha de Nacimiento:";
            // 
            // fechaNacimientoPicker
            // 
            fechaNacimientoPicker.Format = DateTimePickerFormat.Short;
            fechaNacimientoPicker.Location = new Point(200, 221);
            fechaNacimientoPicker.Name = "fechaNacimientoPicker";
            fechaNacimientoPicker.Size = new Size(250, 26);
            fechaNacimientoPicker.TabIndex = 7;
            // 
            // txtBoxApellido
            // 
            txtBoxApellido.Location = new Point(200, 66);
            txtBoxApellido.Name = "txtBoxApellido";
            txtBoxApellido.Size = new Size(250, 26);
            txtBoxApellido.TabIndex = 16;
            // 
            // txtBoxDireccion
            // 
            txtBoxDireccion.Location = new Point(200, 106);
            txtBoxDireccion.Name = "txtBoxDireccion";
            txtBoxDireccion.Size = new Size(250, 26);
            txtBoxDireccion.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 106);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 19;
            label2.Text = "direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 271);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 20;
            label3.Text = "Tipo de usuario:";
            // 
            // tipoCB
            // 
            tipoCB.FormattingEnabled = true;
            tipoCB.Location = new Point(200, 268);
            tipoCB.Name = "tipoCB";
            tipoCB.Size = new Size(250, 27);
            tipoCB.TabIndex = 30;
            // 
            // PersonaRegistro
            // 
            ClientSize = new Size(462, 386);
            Controls.Add(tipoCB);
            Controls.Add(label3);
            Controls.Add(txtBoxDireccion);
            Controls.Add(label2);
            Controls.Add(txtBoxApellido);
            Controls.Add(label1);
            Controls.Add(nombreTB);
            Controls.Add(nombreLabel);
            Controls.Add(emailLabel);
            Controls.Add(emailTB);
            Controls.Add(telefonoLabel);
            Controls.Add(telefonoTB);
            Controls.Add(fechaNacimientoLabel);
            Controls.Add(fechaNacimientoPicker);
            Controls.Add(aceptarButton);
            Controls.Add(cancelarButton);
            Name = "PersonaRegistro";
            Text = "Registro de Persona";
            Load += PersonaRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox nombreTB;
        private Label nombreLabel;
        private TextBox emailTB;
        private Label emailLabel;
        private TextBox telefonoTB;
        private Label telefonoLabel;
        private DateTimePicker fechaNacimientoPicker;
        private Label fechaNacimientoLabel;
        private Button aceptarButton;
        private Button cancelarButton;

        #endregion

        private TextBox txtBoxDireccion;
        private Label label2;
        private TextBox txtBoxApellido;
        private Label label1;
        private TextBox usernameTB;
        private Label label3;
        private TextBox textBox2;
        private ComboBox tipoCB;
    }
}
