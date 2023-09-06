namespace física_EH
{
    partial class Volumen
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
            RJButton.RJButton BtnCalcularCilindro;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Volumen));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BtnLimpiarCubo = new RJButton.RJButton();
            BtnCubos = new RJButton.RJButton();
            lblVolumenCubo = new Label();
            label2 = new Label();
            txtLadoCubo = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            BtnLimpiarEsfera = new RJButton.RJButton();
            BtnCalcularEsfera = new RJButton.RJButton();
            lblVolumenEsfera = new Label();
            label4 = new Label();
            txtRadioEsfera = new TextBox();
            label3 = new Label();
            TabPage3 = new TabPage();
            BtnLimpiarCilindro = new RJButton.RJButton();
            LblVolumenCilindro = new Label();
            label7 = new Label();
            txtRadioCilindro = new TextBox();
            txtAlturaCilindro = new TextBox();
            label6 = new Label();
            label5 = new Label();
            BtnCalcularCilindro = new RJButton.RJButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            TabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCalcularCilindro
            // 
            BtnCalcularCilindro.BackColor = Color.FromArgb(224, 224, 224);
            BtnCalcularCilindro.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnCalcularCilindro.BorderColor = Color.FromArgb(0, 0, 192);
            BtnCalcularCilindro.BorderRadius = 1;
            BtnCalcularCilindro.BorderSize = 2;
            BtnCalcularCilindro.FlatAppearance.BorderSize = 0;
            BtnCalcularCilindro.FlatStyle = FlatStyle.Flat;
            BtnCalcularCilindro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcularCilindro.ForeColor = Color.Navy;
            BtnCalcularCilindro.Location = new Point(21, 168);
            BtnCalcularCilindro.Name = "BtnCalcularCilindro";
            BtnCalcularCilindro.Size = new Size(111, 36);
            BtnCalcularCilindro.TabIndex = 27;
            BtnCalcularCilindro.Text = "Calcular";
            BtnCalcularCilindro.TextColor = Color.Navy;
            BtnCalcularCilindro.UseVisualStyleBackColor = false;
            BtnCalcularCilindro.Click += BtnCalcularCilindro_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(TabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(560, 339);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnLimpiarCubo);
            tabPage1.Controls.Add(BtnCubos);
            tabPage1.Controls.Add(lblVolumenCubo);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtLadoCubo);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(552, 311);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cubos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiarCubo
            // 
            BtnLimpiarCubo.BackColor = Color.MediumSlateBlue;
            BtnLimpiarCubo.BackgroundColor = Color.MediumSlateBlue;
            BtnLimpiarCubo.BackgroundImage = (Image)resources.GetObject("BtnLimpiarCubo.BackgroundImage");
            BtnLimpiarCubo.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLimpiarCubo.BorderColor = Color.FromArgb(192, 0, 0);
            BtnLimpiarCubo.BorderRadius = 15;
            BtnLimpiarCubo.BorderSize = 2;
            BtnLimpiarCubo.FlatAppearance.BorderSize = 0;
            BtnLimpiarCubo.FlatStyle = FlatStyle.Flat;
            BtnLimpiarCubo.ForeColor = Color.White;
            BtnLimpiarCubo.Location = new Point(151, 114);
            BtnLimpiarCubo.Name = "BtnLimpiarCubo";
            BtnLimpiarCubo.Size = new Size(142, 35);
            BtnLimpiarCubo.TabIndex = 25;
            BtnLimpiarCubo.TextColor = Color.White;
            BtnLimpiarCubo.UseVisualStyleBackColor = false;
            BtnLimpiarCubo.Click += BtnLimpiarCubo_Click;
            // 
            // BtnCubos
            // 
            BtnCubos.BackColor = Color.FromArgb(224, 224, 224);
            BtnCubos.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnCubos.BorderColor = Color.FromArgb(0, 0, 192);
            BtnCubos.BorderRadius = 1;
            BtnCubos.BorderSize = 2;
            BtnCubos.FlatAppearance.BorderSize = 0;
            BtnCubos.FlatStyle = FlatStyle.Flat;
            BtnCubos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCubos.ForeColor = Color.Navy;
            BtnCubos.Location = new Point(17, 114);
            BtnCubos.Name = "BtnCubos";
            BtnCubos.Size = new Size(111, 36);
            BtnCubos.TabIndex = 24;
            BtnCubos.Text = "Calcular";
            BtnCubos.TextColor = Color.Navy;
            BtnCubos.UseVisualStyleBackColor = false;
            BtnCubos.Click += BtnCubos_Click;
            // 
            // lblVolumenCubo
            // 
            lblVolumenCubo.AutoSize = true;
            lblVolumenCubo.Location = new Point(505, 168);
            lblVolumenCubo.Name = "lblVolumenCubo";
            lblVolumenCubo.Size = new Size(0, 15);
            lblVolumenCubo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 65);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "VOLUMEN:";
            // 
            // txtLadoCubo
            // 
            txtLadoCubo.Location = new Point(222, 23);
            txtLadoCubo.Name = "txtLadoCubo";
            txtLadoCubo.Size = new Size(100, 23);
            txtLadoCubo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite un lado cualquiera del cubo:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnLimpiarEsfera);
            tabPage2.Controls.Add(BtnCalcularEsfera);
            tabPage2.Controls.Add(lblVolumenEsfera);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtRadioEsfera);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(552, 311);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Esfera";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiarEsfera
            // 
            BtnLimpiarEsfera.BackColor = Color.MediumSlateBlue;
            BtnLimpiarEsfera.BackgroundColor = Color.MediumSlateBlue;
            BtnLimpiarEsfera.BackgroundImage = (Image)resources.GetObject("BtnLimpiarEsfera.BackgroundImage");
            BtnLimpiarEsfera.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLimpiarEsfera.BorderColor = Color.FromArgb(192, 0, 0);
            BtnLimpiarEsfera.BorderRadius = 15;
            BtnLimpiarEsfera.BorderSize = 2;
            BtnLimpiarEsfera.FlatAppearance.BorderSize = 0;
            BtnLimpiarEsfera.FlatStyle = FlatStyle.Flat;
            BtnLimpiarEsfera.ForeColor = Color.White;
            BtnLimpiarEsfera.Location = new Point(155, 139);
            BtnLimpiarEsfera.Name = "BtnLimpiarEsfera";
            BtnLimpiarEsfera.Size = new Size(142, 35);
            BtnLimpiarEsfera.TabIndex = 26;
            BtnLimpiarEsfera.TextColor = Color.White;
            BtnLimpiarEsfera.UseVisualStyleBackColor = false;
            BtnLimpiarEsfera.Click += BtnLimpiarEsfera_Click;
            // 
            // BtnCalcularEsfera
            // 
            BtnCalcularEsfera.BackColor = Color.FromArgb(224, 224, 224);
            BtnCalcularEsfera.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnCalcularEsfera.BorderColor = Color.FromArgb(0, 0, 192);
            BtnCalcularEsfera.BorderRadius = 1;
            BtnCalcularEsfera.BorderSize = 2;
            BtnCalcularEsfera.FlatAppearance.BorderSize = 0;
            BtnCalcularEsfera.FlatStyle = FlatStyle.Flat;
            BtnCalcularEsfera.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcularEsfera.ForeColor = Color.Navy;
            BtnCalcularEsfera.Location = new Point(18, 137);
            BtnCalcularEsfera.Name = "BtnCalcularEsfera";
            BtnCalcularEsfera.Size = new Size(111, 36);
            BtnCalcularEsfera.TabIndex = 25;
            BtnCalcularEsfera.Text = "Calcular";
            BtnCalcularEsfera.TextColor = Color.Navy;
            BtnCalcularEsfera.UseVisualStyleBackColor = false;
            BtnCalcularEsfera.Click += BtnCalcularEsfera_Click;
            // 
            // lblVolumenEsfera
            // 
            lblVolumenEsfera.AutoSize = true;
            lblVolumenEsfera.Location = new Point(109, 107);
            lblVolumenEsfera.Name = "lblVolumenEsfera";
            lblVolumenEsfera.Size = new Size(0, 15);
            lblVolumenEsfera.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 81);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 3;
            label4.Text = "VOLUMEN:";
            // 
            // txtRadioEsfera
            // 
            txtRadioEsfera.Location = new Point(169, 31);
            txtRadioEsfera.Name = "txtRadioEsfera";
            txtRadioEsfera.Size = new Size(100, 23);
            txtRadioEsfera.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 34);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 0;
            label3.Text = "Digite el radio de la esfera:";
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(BtnLimpiarCilindro);
            TabPage3.Controls.Add(BtnCalcularCilindro);
            TabPage3.Controls.Add(LblVolumenCilindro);
            TabPage3.Controls.Add(label7);
            TabPage3.Controls.Add(txtRadioCilindro);
            TabPage3.Controls.Add(txtAlturaCilindro);
            TabPage3.Controls.Add(label6);
            TabPage3.Controls.Add(label5);
            TabPage3.Location = new Point(4, 24);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(552, 311);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Cilindro";
            TabPage3.UseVisualStyleBackColor = true;
            TabPage3.Click += TabPage3_Click;
            // 
            // BtnLimpiarCilindro
            // 
            BtnLimpiarCilindro.BackColor = Color.MediumSlateBlue;
            BtnLimpiarCilindro.BackgroundColor = Color.MediumSlateBlue;
            BtnLimpiarCilindro.BackgroundImage = (Image)resources.GetObject("BtnLimpiarCilindro.BackgroundImage");
            BtnLimpiarCilindro.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLimpiarCilindro.BorderColor = Color.FromArgb(192, 0, 0);
            BtnLimpiarCilindro.BorderRadius = 15;
            BtnLimpiarCilindro.BorderSize = 2;
            BtnLimpiarCilindro.FlatAppearance.BorderSize = 0;
            BtnLimpiarCilindro.FlatStyle = FlatStyle.Flat;
            BtnLimpiarCilindro.ForeColor = Color.White;
            BtnLimpiarCilindro.Location = new Point(158, 170);
            BtnLimpiarCilindro.Name = "BtnLimpiarCilindro";
            BtnLimpiarCilindro.Size = new Size(142, 35);
            BtnLimpiarCilindro.TabIndex = 28;
            BtnLimpiarCilindro.TextColor = Color.White;
            BtnLimpiarCilindro.UseVisualStyleBackColor = false;
            BtnLimpiarCilindro.Click += BtnLimpiarCilindro_Click;
            // 
            // LblVolumenCilindro
            // 
            LblVolumenCilindro.AutoSize = true;
            LblVolumenCilindro.Location = new Point(93, 121);
            LblVolumenCilindro.Name = "LblVolumenCilindro";
            LblVolumenCilindro.Size = new Size(0, 15);
            LblVolumenCilindro.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 122);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 5;
            label7.Text = "VOLUMEN:";
            // 
            // txtRadioCilindro
            // 
            txtRadioCilindro.Location = new Point(125, 78);
            txtRadioCilindro.Name = "txtRadioCilindro";
            txtRadioCilindro.Size = new Size(100, 23);
            txtRadioCilindro.TabIndex = 3;
            // 
            // txtAlturaCilindro
            // 
            txtAlturaCilindro.Location = new Point(125, 27);
            txtAlturaCilindro.Name = "txtAlturaCilindro";
            txtAlturaCilindro.Size = new Size(100, 23);
            txtAlturaCilindro.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 81);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 1;
            label6.Text = "Digite el radio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 30);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 0;
            label5.Text = "Digite la altura:";
            // 
            // Volumen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 344);
            Controls.Add(tabControl1);
            Name = "Volumen";
            Text = "Volumen";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            TabPage3.ResumeLayout(false);
            TabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage TabPage3;
        private TextBox txtLadoCubo;
        private Label label1;
        private Label lblVolumenCubo;
        private Label label2;
        private TextBox txtRadioEsfera;
        private Label label3;
        private Label lblVolumenEsfera;
        private Label label4;
        private Label LblVolumenCilindro;
        private Label label7;
        private TextBox txtRadioCilindro;
        private TextBox txtAlturaCilindro;
        private Label label6;
        private Label label5;
        private RJButton.RJButton BtnCubos;
        private RJButton.RJButton BtnLimpiarCubo;
        private RJButton.RJButton BtnCalcularEsfera;
        private RJButton.RJButton BtnLimpiarEsfera;
        private RJButton.RJButton BtnLimpiarCilindro;
    }
}