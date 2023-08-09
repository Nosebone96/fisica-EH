namespace física_EH
{
    partial class MRUV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MRUV));
            BtnLimpiar = new RJButton.RJButton();
            BtnCalcular = new RJButton.RJButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtVelocidadInicial = new TextBox();
            txtDistancia = new TextBox();
            txtAceleración = new TextBox();
            txtTiempo = new TextBox();
            txtVelocidadFinal = new TextBox();
            lblVelocidadFinal = new Label();
            label6 = new Label();
            label7 = new Label();
            lblTiempo = new Label();
            label8 = new Label();
            lblAceleración = new Label();
            label9 = new Label();
            lblDistancia = new Label();
            label11 = new Label();
            label12 = new Label();
            label10 = new Label();
            lblVelocidadInicial = new Label();
            SuspendLayout();
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
            BtnLimpiar.Cursor = Cursors.Hand;
            BtnLimpiar.FlatAppearance.BorderSize = 0;
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.ForeColor = Color.White;
            BtnLimpiar.Location = new Point(236, 328);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(142, 35);
            BtnLimpiar.TabIndex = 24;
            BtnLimpiar.TextColor = Color.White;
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.FromArgb(224, 224, 224);
            BtnCalcular.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnCalcular.BorderColor = Color.FromArgb(0, 0, 192);
            BtnCalcular.BorderRadius = 1;
            BtnCalcular.BorderSize = 2;
            BtnCalcular.Cursor = Cursors.Hand;
            BtnCalcular.FlatAppearance.BorderSize = 0;
            BtnCalcular.FlatStyle = FlatStyle.Flat;
            BtnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcular.ForeColor = Color.Navy;
            BtnCalcular.Location = new Point(98, 326);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(111, 36);
            BtnCalcular.TabIndex = 23;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.TextColor = Color.Navy;
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 47);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 25;
            label1.Text = "Digite la velocidad inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 97);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 26;
            label2.Text = "Digite la velocidad final:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 145);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 27;
            label3.Text = "Digite el tiempo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 204);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 28;
            label4.Text = "Digite la gravedad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 251);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 29;
            label5.Text = "Digite la distancia:";
            // 
            // txtVelocidadInicial
            // 
            txtVelocidadInicial.Cursor = Cursors.Hand;
            txtVelocidadInicial.Location = new Point(236, 44);
            txtVelocidadInicial.Name = "txtVelocidadInicial";
            txtVelocidadInicial.Size = new Size(100, 23);
            txtVelocidadInicial.TabIndex = 30;
            // 
            // txtDistancia
            // 
            txtDistancia.BackColor = Color.White;
            txtDistancia.Cursor = Cursors.Hand;
            txtDistancia.Location = new Point(236, 248);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(100, 23);
            txtDistancia.TabIndex = 31;
            // 
            // txtAceleración
            // 
            txtAceleración.Cursor = Cursors.Hand;
            txtAceleración.Location = new Point(236, 196);
            txtAceleración.Name = "txtAceleración";
            txtAceleración.Size = new Size(100, 23);
            txtAceleración.TabIndex = 32;
            // 
            // txtTiempo
            // 
            txtTiempo.Cursor = Cursors.Hand;
            txtTiempo.Location = new Point(236, 142);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(100, 23);
            txtTiempo.TabIndex = 33;
            // 
            // txtVelocidadFinal
            // 
            txtVelocidadFinal.Cursor = Cursors.Hand;
            txtVelocidadFinal.Location = new Point(236, 94);
            txtVelocidadFinal.Name = "txtVelocidadFinal";
            txtVelocidadFinal.Size = new Size(100, 23);
            txtVelocidadFinal.TabIndex = 34;
            // 
            // lblVelocidadFinal
            // 
            lblVelocidadFinal.AutoSize = true;
            lblVelocidadFinal.Location = new Point(507, 150);
            lblVelocidadFinal.Name = "lblVelocidadFinal";
            lblVelocidadFinal.Size = new Size(0, 15);
            lblVelocidadFinal.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(422, 81);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 52);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 37;
            label7.Text = "el tiempo es:";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(507, 53);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(0, 15);
            lblTiempo.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(400, 81);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 39;
            label8.Text = "la aceleración es:";
            // 
            // lblAceleración
            // 
            lblAceleración.AutoSize = true;
            lblAceleración.Location = new Point(506, 83);
            lblAceleración.Name = "lblAceleración";
            lblAceleración.Size = new Size(0, 15);
            lblAceleración.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(410, 115);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 41;
            label9.Text = "La distancia es:";
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(500, 114);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(0, 15);
            lblDistancia.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(384, 150);
            label11.Name = "label11";
            label11.Size = new Size(116, 15);
            label11.TabIndex = 46;
            label11.Text = "La velocidad final es:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(500, 148);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 47;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(372, 183);
            label10.Name = "label10";
            label10.Size = new Size(124, 15);
            label10.TabIndex = 48;
            label10.Text = "La velocidad inicial es:";
            // 
            // lblVelocidadInicial
            // 
            lblVelocidadInicial.AutoSize = true;
            lblVelocidadInicial.Location = new Point(503, 183);
            lblVelocidadInicial.Name = "lblVelocidadInicial";
            lblVelocidadInicial.Size = new Size(0, 15);
            lblVelocidadInicial.TabIndex = 49;
            // 
            // MRUV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVelocidadInicial);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(lblDistancia);
            Controls.Add(label9);
            Controls.Add(lblAceleración);
            Controls.Add(label8);
            Controls.Add(lblTiempo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblVelocidadFinal);
            Controls.Add(txtVelocidadFinal);
            Controls.Add(txtTiempo);
            Controls.Add(txtAceleración);
            Controls.Add(txtDistancia);
            Controls.Add(txtVelocidadInicial);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnCalcular);
            Name = "MRUV";
            Text = "MRUV";
            Load += MRUV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RJButton.RJButton BtnLimpiar;
        private RJButton.RJButton BtnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtVelocidadInicial;
        private TextBox txtDistancia;
        private TextBox txtAceleración;
        private TextBox txtTiempo;
        private TextBox txtVelocidadFinal;
        private Label lblVelocidadFinal;
        private Label label6;
        private Label label7;
        private Label lblTiempo;
        private Label label8;
        private Label lblAceleración;
        private Label label9;
        private Label lblDistancia;
        private Label label11;
        private Label label12;
        private Label label10;
        private Label lblVelocidadInicial;
    }
}