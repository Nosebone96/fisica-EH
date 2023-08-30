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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Electrónica));
            tabControl1 = new TabControl();
            TabPage1 = new TabPage();
            LblTolerancia = new Label();
            LblValorRealR = new Label();
            LblValorNormal = new Label();
            CbColorFranja3 = new ComboBox();
            ColorFranja4 = new ComboBox();
            CbColorFranja2 = new ComboBox();
            CbColorFranja1 = new ComboBox();
            BtnLimpiarResistencia = new RJButton.RJButton();
            BtnCalcularRTeorica = new RJButton.RJButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TabPage2 = new TabPage();
            BtnLimpiarOhm = new RJButton.RJButton();
            BtnCalcularOhm = new RJButton.RJButton();
            TxtResistenciaOhm = new TextBox();
            TxtCorrienteOhm = new TextBox();
            TxtVoltageOhm = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPage1);
            tabControl1.Controls.Add(TabPage2);
            tabControl1.Location = new Point(-1, -2);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(719, 388);
            tabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(LblTolerancia);
            TabPage1.Controls.Add(LblValorRealR);
            TabPage1.Controls.Add(LblValorNormal);
            TabPage1.Controls.Add(CbColorFranja3);
            TabPage1.Controls.Add(ColorFranja4);
            TabPage1.Controls.Add(CbColorFranja2);
            TabPage1.Controls.Add(CbColorFranja1);
            TabPage1.Controls.Add(BtnLimpiarResistencia);
            TabPage1.Controls.Add(BtnCalcularRTeorica);
            TabPage1.Controls.Add(label4);
            TabPage1.Controls.Add(label3);
            TabPage1.Controls.Add(label2);
            TabPage1.Controls.Add(label1);
            TabPage1.Location = new Point(4, 24);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(711, 360);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Resistencia";
            TabPage1.UseVisualStyleBackColor = true;
            TabPage1.Click += TabPage1_Click;
            // 
            // LblTolerancia
            // 
            LblTolerancia.AutoSize = true;
            LblTolerancia.Location = new Point(384, 107);
            LblTolerancia.Name = "LblTolerancia";
            LblTolerancia.Size = new Size(161, 15);
            LblTolerancia.TabIndex = 60;
            LblTolerancia.Text = "El valor de la tolerancia es de:";
            // 
            // LblValorRealR
            // 
            LblValorRealR.AutoSize = true;
            LblValorRealR.Location = new Point(384, 132);
            LblValorRealR.Name = "LblValorRealR";
            LblValorRealR.Size = new Size(137, 15);
            LblValorRealR.TabIndex = 59;
            LblValorRealR.Text = "El valor real ronda entre: ";
            // 
            // LblValorNormal
            // 
            LblValorNormal.AutoSize = true;
            LblValorNormal.Location = new Point(384, 83);
            LblValorNormal.Name = "LblValorNormal";
            LblValorNormal.Size = new Size(158, 15);
            LblValorNormal.TabIndex = 58;
            LblValorNormal.Text = "El valor Normal o teórico es: ";
            // 
            // CbColorFranja3
            // 
            CbColorFranja3.BackColor = Color.FromArgb(224, 224, 224);
            CbColorFranja3.DropDownStyle = ComboBoxStyle.DropDownList;
            CbColorFranja3.FlatStyle = FlatStyle.Popup;
            CbColorFranja3.FormattingEnabled = true;
            CbColorFranja3.Items.AddRange(new object[] { "Negro", "Cafe", "Rojo", "Naranja", "Amarillo", "Verde", "Azul", "Morado", "Gris", "Blanco" });
            CbColorFranja3.Location = new Point(278, 168);
            CbColorFranja3.Name = "CbColorFranja3";
            CbColorFranja3.Size = new Size(88, 23);
            CbColorFranja3.TabIndex = 57;
            // 
            // ColorFranja4
            // 
            ColorFranja4.BackColor = Color.FromArgb(224, 224, 224);
            ColorFranja4.DropDownStyle = ComboBoxStyle.DropDownList;
            ColorFranja4.FlatStyle = FlatStyle.Popup;
            ColorFranja4.FormattingEnabled = true;
            ColorFranja4.Items.AddRange(new object[] { "Dorado", "Plateado", "Rojo", "Cafe", "Verde", "Azul", "Morado", "Gris", "Sin Color " });
            ColorFranja4.Location = new Point(278, 210);
            ColorFranja4.Name = "ColorFranja4";
            ColorFranja4.Size = new Size(88, 23);
            ColorFranja4.TabIndex = 56;
            // 
            // CbColorFranja2
            // 
            CbColorFranja2.BackColor = Color.FromArgb(224, 224, 224);
            CbColorFranja2.DropDownStyle = ComboBoxStyle.DropDownList;
            CbColorFranja2.FlatStyle = FlatStyle.Popup;
            CbColorFranja2.FormattingEnabled = true;
            CbColorFranja2.Items.AddRange(new object[] { "Negro", "Cafe", "Rojo", "Naranja", "Amarillo", "Verde", "Azul", "Morado", "Gris", "Blanco" });
            CbColorFranja2.Location = new Point(278, 124);
            CbColorFranja2.Name = "CbColorFranja2";
            CbColorFranja2.Size = new Size(88, 23);
            CbColorFranja2.TabIndex = 55;
            // 
            // CbColorFranja1
            // 
            CbColorFranja1.BackColor = Color.FromArgb(224, 224, 224);
            CbColorFranja1.DropDownStyle = ComboBoxStyle.DropDownList;
            CbColorFranja1.FlatStyle = FlatStyle.Popup;
            CbColorFranja1.FormattingEnabled = true;
            CbColorFranja1.Items.AddRange(new object[] { "Negro", "Cafe", "Rojo", "Naranja", "Amarillo", "Verde", "Azul", "Morado", "Gris", "Blanco" });
            CbColorFranja1.Location = new Point(278, 83);
            CbColorFranja1.Name = "CbColorFranja1";
            CbColorFranja1.Size = new Size(88, 23);
            CbColorFranja1.TabIndex = 54;
            // 
            // BtnLimpiarResistencia
            // 
            BtnLimpiarResistencia.BackColor = Color.MediumSlateBlue;
            BtnLimpiarResistencia.BackgroundColor = Color.MediumSlateBlue;
            BtnLimpiarResistencia.BackgroundImage = (Image)resources.GetObject("BtnLimpiarResistencia.BackgroundImage");
            BtnLimpiarResistencia.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLimpiarResistencia.BorderColor = Color.FromArgb(192, 0, 0);
            BtnLimpiarResistencia.BorderRadius = 15;
            BtnLimpiarResistencia.BorderSize = 2;
            BtnLimpiarResistencia.Cursor = Cursors.Hand;
            BtnLimpiarResistencia.FlatAppearance.BorderSize = 0;
            BtnLimpiarResistencia.FlatStyle = FlatStyle.Flat;
            BtnLimpiarResistencia.ForeColor = Color.White;
            BtnLimpiarResistencia.Location = new Point(224, 287);
            BtnLimpiarResistencia.Name = "BtnLimpiarResistencia";
            BtnLimpiarResistencia.Size = new Size(142, 35);
            BtnLimpiarResistencia.TabIndex = 53;
            BtnLimpiarResistencia.TextColor = Color.White;
            BtnLimpiarResistencia.UseVisualStyleBackColor = false;
            BtnLimpiarResistencia.Click += BtnLimpiarResistencia_Click;
            // 
            // BtnCalcularRTeorica
            // 
            BtnCalcularRTeorica.BackColor = Color.FromArgb(224, 224, 224);
            BtnCalcularRTeorica.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnCalcularRTeorica.BorderColor = Color.FromArgb(0, 0, 192);
            BtnCalcularRTeorica.BorderRadius = 1;
            BtnCalcularRTeorica.BorderSize = 2;
            BtnCalcularRTeorica.Cursor = Cursors.Hand;
            BtnCalcularRTeorica.FlatAppearance.BorderSize = 0;
            BtnCalcularRTeorica.FlatStyle = FlatStyle.Flat;
            BtnCalcularRTeorica.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcularRTeorica.ForeColor = Color.Navy;
            BtnCalcularRTeorica.Location = new Point(86, 285);
            BtnCalcularRTeorica.Name = "BtnCalcularRTeorica";
            BtnCalcularRTeorica.Size = new Size(111, 36);
            BtnCalcularRTeorica.TabIndex = 52;
            BtnCalcularRTeorica.Text = "Calcular";
            BtnCalcularRTeorica.TextColor = Color.Navy;
            BtnCalcularRTeorica.UseVisualStyleBackColor = false;
            BtnCalcularRTeorica.Click += BtnCalcularRTeorica_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 213);
            label4.Name = "label4";
            label4.Size = new Size(183, 15);
            label4.TabIndex = 3;
            label4.Text = "Digite el color de la cuarta franja: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 171);
            label3.Name = "label3";
            label3.Size = new Size(183, 15);
            label3.TabIndex = 2;
            label3.Text = "Digite el color de la tercera franja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 127);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite el color de la segunda franja:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 87);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite el color de la primera franja:";
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(BtnLimpiarOhm);
            TabPage2.Controls.Add(BtnCalcularOhm);
            TabPage2.Controls.Add(TxtResistenciaOhm);
            TabPage2.Controls.Add(TxtCorrienteOhm);
            TabPage2.Controls.Add(TxtVoltageOhm);
            TabPage2.Controls.Add(label7);
            TabPage2.Controls.Add(label6);
            TabPage2.Controls.Add(label5);
            TabPage2.Controls.Add(pictureBox1);
            TabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TabPage2.Location = new Point(4, 24);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(711, 360);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Ley de Ohm";
            TabPage2.UseVisualStyleBackColor = true;
            TabPage2.Click += TabPage2_Click;
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
            BtnLimpiarOhm.Location = new Point(340, 291);
            BtnLimpiarOhm.Name = "BtnLimpiarOhm";
            BtnLimpiarOhm.Size = new Size(142, 36);
            BtnLimpiarOhm.TabIndex = 55;
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
            BtnCalcularOhm.Location = new Point(203, 291);
            BtnCalcularOhm.Name = "BtnCalcularOhm";
            BtnCalcularOhm.Size = new Size(111, 36);
            BtnCalcularOhm.TabIndex = 54;
            BtnCalcularOhm.Text = "Calcular";
            BtnCalcularOhm.TextColor = Color.Navy;
            BtnCalcularOhm.UseVisualStyleBackColor = false;
            BtnCalcularOhm.Click += BtnCalcularOhm_Click;
            // 
            // TxtResistenciaOhm
            // 
            TxtResistenciaOhm.BorderStyle = BorderStyle.FixedSingle;
            TxtResistenciaOhm.Location = new Point(320, 215);
            TxtResistenciaOhm.Name = "TxtResistenciaOhm";
            TxtResistenciaOhm.Size = new Size(100, 23);
            TxtResistenciaOhm.TabIndex = 5;
            // 
            // TxtCorrienteOhm
            // 
            TxtCorrienteOhm.BorderStyle = BorderStyle.FixedSingle;
            TxtCorrienteOhm.Location = new Point(214, 215);
            TxtCorrienteOhm.Name = "TxtCorrienteOhm";
            TxtCorrienteOhm.Size = new Size(100, 23);
            TxtCorrienteOhm.TabIndex = 4;
            // 
            // TxtVoltageOhm
            // 
            TxtVoltageOhm.BorderStyle = BorderStyle.FixedSingle;
            TxtVoltageOhm.Location = new Point(363, 78);
            TxtVoltageOhm.Name = "TxtVoltageOhm";
            TxtVoltageOhm.Size = new Size(100, 23);
            TxtVoltageOhm.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(226, 241);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 2;
            label7.Text = "Corriente (A) ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(326, 241);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 1;
            label6.Text = "Resistencia(Ω)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(384, 104);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 0;
            label5.Text = "Voltaje (V)";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(186, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 244);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Electrónica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 386);
            Controls.Add(tabControl1);
            Name = "Electrónica";
            Text = "Electrónica";
            tabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            TabPage2.ResumeLayout(false);
            TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TabPage1;
        private TabPage TabPage2;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private RJButton.RJButton BtnLimpiarResistencia;
        private RJButton.RJButton BtnCalcularRTeorica;
        private ComboBox CbColorFranja1;
        private ComboBox CbColorFranja3;
        private ComboBox ColorFranja4;
        private ComboBox CbColorFranja2;
        private Label LblValorNormal;
        private Label LblValorRealR;
        private Label LblTolerancia;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox TxtResistenciaOhm;
        private TextBox TxtCorrienteOhm;
        private TextBox TxtVoltageOhm;
        private PictureBox pictureBox1;
        private RJButton.RJButton BtnLimpiarOhm;
        private RJButton.RJButton BtnCalcularOhm;
    }
}