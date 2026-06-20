namespace WindowsForms
{
    partial class EspecialidadesLista
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
            especialidadesDataGridView = new DataGridView();
            agregarButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)especialidadesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // especialidadesDataGridView
            // 
            especialidadesDataGridView.AllowUserToOrderColumns = true;
            especialidadesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            especialidadesDataGridView.Location = new Point(55, 84);
            especialidadesDataGridView.Margin = new Padding(2);
            especialidadesDataGridView.MultiSelect = false;
            especialidadesDataGridView.Name = "especialidadesDataGridView";
            especialidadesDataGridView.ReadOnly = true;
            especialidadesDataGridView.RowHeadersWidth = 82;
            especialidadesDataGridView.RowTemplate.Height = 41;
            especialidadesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            especialidadesDataGridView.Size = new Size(877, 355);
            especialidadesDataGridView.TabIndex = 0;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(840, 30);
            agregarButton.Margin = new Padding(2);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(92, 27);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(628, 30);
            eliminarButton.Margin = new Padding(2);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(92, 27);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(734, 30);
            modificarButton.Margin = new Padding(2);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(92, 27);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.5F);
            label1.Location = new Point(55, 25);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 4;
            label1.Text = "Especialidades";
            // 
            // EspecialidadesLista
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 509);
            Controls.Add(label1);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(especialidadesDataGridView);
            Margin = new Padding(2);
            Name = "EspecialidadesLista";
            Text = "Especialidades";
            Load += Especialidades_Load;
            ((System.ComponentModel.ISupportInitialize)especialidadesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView especialidadesDataGridView;
        private Button agregarButton;
        private Button eliminarButton;
        private Button modificarButton;
        private Label label1;
    }
}
