namespace WindowsForms
{
    partial class DocenteForm
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
            inscripcionesDataGridView = new DataGridView();
            modificarBtn = new Button();
            searchBar = new TextBox();
            cerrarSesionButton = new Button();
            buscarBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)inscripcionesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // inscripcionesDataGridView
            // 
            inscripcionesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inscripcionesDataGridView.Location = new Point(30, 63);
            inscripcionesDataGridView.Name = "inscripcionesDataGridView";
            inscripcionesDataGridView.Size = new Size(1006, 466);
            inscripcionesDataGridView.TabIndex = 0;
            // 
            // modificarBtn
            // 
            modificarBtn.Location = new Point(844, 16);
            modificarBtn.Name = "modificarBtn";
            modificarBtn.Size = new Size(75, 34);
            modificarBtn.TabIndex = 1;
            modificarBtn.Text = "Modificar";
            modificarBtn.UseVisualStyleBackColor = true;
            modificarBtn.Click += modificarBtn_Click;
            // 
            // searchBar
            // 
            searchBar.Location = new Point(30, 21);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Buscar...";
            searchBar.Size = new Size(306, 26);
            searchBar.TabIndex = 2;        // 
            // cerrarSesionButton
            // 
            cerrarSesionButton.Location = new Point(925, 16);
            cerrarSesionButton.Name = "cerrarSesionButton";
            cerrarSesionButton.Size = new Size(102, 34);
            cerrarSesionButton.TabIndex = 3;
            cerrarSesionButton.Text = "Cerrar Sesion";
            cerrarSesionButton.UseVisualStyleBackColor = true;
            cerrarSesionButton.Click += cerrarSesionButton_Click;
            // 
            // buscarBtn
            // 
            buscarBtn.Location = new Point(342, 20);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(75, 26);
            buscarBtn.TabIndex = 4;
            buscarBtn.Text = "Buscar";
            buscarBtn.UseVisualStyleBackColor = true;
            buscarBtn.Click += buscarBtn_Click;
            // 
            // DocenteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 580);
            Controls.Add(buscarBtn);
            Controls.Add(cerrarSesionButton);
            Controls.Add(searchBar);
            Controls.Add(modificarBtn);
            Controls.Add(inscripcionesDataGridView);
            Name = "DocenteForm";
            Text = "DocenteForm";
            Load += DocenteForm_Load;
            ((System.ComponentModel.ISupportInitialize)inscripcionesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView inscripcionesDataGridView;
        private Button modificarBtn;
        private TextBox searchBar;
        private Button cerrarSesionButton;
        private Button buscarBtn;
    }
}