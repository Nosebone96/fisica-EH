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
            tabPage2 = new TabPage();
            Lblaceleraciondinamica = new Label();
            Lblmasadinamica = new Label();
            Lblfuerza = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            BtnLimpiarLD = new RJButton.RJButton();
            BtnCalcularLD = new RJButton.RJButton();
            txtFuerza = new TextBox();
            label5 = new Label();
            label3 = new Label();
            lblFuerzaApObjeto = new Label();
            txtAceleraciónDinamica = new TextBox();
            txtMasaDinamica = new TextBox();
            label4 = new Label();
            TabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            TabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Lblaceleraciondinamica);
            tabPage2.Controls.Add(Lblmasadinamica);
            tabPage2.Controls.Add(Lblfuerza);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(BtnLimpiarLD);
            tabPage2.Controls.Add(BtnCalcularLD);
            tabPage2.Controls.Add(txtFuerza);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(lblFuerzaApObjeto);
            tabPage2.Controls.Add(txtAceleraciónDinamica);
            tabPage2.Controls.Add(txtMasaDinamica);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(864, 411);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ley De Dinámica";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Lblaceleraciondinamica
            // 
            Lblaceleraciondinamica.AutoSize = true;
            Lblaceleraciondinamica.Location = new Point(658, 100);
            Lblaceleraciondinamica.Name = "Lblaceleraciondinamica";
            Lblaceleraciondinamica.Size = new Size(0, 15);
            Lblaceleraciondinamica.TabIndex = 29;
            // 
            // Lblmasadinamica
            // 
            Lblmasadinamica.AutoSize = true;
            Lblmasadinamica.Location = new Point(591, 144);
            Lblmasadinamica.Name = "Lblmasadinamica";
            Lblmasadinamica.Size = new Size(0, 15);
            Lblmasadinamica.TabIndex = 28;
            // 
            // Lblfuerza
            // 
            Lblfuerza.AutoSize = true;
            Lblfuerza.Location = new Point(630, 58);
            Lblfuerza.Name = "Lblfuerza";
            Lblfuerza.Size = new Size(0, 15);
            Lblfuerza.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(424, 144);
            label9.Name = "label9";
            label9.Size = new Size(139, 15);
            label9.TabIndex = 26;
            label9.Text = "La masa del objeto es de:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(424, 100);
            label8.Name = "label8";
            label8.Size = new Size(211, 15);
            label8.TabIndex = 25;
            label8.Text = "La aceleración aplicada al objeto es de:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(424, 58);
            label7.Name = "label7";
            label7.Size = new Size(183, 15);
            label7.TabIndex = 24;
            label7.Text = "La fuerza aplicada al objeto es de:";
            // 
            // BtnLimpiarLD
            // 
            BtnLimpiarLD.BackColor = Color.MediumSlateBlue;
            BtnLimpiarLD.BackgroundColor = Color.MediumSlateBlue;
            BtnLimpiarLD.BackgroundImage = (Image)resources.GetObject("BtnLimpiarLD.BackgroundImage");
            BtnLimpiarLD.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLimpiarLD.BorderColor = Color.FromArgb(192, 0, 0);
            BtnLimpiarLD.BorderRadius = 15;
            BtnLimpiarLD.BorderSize = 2;
            BtnLimpiarLD.FlatAppearance.BorderSize = 0;
            BtnLimpiarLD.FlatStyle = FlatStyle.Flat;
            BtnLimpiarLD.ForeColor = Color.White;
            BtnLimpiarLD.Location = new Point(259, 251);
            BtnLimpiarLD.Name = "BtnLimpiarLD";
            BtnLimpiarLD.Size = new Size(142, 35);
            BtnLimpiarLD.TabIndex = 23;
            BtnLimpiarLD.TextColor = Color.White;
            BtnLimpiarLD.UseVisualStyleBackColor = false;
            BtnLimpiarLD.Click += BtnLimpiarLD_Click;
            // 
            // BtnCalcularLD
            // 
            BtnCalcularLD.BackColor = Color.FromArgb(224, 224, 224);
            BtnCalcularLD.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnCalcularLD.BorderColor = Color.FromArgb(0, 0, 192);
            BtnCalcularLD.BorderRadius = 1;
            BtnCalcularLD.BorderSize = 2;
            BtnCalcularLD.FlatAppearance.BorderSize = 0;
            BtnCalcularLD.FlatStyle = FlatStyle.Flat;
            BtnCalcularLD.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcularLD.ForeColor = Color.Navy;
            BtnCalcularLD.Location = new Point(109, 251);
            BtnCalcularLD.Name = "BtnCalcularLD";
            BtnCalcularLD.Size = new Size(111, 36);
            BtnCalcularLD.TabIndex = 20;
            BtnCalcularLD.Text = "Calcular";
            BtnCalcularLD.TextColor = Color.Navy;
            BtnCalcularLD.UseVisualStyleBackColor = false;
            BtnCalcularLD.Click += BtnCalcularLD_Click;
            // 
            // txtFuerza
            // 
            txtFuerza.Location = new Point(260, 168);
            txtFuerza.Name = "txtFuerza";
            txtFuerza.Size = new Size(100, 23);
            txtFuerza.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 171);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 8;
            label5.Text = "Digite la fuerza:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 65);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 7;
            label3.Text = "Digite la masa del objeto:";
            // 
            // lblFuerzaApObjeto
            // 
            lblFuerzaApObjeto.AutoSize = true;
            lblFuerzaApObjeto.Location = new Point(229, 234);
            lblFuerzaApObjeto.Name = "lblFuerzaApObjeto";
            lblFuerzaApObjeto.Size = new Size(0, 15);
            lblFuerzaApObjeto.TabIndex = 5;
            // 
            // txtAceleraciónDinamica
            // 
            txtAceleraciónDinamica.Location = new Point(260, 114);
            txtAceleraciónDinamica.Name = "txtAceleraciónDinamica";
            txtAceleraciónDinamica.Size = new Size(100, 23);
            txtAceleraciónDinamica.TabIndex = 3;
            // 
            // txtMasaDinamica
            // 
            txtMasaDinamica.Location = new Point(259, 62);
            txtMasaDinamica.Name = "txtMasaDinamica";
            txtMasaDinamica.Size = new Size(100, 23);
            txtMasaDinamica.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 111);
            label4.Name = "label4";
            label4.Size = new Size(212, 15);
            label4.TabIndex = 1;
            label4.Text = "Digite la aceleración aplicada al objeto:";
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(tabPage2);
            TabControl1.Location = new Point(3, -1);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(872, 439);
            TabControl1.TabIndex = 0;
            // 
            // LeyesDeNewton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 521);
            Controls.Add(TabControl1);
            Name = "LeyesDeNewton";
            Text = "LeyesDeNewton";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            TabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private Label label3;
        private Label lblFuerzaApObjeto;
        private TextBox txtAceleraciónDinamica;
        private TextBox txtMasaDinamica;
        private Label label4;
        private TabControl TabControl1;
        private TextBox txtFuerza;
        private Label label5;
        private RJButton.RJButton BtnCalcularLD;
        private RJButton.RJButton BtnLimpiarLD;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label Lblaceleraciondinamica;
        private Label Lblmasadinamica;
        private Label Lblfuerza;
    }
}