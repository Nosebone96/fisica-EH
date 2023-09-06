namespace física_EH
{
    partial class Electrónica
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
            RJButton.RJButton BtnLeyesDeKirchhcoff;
            RJButton.RJButton BtnLeyDeOhm;
            BtnResistencia = new RJButton.RJButton();
            label1 = new Label();
            label2 = new Label();
            label = new Label();
            BtnLeyesDeKirchhcoff = new RJButton.RJButton();
            BtnLeyDeOhm = new RJButton.RJButton();
            SuspendLayout();
            // 
            // BtnLeyesDeKirchhcoff
            // 
            BtnLeyesDeKirchhcoff.BackColor = Color.MediumSlateBlue;
            BtnLeyesDeKirchhcoff.BackgroundColor = Color.MediumSlateBlue;
            BtnLeyesDeKirchhcoff.BorderColor = Color.PaleVioletRed;
            BtnLeyesDeKirchhcoff.BorderRadius = 76;
            BtnLeyesDeKirchhcoff.BorderSize = 1;
            BtnLeyesDeKirchhcoff.FlatAppearance.BorderSize = 0;
            BtnLeyesDeKirchhcoff.FlatStyle = FlatStyle.Flat;
            BtnLeyesDeKirchhcoff.ForeColor = Color.White;
            BtnLeyesDeKirchhcoff.Location = new Point(446, 82);
            BtnLeyesDeKirchhcoff.Name = "BtnLeyesDeKirchhcoff";
            BtnLeyesDeKirchhcoff.Size = new Size(157, 155);
            BtnLeyesDeKirchhcoff.TabIndex = 31;
            BtnLeyesDeKirchhcoff.TextColor = Color.White;
            BtnLeyesDeKirchhcoff.UseVisualStyleBackColor = false;
            BtnLeyesDeKirchhcoff.Click += BtnLeyesDeKirchhcoff_Click;
            // 
            // BtnLeyDeOhm
            // 
            BtnLeyDeOhm.BackColor = Color.MediumSlateBlue;
            BtnLeyDeOhm.BackgroundColor = Color.MediumSlateBlue;
            BtnLeyDeOhm.BorderColor = Color.PaleVioletRed;
            BtnLeyDeOhm.BorderRadius = 76;
            BtnLeyDeOhm.BorderSize = 1;
            BtnLeyDeOhm.FlatAppearance.BorderSize = 0;
            BtnLeyDeOhm.FlatStyle = FlatStyle.Flat;
            BtnLeyDeOhm.ForeColor = Color.White;
            BtnLeyDeOhm.Location = new Point(239, 78);
            BtnLeyDeOhm.Name = "BtnLeyDeOhm";
            BtnLeyDeOhm.Size = new Size(157, 155);
            BtnLeyDeOhm.TabIndex = 30;
            BtnLeyDeOhm.TextColor = Color.White;
            BtnLeyDeOhm.UseVisualStyleBackColor = false;
            BtnLeyDeOhm.Click += BtnLeyDeOhm_Click;
            // 
            // BtnResistencia
            // 
            BtnResistencia.BackColor = Color.Teal;
            BtnResistencia.BackgroundColor = Color.Teal;
            BtnResistencia.BackgroundImageLayout = ImageLayout.Stretch;
            BtnResistencia.BorderColor = Color.Black;
            BtnResistencia.BorderRadius = 76;
            BtnResistencia.BorderSize = 1;
            BtnResistencia.Cursor = Cursors.Hand;
            BtnResistencia.FlatAppearance.BorderSize = 0;
            BtnResistencia.FlatStyle = FlatStyle.Flat;
            BtnResistencia.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnResistencia.ForeColor = Color.Black;
            BtnResistencia.Location = new Point(23, 78);
            BtnResistencia.Name = "BtnResistencia";
            BtnResistencia.Size = new Size(157, 155);
            BtnResistencia.TabIndex = 29;
            BtnResistencia.Text = "i";
            BtnResistencia.TextAlign = ContentAlignment.MiddleRight;
            BtnResistencia.TextColor = Color.Black;
            BtnResistencia.UseVisualStyleBackColor = false;
            BtnResistencia.Click += BtnResistencia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-1, 240);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 32;
            label1.Text = " Valor de una resistencia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(267, 240);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 33;
            label2.Text = "Ley de Ohm";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(446, 240);
            label.Name = "label";
            label.Size = new Size(164, 25);
            label.TabIndex = 34;
            label.Text = "Leyes de Kirchhcoff";
            // 
            // Electrónica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 386);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnLeyesDeKirchhcoff);
            Controls.Add(BtnLeyDeOhm);
            Controls.Add(BtnResistencia);
            Name = "Electrónica";
            Text = "Electrónica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RJButton.RJButton BtnResistencia;
        private Label label1;
        private Label label2;
        private Label label;
    }
}