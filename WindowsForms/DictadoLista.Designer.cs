namespace WindowsForms
{
    partial class DictadoLista
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
            modificarButton = new Button();
            eliminarButton = new Button();
            agregarButton = new Button();
            dictadosDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dictadosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(35, 13);
            label1.Name = "label1";
            label1.Size = new Size(121, 37);
            label1.TabIndex = 17;
            label1.Text = "Dictados";
            label1.Click += label1_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(602, 20);
            modificarButton.Margin = new Padding(2, 1, 2, 1);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(81, 22);
            modificarButton.TabIndex = 16;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(510, 20);
            eliminarButton.Margin = new Padding(2, 1, 2, 1);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(81, 22);
            eliminarButton.TabIndex = 15;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(695, 20);
            agregarButton.Margin = new Padding(2, 1, 2, 1);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(81, 22);
            agregarButton.TabIndex = 14;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            // 
            // dictadosDataGridView
            // 
            dictadosDataGridView.AllowUserToOrderColumns = true;
            dictadosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dictadosDataGridView.Location = new Point(25, 58);
            dictadosDataGridView.Margin = new Padding(2, 1, 2, 1);
            dictadosDataGridView.MultiSelect = false;
            dictadosDataGridView.Name = "dictadosDataGridView";
            dictadosDataGridView.ReadOnly = true;
            dictadosDataGridView.RowHeadersWidth = 82;
            dictadosDataGridView.RowTemplate.Height = 41;
            dictadosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dictadosDataGridView.Size = new Size(751, 379);
            dictadosDataGridView.TabIndex = 13;
            dictadosDataGridView.CellContentClick += dictadosDataGridView_CellContentClick;
            // 
            // DictadoLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 472);
            Controls.Add(label1);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(dictadosDataGridView);
            Name = "DictadoLista";
            Text = "Dictados";
            Load += DictadoLista_Load;
            ((System.ComponentModel.ISupportInitialize)dictadosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button modificarButton;
        private Button eliminarButton;
        private Button agregarButton;
        private DataGridView dictadosDataGridView;
    }
}