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
            TxtVelocidad = new TextBox();
            txtTiempo = new TextBox();
            TxtDistancia = new TextBox();
            BtnLimpiarMRU = new RJButton.RJButton();
            BtnMRU = new RJButton.RJButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TxtVelocidad
            // 
            TxtVelocidad.BorderStyle = BorderStyle.FixedSingle;
            TxtVelocidad.Location = new Point(53, 320);
            TxtVelocidad.Name = "TxtVelocidad";
            TxtVelocidad.Size = new Size(100, 23);
            TxtVelocidad.TabIndex = 3;
            // 
            // txtTiempo
            // 
            txtTiempo.BorderStyle = BorderStyle.FixedSingle;
            txtTiempo.Location = new Point(187, 320);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(100, 23);
            txtTiempo.TabIndex = 4;
            // 
            // TxtDistancia
            // 
            TxtDistancia.BorderStyle = BorderStyle.FixedSingle;
            TxtDistancia.Location = new Point(239, 96);
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
            BtnLimpiarMRU.Location = new Point(159, 386);
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
            BtnMRU.Location = new Point(42, 386);
            BtnMRU.Name = "BtnMRU";
            BtnMRU.Size = new Size(111, 36);
            BtnMRU.TabIndex = 23;
            BtnMRU.Text = "Calcular";
            BtnMRU.TextColor = Color.Navy;
            BtnMRU.UseVisualStyleBackColor = false;
            BtnMRU.Click += BtnMRU_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(54, 57, 62);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 302);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(242, 122);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 29;
            label1.Text = "Distancia (m)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(53, 346);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 30;
            label2.Text = "Velocidad (m/s)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(203, 346);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 31;
            label3.Text = "Tiempo (s)";
            // 
            // EcuaciónH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(362, 436);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnLimpiarMRU);
            Controls.Add(BtnMRU);
            Controls.Add(TxtDistancia);
            Controls.Add(txtTiempo);
            Controls.Add(TxtVelocidad);
            Controls.Add(pictureBox1);
            Name = "EcuaciónH";
            Text = "MRU";
            Load += EcuaciónH_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtVelocidad;
        private TextBox txtTiempo;
        private TextBox TxtDistancia;
        private RJButton.RJButton BtnLimpiarMRU;
        private RJButton.RJButton BtnMRU;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}