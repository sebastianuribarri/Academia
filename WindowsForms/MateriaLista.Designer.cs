namespace WindowsForms
{
    partial class MateriaLista
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
            modificarButton = new Button();
            eliminarButton = new Button();
            materiasDataGridView = new DataGridView();
            label1 = new Label();
            agregarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)materiasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(688, 32);
            modificarButton.Margin = new Padding(2, 1, 2, 1);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(93, 28);
            modificarButton.TabIndex = 11;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(583, 32);
            eliminarButton.Margin = new Padding(2, 1, 2, 1);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(93, 28);
            eliminarButton.TabIndex = 10;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // materiasDataGridView
            // 
            materiasDataGridView.AllowUserToOrderColumns = true;
            materiasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materiasDataGridView.Location = new Point(29, 80);
            materiasDataGridView.Margin = new Padding(2, 1, 2, 1);
            materiasDataGridView.MultiSelect = false;
            materiasDataGridView.Name = "materiasDataGridView";
            materiasDataGridView.ReadOnly = true;
            materiasDataGridView.RowHeadersWidth = 82;
            materiasDataGridView.RowTemplate.Height = 41;
            materiasDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            materiasDataGridView.Size = new Size(858, 480);
            materiasDataGridView.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(40, 23);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 12;
            label1.Text = "Materias";
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(794, 32);
            agregarButton.Margin = new Padding(2, 1, 2, 1);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(93, 28);
            agregarButton.TabIndex = 9;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            // 
            // MateriaLista
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 612);
            Controls.Add(label1);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(materiasDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MateriaLista";
            Text = "MateriaLista";
            Load += MateriaLista_Load;
            ((System.ComponentModel.ISupportInitialize)materiasDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button modificarButton;
        private Button eliminarButton;
        private DataGridView materiasDataGridView;
        private Label label1;
        private Button agregarButton;
    }
}