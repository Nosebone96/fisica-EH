namespace física_EH
{
    partial class Mecánica
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
            RJButton.RJButton BtnCinematica;
            RJButton.RJButton BtnDinamica;
            label5 = new Label();
            Dinámica = new Label();
            BtnCinematica = new RJButton.RJButton();
            BtnDinamica = new RJButton.RJButton();
            SuspendLayout();
            // 
            // BtnCinematica
            // 
            BtnCinematica.BackColor = Color.GhostWhite;
            BtnCinematica.BackgroundColor = Color.GhostWhite;
            BtnCinematica.BorderColor = Color.PaleVioletRed;
            BtnCinematica.BorderRadius = 75;
            BtnCinematica.BorderSize = 1;
            BtnCinematica.FlatAppearance.BorderSize = 0;
            BtnCinematica.FlatStyle = FlatStyle.Flat;
            BtnCinematica.ForeColor = Color.White;
            BtnCinematica.Location = new Point(45, 51);
            BtnCinematica.Name = "BtnCinematica";
            BtnCinematica.Size = new Size(150, 149);
            BtnCinematica.TabIndex = 26;
            BtnCinematica.TextColor = Color.White;
            BtnCinematica.UseVisualStyleBackColor = false;
            BtnCinematica.Click += BtnCinematica_Click;
            // 
            // BtnDinamica
            // 
            BtnDinamica.BackColor = Color.GhostWhite;
            BtnDinamica.BackgroundColor = Color.GhostWhite;
            BtnDinamica.BorderColor = Color.PaleVioletRed;
            BtnDinamica.BorderRadius = 75;
            BtnDinamica.BorderSize = 1;
            BtnDinamica.FlatAppearance.BorderSize = 0;
            BtnDinamica.FlatStyle = FlatStyle.Flat;
            BtnDinamica.ForeColor = Color.White;
            BtnDinamica.Location = new Point(265, 51);
            BtnDinamica.Name = "BtnDinamica";
            BtnDinamica.Size = new Size(150, 149);
            BtnDinamica.TabIndex = 28;
            BtnDinamica.TextColor = Color.White;
            BtnDinamica.UseVisualStyleBackColor = false;
            BtnDinamica.Click += BtnDinamica_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(75, 203);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 27;
            label5.Text = "Cinemática";
            // 
            // Dinámica
            // 
            Dinámica.AutoSize = true;
            Dinámica.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Dinámica.Location = new Point(301, 203);
            Dinámica.Name = "Dinámica";
            Dinámica.Size = new Size(87, 21);
            Dinámica.TabIndex = 29;
            Dinámica.Text = "Dinámica   ";
            // 
            // Mecánica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 288);
            Controls.Add(Dinámica);
            Controls.Add(BtnDinamica);
            Controls.Add(label5);
            Controls.Add(BtnCinematica);
            Name = "Mecánica";
            Text = "Mecánica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label Dinámica;
    }
}