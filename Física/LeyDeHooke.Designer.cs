namespace física_EH
{
    partial class LeyDeHooke
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
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeyDeHooke));
            TxtFuerza = new TextBox();
            TxtConstanteDeRigidez = new TextBox();
            TxtDeformaciónResorte = new TextBox();
            BtnLimpiar = new RJButton.RJButton();
            BtnCalcular = new RJButton.RJButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TxtFuerza
            // 
            TxtFuerza.Location = new Point(289, 102);
            TxtFuerza.Name = "TxtFuerza";
            TxtFuerza.Size = new Size(100, 23);
            TxtFuerza.TabIndex = 0;
            // 
            // TxtConstanteDeRigidez
            // 
            TxtConstanteDeRigidez.Location = new Point(101, 316);
            TxtConstanteDeRigidez.Name = "TxtConstanteDeRigidez";
            TxtConstanteDeRigidez.Size = new Size(100, 23);
            TxtConstanteDeRigidez.TabIndex = 1;
            // 
            // TxtDeformaciónResorte
            // 
            TxtDeformaciónResorte.Location = new Point(249, 316);
            TxtDeformaciónResorte.Name = "TxtDeformaciónResorte";
            TxtDeformaciónResorte.Size = new Size(100, 23);
            TxtDeformaciónResorte.TabIndex = 2;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.FromArgb(54, 57, 62);
            BtnLimpiar.BackgroundColor = Color.FromArgb(54, 57, 62);
            BtnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLimpiar.BorderColor = Color.White;
            BtnLimpiar.BorderRadius = 15;
            BtnLimpiar.BorderSize = 1;
            BtnLimpiar.FlatAppearance.BorderSize = 0;
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLimpiar.ForeColor = Color.White;
            BtnLimpiar.Location = new Point(235, 361);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(142, 35);
            BtnLimpiar.TabIndex = 41;
            BtnLimpiar.Text = "\U0001f9f9  LIMPIAR";
            BtnLimpiar.TextColor = Color.White;
            BtnLimpiar.UseMnemonic = false;
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.FromArgb(54, 57, 62);
            BtnCalcular.BackgroundColor = Color.FromArgb(54, 57, 62);
            BtnCalcular.BorderColor = Color.White;
            BtnCalcular.BorderRadius = 1;
            BtnCalcular.BorderSize = 1;
            BtnCalcular.FlatAppearance.BorderSize = 0;
            BtnCalcular.FlatStyle = FlatStyle.Flat;
            BtnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcular.ForeColor = Color.White;
            BtnCalcular.Location = new Point(101, 361);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(121, 36);
            BtnCalcular.TabIndex = 40;
            BtnCalcular.Text = "📅 CALCULAR";
            BtnCalcular.TextColor = Color.White;
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 336);
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // LeyDeHooke
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(480, 408);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnCalcular);
            Controls.Add(TxtDeformaciónResorte);
            Controls.Add(TxtConstanteDeRigidez);
            Controls.Add(TxtFuerza);
            Controls.Add(pictureBox1);
            Name = "LeyDeHooke";
            Text = "LeyDeHooke";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtFuerza;
        private TextBox TxtConstanteDeRigidez;
        private TextBox TxtDeformaciónResorte;
        private RJButton.RJButton BtnLimpiar;
        private RJButton.RJButton BtnCalcular;
        private PictureBox pictureBox1;
    }
}