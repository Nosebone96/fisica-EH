namespace física_EH
{
    partial class Resistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resistencia));
            LblTolerancia = new Label();
            LblValorRealR = new Label();
            LblValorNormal = new Label();
            CbColorFranja3 = new ComboBox();
            ColorFranja4 = new ComboBox();
            CbColorFranja2 = new ComboBox();
            CbColorFranja1 = new ComboBox();
            BtnCalcularRTeorica = new RJButton.RJButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnLimpiar = new RJButton.RJButton();
            SuspendLayout();
            // 
            // LblTolerancia
            // 
            LblTolerancia.AutoSize = true;
            LblTolerancia.Location = new Point(324, 62);
            LblTolerancia.Name = "LblTolerancia";
            LblTolerancia.Size = new Size(161, 15);
            LblTolerancia.TabIndex = 73;
            LblTolerancia.Text = "El valor de la tolerancia es de:";
            // 
            // LblValorRealR
            // 
            LblValorRealR.AutoSize = true;
            LblValorRealR.Location = new Point(324, 87);
            LblValorRealR.Name = "LblValorRealR";
            LblValorRealR.Size = new Size(137, 15);
            LblValorRealR.TabIndex = 72;
            LblValorRealR.Text = "El valor real ronda entre: ";
            // 
            // LblValorNormal
            // 
            LblValorNormal.AutoSize = true;
            LblValorNormal.Location = new Point(324, 38);
            LblValorNormal.Name = "LblValorNormal";
            LblValorNormal.Size = new Size(158, 15);
            LblValorNormal.TabIndex = 71;
            LblValorNormal.Text = "El valor Normal o teórico es: ";
            // 
            // CbColorFranja3
            // 
            CbColorFranja3.BackColor = Color.FromArgb(224, 224, 224);
            CbColorFranja3.DropDownStyle = ComboBoxStyle.DropDownList;
            CbColorFranja3.FlatStyle = FlatStyle.Popup;
            CbColorFranja3.FormattingEnabled = true;
            CbColorFranja3.Items.AddRange(new object[] { "Negro", "Cafe", "Rojo", "Naranja", "Amarillo", "Verde", "Azul", "Morado", "Gris", "Blanco" });
            CbColorFranja3.Location = new Point(218, 123);
            CbColorFranja3.Name = "CbColorFranja3";
            CbColorFranja3.Size = new Size(88, 23);
            CbColorFranja3.TabIndex = 70;
            // 
            // ColorFranja4
            // 
            ColorFranja4.BackColor = Color.FromArgb(224, 224, 224);
            ColorFranja4.DropDownStyle = ComboBoxStyle.DropDownList;
            ColorFranja4.FlatStyle = FlatStyle.Popup;
            ColorFranja4.FormattingEnabled = true;
            ColorFranja4.Items.AddRange(new object[] { "Dorado", "Plateado", "Rojo", "Cafe", "Verde", "Azul", "Morado", "Gris", "Sin Color " });
            ColorFranja4.Location = new Point(218, 165);
            ColorFranja4.Name = "ColorFranja4";
            ColorFranja4.Size = new Size(88, 23);
            ColorFranja4.TabIndex = 69;
            // 
            // CbColorFranja2
            // 
            CbColorFranja2.BackColor = Color.FromArgb(224, 224, 224);
            CbColorFranja2.DropDownStyle = ComboBoxStyle.DropDownList;
            CbColorFranja2.FlatStyle = FlatStyle.Popup;
            CbColorFranja2.FormattingEnabled = true;
            CbColorFranja2.Items.AddRange(new object[] { "Negro", "Cafe", "Rojo", "Naranja", "Amarillo", "Verde", "Azul", "Morado", "Gris", "Blanco" });
            CbColorFranja2.Location = new Point(218, 79);
            CbColorFranja2.Name = "CbColorFranja2";
            CbColorFranja2.Size = new Size(88, 23);
            CbColorFranja2.TabIndex = 68;
            // 
            // CbColorFranja1
            // 
            CbColorFranja1.BackColor = Color.FromArgb(224, 224, 224);
            CbColorFranja1.DropDownStyle = ComboBoxStyle.DropDownList;
            CbColorFranja1.FlatStyle = FlatStyle.Popup;
            CbColorFranja1.FormattingEnabled = true;
            CbColorFranja1.Items.AddRange(new object[] { "Negro", "Cafe", "Rojo", "Naranja", "Amarillo", "Verde", "Azul", "Morado", "Gris", "Blanco" });
            CbColorFranja1.Location = new Point(218, 38);
            CbColorFranja1.Name = "CbColorFranja1";
            CbColorFranja1.Size = new Size(88, 23);
            CbColorFranja1.TabIndex = 67;
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
            BtnCalcularRTeorica.Location = new Point(34, 208);
            BtnCalcularRTeorica.Name = "BtnCalcularRTeorica";
            BtnCalcularRTeorica.Size = new Size(111, 36);
            BtnCalcularRTeorica.TabIndex = 65;
            BtnCalcularRTeorica.Text = "Calcular";
            BtnCalcularRTeorica.TextColor = Color.Navy;
            BtnCalcularRTeorica.UseVisualStyleBackColor = false;
            BtnCalcularRTeorica.Click += BtnCalcularRTeorica_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 168);
            label4.Name = "label4";
            label4.Size = new Size(183, 15);
            label4.TabIndex = 64;
            label4.Text = "Digite el color de la cuarta franja: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 126);
            label3.Name = "label3";
            label3.Size = new Size(183, 15);
            label3.TabIndex = 63;
            label3.Text = "Digite el color de la tercera franja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 82);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 62;
            label2.Text = "Digite el color de la segunda franja:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 61;
            label1.Text = "Digite el color de la primera franja:";
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.MediumSlateBlue;
            BtnLimpiar.BackgroundColor = Color.MediumSlateBlue;
            BtnLimpiar.BackgroundImage = (Image)resources.GetObject("BtnLimpiar.BackgroundImage");
            BtnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLimpiar.BorderColor = Color.FromArgb(192, 0, 0);
            BtnLimpiar.BorderRadius = 15;
            BtnLimpiar.BorderSize = 2;
            BtnLimpiar.FlatAppearance.BorderSize = 0;
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.ForeColor = Color.White;
            BtnLimpiar.Location = new Point(185, 208);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(142, 35);
            BtnLimpiar.TabIndex = 74;
            BtnLimpiar.TextColor = Color.White;
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // Resistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 274);
            Controls.Add(BtnLimpiar);
            Controls.Add(LblTolerancia);
            Controls.Add(LblValorRealR);
            Controls.Add(LblValorNormal);
            Controls.Add(CbColorFranja3);
            Controls.Add(ColorFranja4);
            Controls.Add(CbColorFranja2);
            Controls.Add(CbColorFranja1);
            Controls.Add(BtnCalcularRTeorica);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Resistencia";
            StartPosition = FormStartPosition.Manual;
            Text = "Resistencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTolerancia;
        private Label LblValorRealR;
        private Label LblValorNormal;
        private ComboBox CbColorFranja3;
        private ComboBox ColorFranja4;
        private ComboBox CbColorFranja2;
        private ComboBox CbColorFranja1;
        private RJButton.RJButton BtnCalcularRTeorica;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RJButton.RJButton BtnLimpiar;
    }
}