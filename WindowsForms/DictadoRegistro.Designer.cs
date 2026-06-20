namespace WindowsForms
{
    partial class DictadoRegistro
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
            hsSemLabel = new Label();
            descLabel = new Label();
            PlanLabel = new Label();
            aceptarButton = new Button();
            cancelarButton = new Button();
            legajoDocenteTB = new TextBox();
            cursoCB = new ComboBox();
            cargoCB = new ComboBox();
            SuspendLayout();
            // 
            // hsSemLabel
            // 
            hsSemLabel.AutoSize = true;
            hsSemLabel.Location = new Point(31, 142);
            hsSemLabel.Name = "hsSemLabel";
            hsSemLabel.Size = new Size(49, 19);
            hsSemLabel.TabIndex = 53;
            hsSemLabel.Text = "Cargo:";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(31, 91);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(127, 19);
            descLabel.TabIndex = 51;
            descLabel.Text = "Legajo del docente:";
            descLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // PlanLabel
            // 
            PlanLabel.AutoSize = true;
            PlanLabel.Location = new Point(31, 44);
            PlanLabel.Name = "PlanLabel";
            PlanLabel.Size = new Size(48, 19);
            PlanLabel.TabIndex = 45;
            PlanLabel.Text = "Curso:";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(143, 199);
            aceptarButton.Margin = new Padding(3, 4, 3, 4);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(92, 28);
            aceptarButton.TabIndex = 48;
            aceptarButton.Text = "Aceptar";
            aceptarButton.Click += aceptarButton_Click_1;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(258, 199);
            cancelarButton.Margin = new Padding(3, 4, 3, 4);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(85, 28);
            cancelarButton.TabIndex = 49;
            cancelarButton.Text = "Cancelar";
            cancelarButton.Click += cancelarButton_Click;
            // 
            // legajoDocenteTB
            // 
            legajoDocenteTB.Location = new Point(224, 91);
            legajoDocenteTB.Margin = new Padding(3, 4, 3, 4);
            legajoDocenteTB.Name = "legajoDocenteTB";
            legajoDocenteTB.Size = new Size(285, 26);
            legajoDocenteTB.TabIndex = 56;
            // 
            // cursoCB
            // 
            cursoCB.FormattingEnabled = true;
            cursoCB.Location = new Point(224, 44);
            cursoCB.Name = "cursoCB";
            cursoCB.Size = new Size(285, 27);
            cursoCB.TabIndex = 58;
            // 
            // cargoCB
            // 
            cargoCB.FormattingEnabled = true;
            cargoCB.Location = new Point(224, 139);
            cargoCB.Name = "cargoCB";
            cargoCB.Size = new Size(285, 27);
            cargoCB.TabIndex = 59;
            // 
            // DictadoRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 247);
            Controls.Add(cargoCB);
            Controls.Add(cursoCB);
            Controls.Add(legajoDocenteTB);
            Controls.Add(hsSemLabel);
            Controls.Add(descLabel);
            Controls.Add(PlanLabel);
            Controls.Add(aceptarButton);
            Controls.Add(cancelarButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DictadoRegistro";
            Text = "DictadoRegistro";
            Load += DictadoRegistro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label hsSemLabel;
        private Label descLabel;
        private Label PlanLabel;
        private Button aceptarButton;
        private Button cancelarButton;
        private TextBox legajoDocenteTB;
        private TextBox idCursoTB;
        private ComboBox cursoCB;
        private ComboBox cargoCB;
    }
}