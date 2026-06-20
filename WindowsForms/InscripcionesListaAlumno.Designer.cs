namespace WindowsForms
{
    partial class InscripcionesListaAlumno
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
            label1 = new Label();
            eliminarButton = new Button();
            agregarButton = new Button();
            inscripcionesDataGridView = new DataGridView();
            cerrarSesionbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)inscripcionesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 17;
            label1.Text = "Inscripciones";
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(488, 23);
            eliminarButton.Margin = new Padding(2, 1, 2, 1);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(81, 22);
            eliminarButton.TabIndex = 15;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(588, 23);
            agregarButton.Margin = new Padding(2, 1, 2, 1);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(81, 22);
            agregarButton.TabIndex = 14;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // inscripcionesDataGridView
            // 
            inscripcionesDataGridView.AllowUserToOrderColumns = true;
            inscripcionesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inscripcionesDataGridView.Location = new Point(25, 58);
            inscripcionesDataGridView.Margin = new Padding(2, 1, 2, 1);
            inscripcionesDataGridView.MultiSelect = false;
            inscripcionesDataGridView.Name = "inscripcionesDataGridView";
            inscripcionesDataGridView.ReadOnly = true;
            inscripcionesDataGridView.RowHeadersWidth = 82;
            inscripcionesDataGridView.RowTemplate.Height = 41;
            inscripcionesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inscripcionesDataGridView.Size = new Size(751, 379);
            inscripcionesDataGridView.TabIndex = 13;
            // 
            // cerrarSesionbutton
            // 
            cerrarSesionbutton.Location = new Point(684, 23);
            cerrarSesionbutton.Margin = new Padding(2, 1, 2, 1);
            cerrarSesionbutton.Name = "cerrarSesionbutton";
            cerrarSesionbutton.Size = new Size(92, 22);
            cerrarSesionbutton.TabIndex = 18;
            cerrarSesionbutton.Text = "Cerrar Sesion";
            cerrarSesionbutton.UseVisualStyleBackColor = true;
            cerrarSesionbutton.Click += cerrarSesionbutton_Click;
            // 
            // InscripcionesListaAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(cerrarSesionbutton);
            Controls.Add(label1);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(inscripcionesDataGridView);
            Name = "InscripcionesListaAlumno";
            Text = "InscripcionesListaAlumno";
            Load += InscripcionesListaAlumno_Load_1;
            ((System.ComponentModel.ISupportInitialize)inscripcionesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button eliminarButton;
        private Button agregarButton;
        private DataGridView inscripcionesDataGridView;
        private Button cerrarSesionbutton;
    }
}