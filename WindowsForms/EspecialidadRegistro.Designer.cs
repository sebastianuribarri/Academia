using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
namespace WindowsForms
{
    partial class EspecialidadRegistro
    {
        private System.ComponentModel.IContainer components = null;
#pragma warning disable CS0649 // El campo 'EspecialidadRegistro.errorProvider' nunca se asigna y siempre tendrá el valor predeterminado null
        private System.Windows.Forms.ErrorProvider errorProvider;
#pragma warning restore CS0649 // El campo 'EspecialidadRegistro.errorProvider' nunca se asigna y siempre tendrá el valor predeterminado null

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

#pragma warning disable CS0169 // El campo 'EspecialidadRegistro.txtBoxDescripcion' nunca se usa
        private TextBox txtBoxDescripcion;
#pragma warning restore CS0169 // El campo 'EspecialidadRegistro.txtBoxDescripcion' nunca se usa
        private TextBox descripcionTB;
        private Label label1;
        private Button aceptarBtn;
        private Button cancelBtn;
    }
}
