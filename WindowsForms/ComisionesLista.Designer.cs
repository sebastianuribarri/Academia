namespace WindowsForms
{
    partial class ComisionesLista
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
            comisionesDataGridView = new DataGridView();
            agregarButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)comisionesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // comisionesDataGridView
            // 
            comisionesDataGridView.AllowUserToOrderColumns = true;
            comisionesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            comisionesDataGridView.Location = new Point(30, 63);
            comisionesDataGridView.Margin = new Padding(2);
            comisionesDataGridView.MultiSelect = false;
            comisionesDataGridView.Name = "comisionesDataGridView";
            comisionesDataGridView.ReadOnly = true;
            comisionesDataGridView.RowHeadersWidth = 82;
            comisionesDataGridView.RowTemplate.Height = 41;
            comisionesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comisionesDataGridView.Size = new Size(682, 367);
            comisionesDataGridView.TabIndex = 0;
            comisionesDataGridView.CellContentClick += comisionesDataGridView_CellContentClick;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(632, 26);
            agregarButton.Margin = new Padding(2);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(80, 21);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(447, 26);
            eliminarButton.Margin = new Padding(2);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(80, 21);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(540, 26);
            modificarButton.Margin = new Padding(2);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(80, 21);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(30, 10);
            label1.Name = "label1";
            label1.Size = new Size(154, 37);
            label1.TabIndex = 13;
            label1.Text = "Comisiones";
            // 
            // ComisionesLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 463);
            Controls.Add(label1);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(comisionesDataGridView);
            Margin = new Padding(2);
            Name = "ComisionesLista";
            Text = "Comisiones";
            Load += Comisiones_Load;
            ((System.ComponentModel.ISupportInitialize)comisionesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView comisionesDataGridView;
        private Button agregarButton;
        private Button eliminarButton;
        private Button modificarButton;
        private Label label1;
    }
}
