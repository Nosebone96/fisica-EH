namespace física_EH
{
    partial class Ley_De_Ohm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ley_De_Ohm));
            BtnLimpiarOhm = new RJButton.RJButton();
            BtnCalcularOhm = new RJButton.RJButton();
            TxtResistenciaOhm = new TextBox();
            TxtCorrienteOhm = new TextBox();
            TxtVoltageOhm = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnLimpiarOhm
            // 
            BtnLimpiarOhm.BackColor = Color.MediumSlateBlue;
            BtnLimpiarOhm.BackgroundColor = Color.MediumSlateBlue;
            BtnLimpiarOhm.BackgroundImage = (Image)resources.GetObject("BtnLimpiarOhm.BackgroundImage");
            BtnLimpiarOhm.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLimpiarOhm.BorderColor = Color.FromArgb(192, 0, 0);
            BtnLimpiarOhm.BorderRadius = 15;
            BtnLimpiarOhm.BorderSize = 2;
            BtnLimpiarOhm.Cursor = Cursors.Hand;
            BtnLimpiarOhm.FlatAppearance.BorderSize = 0;
            BtnLimpiarOhm.FlatStyle = FlatStyle.Flat;
            BtnLimpiarOhm.ForeColor = Color.White;
            BtnLimpiarOhm.Location = new Point(141, 307);
            BtnLimpiarOhm.Name = "BtnLimpiarOhm";
            BtnLimpiarOhm.Size = new Size(142, 36);
            BtnLimpiarOhm.TabIndex = 64;
            BtnLimpiarOhm.TextColor = Color.White;
            BtnLimpiarOhm.UseVisualStyleBackColor = false;
            BtnLimpiarOhm.Click += BtnLimpiarOhm_Click;
            // 
            // BtnCalcularOhm
            // 
            BtnCalcularOhm.BackColor = Color.FromArgb(224, 224, 224);
            BtnCalcularOhm.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnCalcularOhm.BorderColor = Color.FromArgb(0, 0, 192);
            BtnCalcularOhm.BorderRadius = 1;
            BtnCalcularOhm.BorderSize = 2;
            BtnCalcularOhm.Cursor = Cursors.Hand;
            BtnCalcularOhm.FlatAppearance.BorderSize = 0;
            BtnCalcularOhm.FlatStyle = FlatStyle.Flat;
            BtnCalcularOhm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcularOhm.ForeColor = Color.Navy;
            BtnCalcularOhm.Location = new Point(12, 306);
            BtnCalcularOhm.Name = "BtnCalcularOhm";
            BtnCalcularOhm.Size = new Size(111, 36);
            BtnCalcularOhm.TabIndex = 63;
            BtnCalcularOhm.Text = "Calcular";
            BtnCalcularOhm.TextColor = Color.Navy;
            BtnCalcularOhm.UseVisualStyleBackColor = false;
            BtnCalcularOhm.Click += BtnCalcularOhm_Click;
            // 
            // TxtResistenciaOhm
            // 
            TxtResistenciaOhm.BorderStyle = BorderStyle.FixedSingle;
            TxtResistenciaOhm.Location = new Point(152, 255);
            TxtResistenciaOhm.Name = "TxtResistenciaOhm";
            TxtResistenciaOhm.Size = new Size(100, 23);
            TxtResistenciaOhm.TabIndex = 61;
            // 
            // TxtCorrienteOhm
            // 
            TxtCorrienteOhm.BorderStyle = BorderStyle.FixedSingle;
            TxtCorrienteOhm.Location = new Point(15, 255);
            TxtCorrienteOhm.Name = "TxtCorrienteOhm";
            TxtCorrienteOhm.Size = new Size(100, 23);
            TxtCorrienteOhm.TabIndex = 60;
            // 
            // TxtVoltageOhm
            // 
            TxtVoltageOhm.BorderStyle = BorderStyle.FixedSingle;
            TxtVoltageOhm.Location = new Point(183, 67);
            TxtVoltageOhm.Name = "TxtVoltageOhm";
            TxtVoltageOhm.Size = new Size(100, 23);
            TxtVoltageOhm.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(26, 281);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 58;
            label7.Text = "Corriente (A) ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(170, 281);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 57;
            label6.Text = "Resistencia(Ω)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(206, 93);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 56;
            label5.Text = "Voltaje (V)";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 298);
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // Ley_De_Ohm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(316, 354);
            Controls.Add(BtnLimpiarOhm);
            Controls.Add(BtnCalcularOhm);
            Controls.Add(TxtResistenciaOhm);
            Controls.Add(TxtCorrienteOhm);
            Controls.Add(TxtVoltageOhm);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Name = "Ley_De_Ohm";
            Text = "Ley_De_Ohm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RJButton.RJButton BtnLimpiarOhm;
        private RJButton.RJButton BtnCalcularOhm;
        private TextBox TxtResistenciaOhm;
        private TextBox TxtCorrienteOhm;
        private TextBox TxtVoltageOhm;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
    }
}