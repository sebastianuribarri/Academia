namespace WindowsForms
{
    partial class DocentesLista
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
            usuariosDataGridView = new DataGridView();
            eliminarButton = new Button();
            modificarButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)usuariosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // usuariosDataGridView
            // 
            usuariosDataGridView.AllowUserToOrderColumns = true;
            usuariosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usuariosDataGridView.Location = new Point(30, 79);
            usuariosDataGridView.Margin = new Padding(2, 1, 2, 1);
            usuariosDataGridView.MultiSelect = false;
            usuariosDataGridView.Name = "usuariosDataGridView";
            usuariosDataGridView.ReadOnly = true;
            usuariosDataGridView.RowHeadersWidth = 82;
            usuariosDataGridView.RowTemplate.Height = 41;
            usuariosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usuariosDataGridView.Size = new Size(858, 342);
            usuariosDataGridView.TabIndex = 0;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(687, 37);
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
            modificarButton.Location = new Point(795, 37);
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
            label1.Font = new Font("Segoe UI", 15.5F);
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 5;
            label1.Text = "Docentes";
            // 
            // DocentesLista
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 471);
            Controls.Add(label1);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(usuariosDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            Name = "DocentesLista";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)usuariosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView usuariosDataGridView;
        private Button eliminarButton;
        private Button modificarButton;
        private Label label1;
    }
}