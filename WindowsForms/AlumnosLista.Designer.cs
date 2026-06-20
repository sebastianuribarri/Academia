namespace WindowsForms
{
    partial class AlumnosLista
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            alumnosDataGridView = new DataGridView();
            eliminarButton = new Button();
            modificarButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)alumnosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // alumnosDataGridView
            // 
            alumnosDataGridView.AllowUserToOrderColumns = true;
            alumnosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alumnosDataGridView.Location = new Point(24, 69);
            alumnosDataGridView.Margin = new Padding(2, 1, 2, 1);
            alumnosDataGridView.MultiSelect = false;
            alumnosDataGridView.Name = "alumnosDataGridView";
            alumnosDataGridView.ReadOnly = true;
            alumnosDataGridView.RowHeadersWidth = 82;
            alumnosDataGridView.RowTemplate.Height = 41;
            alumnosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            alumnosDataGridView.Size = new Size(858, 459);
            alumnosDataGridView.TabIndex = 0;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(677, 29);
            eliminarButton.Margin = new Padding(2, 1, 2, 1);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(93, 28);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(789, 29);
            modificarButton.Margin = new Padding(2, 1, 2, 1);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(93, 28);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(121, 37);
            label1.TabIndex = 13;
            label1.Text = "Alumnos";
            label1.Click += label1_Click;
            // 
            // AlumnosLista
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 580);
            Controls.Add(label1);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(alumnosDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AlumnosLista";
            Text = "Alumnos";
            Load += Alumnos_Load;
            ((System.ComponentModel.ISupportInitialize)alumnosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView alumnosDataGridView;
        private Button eliminarButton;
        private Button modificarButton;
        private Label label1;
    }
}