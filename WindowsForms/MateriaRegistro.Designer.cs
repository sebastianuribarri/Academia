namespace WindowsForms
{
    partial class MateriaRegistro
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
            hsSemTB = new TextBox();
            hsSemLabel = new Label();
            descTB = new TextBox();
            descLabel = new Label();
            PlanLabel = new Label();
            hsTotLabel = new Label();
            hsTotTB = new TextBox();
            aceptarButton = new Button();
            cancelarButton = new Button();
            planCB = new ComboBox();
            SuspendLayout();
            // 
            // hsSemTB
            // 
            hsSemTB.Location = new Point(411, 247);
            hsSemTB.Margin = new Padding(3, 4, 3, 4);
            hsSemTB.Name = "hsSemTB";
            hsSemTB.Size = new Size(285, 26);
            hsSemTB.TabIndex = 42;
            // 
            // hsSemLabel
            // 
            hsSemLabel.AutoSize = true;
            hsSemLabel.Location = new Point(218, 247);
            hsSemLabel.Name = "hsSemLabel";
            hsSemLabel.Size = new Size(115, 19);
            hsSemLabel.TabIndex = 43;
            hsSemLabel.Text = "Horas semanales:";
            // 
            // descTB
            // 
            descTB.Location = new Point(411, 196);
            descTB.Margin = new Padding(3, 4, 3, 4);
            descTB.Name = "descTB";
            descTB.Size = new Size(285, 26);
            descTB.TabIndex = 40;
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(218, 196);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(82, 19);
            descLabel.TabIndex = 41;
            descLabel.Text = "Descripcion:";
            descLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // PlanLabel
            // 
            PlanLabel.AutoSize = true;
            PlanLabel.Location = new Point(218, 149);
            PlanLabel.Name = "PlanLabel";
            PlanLabel.Size = new Size(38, 19);
            PlanLabel.TabIndex = 35;
            PlanLabel.Text = "Plan:";
            // 
            // hsTotLabel
            // 
            hsTotLabel.AutoSize = true;
            hsTotLabel.Location = new Point(217, 299);
            hsTotLabel.Name = "hsTotLabel";
            hsTotLabel.Size = new Size(93, 19);
            hsTotLabel.TabIndex = 36;
            hsTotLabel.Text = "Horas totales:";
            // 
            // hsTotTB
            // 
            hsTotTB.Location = new Point(411, 299);
            hsTotTB.Margin = new Padding(3, 4, 3, 4);
            hsTotTB.Name = "hsTotTB";
            hsTotTB.Size = new Size(285, 26);
            hsTotTB.TabIndex = 37;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(321, 384);
            aceptarButton.Margin = new Padding(3, 4, 3, 4);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(114, 38);
            aceptarButton.TabIndex = 38;
            aceptarButton.Text = "Aceptar";
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(457, 384);
            cancelarButton.Margin = new Padding(3, 4, 3, 4);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(114, 38);
            cancelarButton.TabIndex = 39;
            cancelarButton.Text = "Cancelar";
            cancelarButton.Click += cancelarButton_Click;
            // 
            // planCB
            // 
            planCB.FormattingEnabled = true;
            planCB.Location = new Point(411, 141);
            planCB.Name = "planCB";
            planCB.Size = new Size(285, 27);
            planCB.TabIndex = 44;
            // 
            // MateriaRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 570);
            Controls.Add(planCB);
            Controls.Add(hsSemTB);
            Controls.Add(hsSemLabel);
            Controls.Add(descTB);
            Controls.Add(descLabel);
            Controls.Add(PlanLabel);
            Controls.Add(hsTotLabel);
            Controls.Add(hsTotTB);
            Controls.Add(aceptarButton);
            Controls.Add(cancelarButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MateriaRegistro";
            Text = "Registro de materia";
            Load += MateriaRegistro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox hsSemTB;
        private Label hsSemLabel;
        private TextBox descTB;
        private Label descLabel;
        private Label PlanLabel;
        private Label hsTotLabel;
        private TextBox hsTotTB;
        private Button aceptarButton;
        private Button cancelarButton;
        private ComboBox planCB;
    }
}