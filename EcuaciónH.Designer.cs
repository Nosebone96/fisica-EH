namespace física_EH
{
    partial class EcuaciónH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcuaciónH));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtVelocidad = new TextBox();
            txtTiempo = new TextBox();
            TxtDistancia = new TextBox();
            BtnLimpiarMRU = new RJButton.RJButton();
            BtnMRU = new RJButton.RJButton();
            lblVelociad = new Label();
            lblDistancia = new Label();
            LblTiempo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 127);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite la velocidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 171);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite la distancia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 219);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "Digite el tiempo:";
            // 
            // TxtVelocidad
            // 
            TxtVelocidad.Location = new Point(212, 124);
            TxtVelocidad.Name = "TxtVelocidad";
            TxtVelocidad.Size = new Size(100, 23);
            TxtVelocidad.TabIndex = 3;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(212, 216);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(100, 23);
            txtTiempo.TabIndex = 4;
            // 
            // TxtDistancia
            // 
            TxtDistancia.Location = new Point(212, 163);
            TxtDistancia.Name = "TxtDistancia";
            TxtDistancia.Size = new Size(100, 23);
            TxtDistancia.TabIndex = 5;
            // 
            // BtnLimpiarMRU
            // 
            BtnLimpiarMRU.BackColor = Color.MediumSlateBlue;
            BtnLimpiarMRU.BackgroundColor = Color.MediumSlateBlue;
            BtnLimpiarMRU.BackgroundImage = (Image)resources.GetObject("BtnLimpiarMRU.BackgroundImage");
            BtnLimpiarMRU.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLimpiarMRU.BorderColor = Color.FromArgb(192, 0, 0);
            BtnLimpiarMRU.BorderRadius = 15;
            BtnLimpiarMRU.BorderSize = 2;
            BtnLimpiarMRU.FlatAppearance.BorderSize = 0;
            BtnLimpiarMRU.FlatStyle = FlatStyle.Flat;
            BtnLimpiarMRU.ForeColor = Color.White;
            BtnLimpiarMRU.Location = new Point(179, 289);
            BtnLimpiarMRU.Name = "BtnLimpiarMRU";
            BtnLimpiarMRU.Size = new Size(142, 35);
            BtnLimpiarMRU.TabIndex = 24;
            BtnLimpiarMRU.TextColor = Color.White;
            BtnLimpiarMRU.UseVisualStyleBackColor = false;
            BtnLimpiarMRU.Click += BtnLimpiarMRU_Click;
            // 
            // BtnMRU
            // 
            BtnMRU.BackColor = Color.FromArgb(224, 224, 224);
            BtnMRU.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnMRU.BorderColor = Color.FromArgb(0, 0, 192);
            BtnMRU.BorderRadius = 1;
            BtnMRU.BorderSize = 2;
            BtnMRU.FlatAppearance.BorderSize = 0;
            BtnMRU.FlatStyle = FlatStyle.Flat;
            BtnMRU.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMRU.ForeColor = Color.Navy;
            BtnMRU.Location = new Point(62, 289);
            BtnMRU.Name = "BtnMRU";
            BtnMRU.Size = new Size(111, 36);
            BtnMRU.TabIndex = 23;
            BtnMRU.Text = "Calcular";
            BtnMRU.TextColor = Color.Navy;
            BtnMRU.UseVisualStyleBackColor = false;
            BtnMRU.Click += BtnMRU_Click;
            // 
            // lblVelociad
            // 
            lblVelociad.AutoSize = true;
            lblVelociad.Location = new Point(407, 119);
            lblVelociad.Name = "lblVelociad";
            lblVelociad.Size = new Size(0, 15);
            lblVelociad.TabIndex = 25;
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(407, 144);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(0, 15);
            lblDistancia.TabIndex = 26;
            // 
            // LblTiempo
            // 
            LblTiempo.AutoSize = true;
            LblTiempo.Location = new Point(407, 166);
            LblTiempo.Name = "LblTiempo";
            LblTiempo.Size = new Size(0, 15);
            LblTiempo.TabIndex = 27;
            // 
            // EcuaciónH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblTiempo);
            Controls.Add(lblDistancia);
            Controls.Add(lblVelociad);
            Controls.Add(BtnLimpiarMRU);
            Controls.Add(BtnMRU);
            Controls.Add(TxtDistancia);
            Controls.Add(txtTiempo);
            Controls.Add(TxtVelocidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EcuaciónH";
            Text = "MRU";
            Load += EcuaciónH_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtVelocidad;
        private TextBox txtTiempo;
        private TextBox TxtDistancia;
        private RJButton.RJButton BtnLimpiarMRU;
        private RJButton.RJButton BtnMRU;
        private Label lblVelociad;
        private Label lblDistancia;
        private Label LblTiempo;
    }
}