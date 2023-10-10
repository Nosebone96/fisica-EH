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
            RJButton.RJButton BtnLeyDeOhm;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Electrónica));
            BtnResistencia = new RJButton.RJButton();
            label1 = new Label();
            label2 = new Label();
            label11 = new Label();
            BtnLeyDeOhm = new RJButton.RJButton();
            SuspendLayout();
            // 
            // BtnLeyDeOhm
            // 
            BtnLeyDeOhm.BackColor = Color.MediumSlateBlue;
            BtnLeyDeOhm.BackgroundColor = Color.MediumSlateBlue;
            BtnLeyDeOhm.BackgroundImage = (Image)resources.GetObject("BtnLeyDeOhm.BackgroundImage");
            BtnLeyDeOhm.BackgroundImageLayout = ImageLayout.Zoom;
            BtnLeyDeOhm.BorderColor = SystemColors.Control;
            BtnLeyDeOhm.BorderRadius = 76;
            BtnLeyDeOhm.BorderSize = 1;
            BtnLeyDeOhm.Cursor = Cursors.Hand;
            BtnLeyDeOhm.FlatAppearance.BorderSize = 0;
            BtnLeyDeOhm.FlatStyle = FlatStyle.Flat;
            BtnLeyDeOhm.ForeColor = Color.White;
            BtnLeyDeOhm.Location = new Point(259, 82);
            BtnLeyDeOhm.Name = "BtnLeyDeOhm";
            BtnLeyDeOhm.Size = new Size(159, 155);
            BtnLeyDeOhm.TabIndex = 30;
            BtnLeyDeOhm.TextColor = Color.White;
            BtnLeyDeOhm.UseVisualStyleBackColor = false;
            BtnLeyDeOhm.Click += BtnLeyDeOhm_Click;
            // 
            // BtnResistencia
            // 
            BtnResistencia.BackColor = Color.Teal;
            BtnResistencia.BackgroundColor = Color.Teal;
            BtnResistencia.BackgroundImage = (Image)resources.GetObject("BtnResistencia.BackgroundImage");
            BtnResistencia.BackgroundImageLayout = ImageLayout.Zoom;
            BtnResistencia.BorderColor = SystemColors.Control;
            BtnResistencia.BorderRadius = 76;
            BtnResistencia.BorderSize = 1;
            BtnResistencia.Cursor = Cursors.Hand;
            BtnResistencia.FlatAppearance.BorderSize = 0;
            BtnResistencia.FlatStyle = FlatStyle.Flat;
            BtnResistencia.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnResistencia.ForeColor = Color.Black;
            BtnResistencia.Location = new Point(43, 82);
            BtnResistencia.Name = "BtnResistencia";
            BtnResistencia.Size = new Size(159, 155);
            BtnResistencia.TabIndex = 29;
            BtnResistencia.TextAlign = ContentAlignment.MiddleRight;
            BtnResistencia.TextColor = Color.Black;
            BtnResistencia.UseVisualStyleBackColor = false;
            BtnResistencia.Click += BtnResistencia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(21, 244);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 32;
            label1.Text = " Valor de una resistencia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(289, 244);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 33;
            label2.Text = "Ley de Ohm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Black;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(156, 20);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(148, 39);
            label11.TabIndex = 43;
            label11.Text = "Electrónica";
            // 
            // Electrónica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(476, 326);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label11;
    }
}