namespace física_EH
{
    partial class LeyesDeNewton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeyesDeNewton));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            CbFuerza = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            TxtAceleración = new TextBox();
            txtMasa = new TextBox();
            pictureBox1 = new PictureBox();
            LblFR = new Label();
            BtnLimpiarFr = new RJButton.RJButton();
            BtnFuerzaR = new RJButton.RJButton();
            label4 = new Label();
            TxtAg = new TextBox();
            TxtF2 = new TextBox();
            TxtF1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            BtnCalcularTrianguloDeLaFuerza = new RJButton.RJButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(731, 393);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnCalcularTrianguloDeLaFuerza);
            tabPage1.Controls.Add(CbFuerza);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(TxtAceleración);
            tabPage1.Controls.Add(txtMasa);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(LblFR);
            tabPage1.Controls.Add(BtnLimpiarFr);
            tabPage1.Controls.Add(BtnFuerzaR);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(TxtAg);
            tabPage1.Controls.Add(TxtF2);
            tabPage1.Controls.Add(TxtF1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(723, 365);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Fuerza Resultante";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // CbFuerza
            // 
            CbFuerza.FormattingEnabled = true;
            CbFuerza.Location = new Point(602, 85);
            CbFuerza.Name = "CbFuerza";
            CbFuerza.Size = new Size(105, 23);
            CbFuerza.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(557, 280);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 42;
            label7.Text = "Aceleración (m/s²)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(457, 280);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 41;
            label6.Text = "Masa (kg)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(623, 120);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 40;
            label5.Text = "Fuerza (N)";
            // 
            // TxtAceleración
            // 
            TxtAceleración.BorderStyle = BorderStyle.FixedSingle;
            TxtAceleración.Location = new Point(562, 254);
            TxtAceleración.Name = "TxtAceleración";
            TxtAceleración.Size = new Size(100, 23);
            TxtAceleración.TabIndex = 39;
            // 
            // txtMasa
            // 
            txtMasa.BorderStyle = BorderStyle.FixedSingle;
            txtMasa.Location = new Point(438, 254);
            txtMasa.Name = "txtMasa";
            txtMasa.Size = new Size(100, 23);
            txtMasa.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(397, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 292);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // LblFR
            // 
            LblFR.AutoSize = true;
            LblFR.Location = new Point(229, 184);
            LblFR.Name = "LblFR";
            LblFR.Size = new Size(0, 15);
            LblFR.TabIndex = 35;
            // 
            // BtnLimpiarFr
            // 
            BtnLimpiarFr.BackColor = Color.MediumSlateBlue;
            BtnLimpiarFr.BackgroundColor = Color.MediumSlateBlue;
            BtnLimpiarFr.BackgroundImage = (Image)resources.GetObject("BtnLimpiarFr.BackgroundImage");
            BtnLimpiarFr.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLimpiarFr.BorderColor = Color.FromArgb(192, 0, 0);
            BtnLimpiarFr.BorderRadius = 15;
            BtnLimpiarFr.BorderSize = 2;
            BtnLimpiarFr.FlatAppearance.BorderSize = 0;
            BtnLimpiarFr.FlatStyle = FlatStyle.Flat;
            BtnLimpiarFr.ForeColor = Color.White;
            BtnLimpiarFr.Location = new Point(198, 282);
            BtnLimpiarFr.Name = "BtnLimpiarFr";
            BtnLimpiarFr.Size = new Size(142, 35);
            BtnLimpiarFr.TabIndex = 34;
            BtnLimpiarFr.TextColor = Color.White;
            BtnLimpiarFr.UseVisualStyleBackColor = false;
            BtnLimpiarFr.Click += BtnLimpiarFr_Click_1;
            // 
            // BtnFuerzaR
            // 
            BtnFuerzaR.BackColor = Color.FromArgb(224, 224, 224);
            BtnFuerzaR.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnFuerzaR.BorderColor = Color.FromArgb(0, 0, 192);
            BtnFuerzaR.BorderRadius = 1;
            BtnFuerzaR.BorderSize = 2;
            BtnFuerzaR.FlatAppearance.BorderSize = 0;
            BtnFuerzaR.FlatStyle = FlatStyle.Flat;
            BtnFuerzaR.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFuerzaR.ForeColor = Color.Navy;
            BtnFuerzaR.Location = new Point(52, 280);
            BtnFuerzaR.Name = "BtnFuerzaR";
            BtnFuerzaR.Size = new Size(111, 36);
            BtnFuerzaR.TabIndex = 33;
            BtnFuerzaR.Text = "Calcular";
            BtnFuerzaR.TextColor = Color.Navy;
            BtnFuerzaR.UseVisualStyleBackColor = false;
            BtnFuerzaR.Click += BtnFuerzaR_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 184);
            label4.Name = "label4";
            label4.Size = new Size(142, 15);
            label4.TabIndex = 32;
            label4.Text = "La fuerza resultante es de:";
            // 
            // TxtAg
            // 
            TxtAg.Location = new Point(169, 139);
            TxtAg.Name = "TxtAg";
            TxtAg.Size = new Size(112, 23);
            TxtAg.TabIndex = 31;
            // 
            // TxtF2
            // 
            TxtF2.Location = new Point(170, 101);
            TxtF2.Name = "TxtF2";
            TxtF2.Size = new Size(112, 23);
            TxtF2.TabIndex = 30;
            // 
            // TxtF1
            // 
            TxtF1.Location = new Point(170, 66);
            TxtF1.Name = "TxtF1";
            TxtF1.Size = new Size(112, 23);
            TxtF1.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 142);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 28;
            label3.Text = "Digite el ángulo ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 104);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 27;
            label2.Text = "Digite la fuerza 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 69);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 26;
            label1.Text = "Digite la fuerza 1";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(723, 365);
            tabPage2.TabIndex = 1;
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnCalcularTrianguloDeLaFuerza
            // 
            BtnCalcularTrianguloDeLaFuerza.BackColor = Color.FromArgb(224, 224, 224);
            BtnCalcularTrianguloDeLaFuerza.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnCalcularTrianguloDeLaFuerza.BorderColor = Color.FromArgb(0, 0, 192);
            BtnCalcularTrianguloDeLaFuerza.BorderRadius = 1;
            BtnCalcularTrianguloDeLaFuerza.BorderSize = 2;
            BtnCalcularTrianguloDeLaFuerza.FlatAppearance.BorderSize = 0;
            BtnCalcularTrianguloDeLaFuerza.FlatStyle = FlatStyle.Flat;
            BtnCalcularTrianguloDeLaFuerza.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcularTrianguloDeLaFuerza.ForeColor = Color.Navy;
            BtnCalcularTrianguloDeLaFuerza.Location = new Point(496, 314);
            BtnCalcularTrianguloDeLaFuerza.Name = "BtnCalcularTrianguloDeLaFuerza";
            BtnCalcularTrianguloDeLaFuerza.Size = new Size(111, 36);
            BtnCalcularTrianguloDeLaFuerza.TabIndex = 44;
            BtnCalcularTrianguloDeLaFuerza.Text = "Calcular";
            BtnCalcularTrianguloDeLaFuerza.TextColor = Color.Navy;
            BtnCalcularTrianguloDeLaFuerza.UseVisualStyleBackColor = false;
            BtnCalcularTrianguloDeLaFuerza.Click += BtnCalcularTrianguloDeLaFuerza_Click;
            // 
            // LeyesDeNewton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 405);
            Controls.Add(tabControl1);
            Name = "LeyesDeNewton";
            StartPosition = FormStartPosition.Manual;
            Text = "LeyesDeNewton";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label LblFR;
        private RJButton.RJButton BtnLimpiarFr;
        private RJButton.RJButton BtnFuerzaR;
        private Label label4;
        private TextBox TxtAg;
        private TextBox TxtF2;
        private TextBox TxtF1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private ComboBox CbFuerza;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox TxtAceleración;
        private TextBox txtMasa;
        private PictureBox pictureBox1;
        private RJButton.RJButton BtnCalcularTrianguloDeLaFuerza;
    }
}