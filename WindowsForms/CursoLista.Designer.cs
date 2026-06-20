namespace WindowsForms
{
    partial class CursoLista
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
            agregarButton = new Button();
            cursosDataGridView = new DataGridView();
            generarReporteBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)cursosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(603, 21);
            modificarButton.Margin = new Padding(2, 1, 2, 1);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(81, 22);
            modificarButton.TabIndex = 7;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(511, 21);
            eliminarButton.Margin = new Padding(2, 1, 2, 1);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(81, 22);
            eliminarButton.TabIndex = 6;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(696, 21);
            agregarButton.Margin = new Padding(2, 1, 2, 1);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(81, 22);
            agregarButton.TabIndex = 5;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // cursosDataGridView
            // 
            cursosDataGridView.AllowUserToOrderColumns = true;
            cursosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosDataGridView.Location = new Point(26, 60);
            cursosDataGridView.Margin = new Padding(2, 1, 2, 1);
            cursosDataGridView.MultiSelect = false;
            cursosDataGridView.Name = "cursosDataGridView";
            cursosDataGridView.ReadOnly = true;
            cursosDataGridView.RowHeadersWidth = 82;
            cursosDataGridView.RowTemplate.Height = 41;
            cursosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursosDataGridView.Size = new Size(751, 366);
            cursosDataGridView.TabIndex = 4;
            // 
            // generarReporteBtn
            // 
            generarReporteBtn.Location = new Point(363, 21);
            generarReporteBtn.Margin = new Padding(2, 1, 2, 1);
            generarReporteBtn.Name = "generarReporteBtn";
            generarReporteBtn.Size = new Size(113, 22);
            generarReporteBtn.TabIndex = 10;
            generarReporteBtn.Text = "Generar Reporte";
            generarReporteBtn.UseVisualStyleBackColor = true;
            generarReporteBtn.Click += generarReporteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 37);
            label1.TabIndex = 13;
            label1.Text = "Cursos";
            // 
            // CursoLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 462);
            Controls.Add(label1);
            Controls.Add(generarReporteBtn);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(cursosDataGridView);
            Name = "CursoLista";
            Text = "Cursos";
            Load += CursoLista_Load;
            ((System.ComponentModel.ISupportInitialize)cursosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button modificarButton;
        private Button eliminarButton;
        private Button agregarButton;
        private DataGridView cursosDataGridView;
        private Button generarReporteBtn;
        private Label label1;
    }
}