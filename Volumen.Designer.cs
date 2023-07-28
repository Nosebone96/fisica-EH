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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblVolumenCubo = new Label();
            label2 = new Label();
            BtnVolumenCubo = new Button();
            txtLadoCubo = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            lblVolumenEsfera = new Label();
            label4 = new Label();
            BtnVolumenEsfera = new Button();
            txtRadioEsfera = new TextBox();
            label3 = new Label();
            TabPage3 = new TabPage();
            label5 = new Label();
            label6 = new Label();
            txtAlturaCilindro = new TextBox();
            txtRadioCilindro = new TextBox();
            BtnVolumenCilindro = new Button();
            label7 = new Label();
            LblVolumenCilindro = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            TabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(TabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(808, 447);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblVolumenCubo);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(BtnVolumenCubo);
            tabPage1.Controls.Add(txtLadoCubo);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(800, 419);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cubos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblVolumenCubo
            // 
            lblVolumenCubo.AutoSize = true;
            lblVolumenCubo.Location = new Point(245, 210);
            lblVolumenCubo.Name = "lblVolumenCubo";
            lblVolumenCubo.Size = new Size(0, 15);
            lblVolumenCubo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 211);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "VOLUMEN:";
            // 
            // BtnVolumenCubo
            // 
            BtnVolumenCubo.Location = new Point(163, 141);
            BtnVolumenCubo.Name = "BtnVolumenCubo";
            BtnVolumenCubo.Size = new Size(143, 51);
            BtnVolumenCubo.TabIndex = 2;
            BtnVolumenCubo.Text = "Calcular";
            BtnVolumenCubo.UseVisualStyleBackColor = true;
            BtnVolumenCubo.Click += BtnVolumenCubo_Click;
            // 
            // txtLadoCubo
            // 
            txtLadoCubo.Location = new Point(350, 83);
            txtLadoCubo.Name = "txtLadoCubo";
            txtLadoCubo.Size = new Size(100, 23);
            txtLadoCubo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 83);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite un lado cualquiera del cubo:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblVolumenEsfera);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(BtnVolumenEsfera);
            tabPage2.Controls.Add(txtRadioEsfera);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(800, 419);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Esfera";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblVolumenEsfera
            // 
            lblVolumenEsfera.AutoSize = true;
            lblVolumenEsfera.Location = new Point(309, 125);
            lblVolumenEsfera.Name = "lblVolumenEsfera";
            lblVolumenEsfera.Size = new Size(0, 15);
            lblVolumenEsfera.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 127);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 3;
            label4.Text = "VOLUMEN:";
            // 
            // BtnVolumenEsfera
            // 
            BtnVolumenEsfera.Location = new Point(62, 109);
            BtnVolumenEsfera.Name = "BtnVolumenEsfera";
            BtnVolumenEsfera.Size = new Size(135, 51);
            BtnVolumenEsfera.TabIndex = 2;
            BtnVolumenEsfera.Text = "Calcular";
            BtnVolumenEsfera.UseVisualStyleBackColor = true;
            BtnVolumenEsfera.Click += BtnVolumenEsfera_Click;
            // 
            // txtRadioEsfera
            // 
            txtRadioEsfera.Location = new Point(214, 56);
            txtRadioEsfera.Name = "txtRadioEsfera";
            txtRadioEsfera.Size = new Size(100, 23);
            txtRadioEsfera.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 54);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 0;
            label3.Text = "Digite el radio de la esfera:";
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(LblVolumenCilindro);
            TabPage3.Controls.Add(label7);
            TabPage3.Controls.Add(BtnVolumenCilindro);
            TabPage3.Controls.Add(txtRadioCilindro);
            TabPage3.Controls.Add(txtAlturaCilindro);
            TabPage3.Controls.Add(label6);
            TabPage3.Controls.Add(label5);
            TabPage3.Location = new Point(4, 24);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(800, 419);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Cilindro";
            TabPage3.UseVisualStyleBackColor = true;
            TabPage3.Click += TabPage3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 72);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 0;
            label5.Text = "Digite la altura:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 123);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 1;
            label6.Text = "Digite el radio:";
            // 
            // txtAlturaCilindro
            // 
            txtAlturaCilindro.Location = new Point(229, 69);
            txtAlturaCilindro.Name = "txtAlturaCilindro";
            txtAlturaCilindro.Size = new Size(100, 23);
            txtAlturaCilindro.TabIndex = 2;
            // 
            // txtRadioCilindro
            // 
            txtRadioCilindro.Location = new Point(229, 120);
            txtRadioCilindro.Name = "txtRadioCilindro";
            txtRadioCilindro.Size = new Size(100, 23);
            txtRadioCilindro.TabIndex = 3;
            // 
            // BtnVolumenCilindro
            // 
            BtnVolumenCilindro.Location = new Point(125, 172);
            BtnVolumenCilindro.Name = "BtnVolumenCilindro";
            BtnVolumenCilindro.Size = new Size(126, 53);
            BtnVolumenCilindro.TabIndex = 4;
            BtnVolumenCilindro.Text = "Calcular";
            BtnVolumenCilindro.UseVisualStyleBackColor = true;
            BtnVolumenCilindro.Click += BtnVolumenCilindro_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(125, 249);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 5;
            label7.Text = "VOLUMEN:";
            // 
            // LblVolumenCilindro
            // 
            LblVolumenCilindro.AutoSize = true;
            LblVolumenCilindro.Location = new Point(197, 248);
            LblVolumenCilindro.Name = "LblVolumenCilindro";
            LblVolumenCilindro.Size = new Size(0, 15);
            LblVolumenCilindro.TabIndex = 6;
            // 
            // Volumen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private Button BtnVolumenCubo;
        private Label lblVolumenCubo;
        private Label label2;
        private Button BtnVolumenEsfera;
        private TextBox txtRadioEsfera;
        private Label label3;
        private Label lblVolumenEsfera;
        private Label label4;
        private Label LblVolumenCilindro;
        private Label label7;
        private Button BtnVolumenCilindro;
        private TextBox txtRadioCilindro;
        private TextBox txtAlturaCilindro;
        private Label label6;
        private Label label5;
    }
}