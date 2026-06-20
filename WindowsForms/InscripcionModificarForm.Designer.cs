using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
namespace WindowsForms
{
    partial class InscripcionModificar
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

        private TextBox txtBoxDescripcion;
        private TextBox notaTB;
        private Label label1;
        private Button aceptarBtn;
        private Button cancelBtn;
        private ComboBox condicionCB;
        private Label label2;
    }
}
