namespace física_EH
{
    partial class Cinematica
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
            RJButton.RJButton BtnMRUV;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cinematica));
            label1 = new Label();
            BtnEcuaciónHoraria = new RJButton.RJButton();
            label2 = new Label();
            BtnMRUV = new RJButton.RJButton();
            SuspendLayout();
            // 
            // BtnMRUV
            // 
            BtnMRUV.BackColor = Color.MediumSlateBlue;
            BtnMRUV.BackgroundColor = Color.MediumSlateBlue;
            BtnMRUV.BorderColor = Color.PaleVioletRed;
            BtnMRUV.BorderRadius = 76;
            BtnMRUV.BorderSize = 1;
            BtnMRUV.FlatAppearance.BorderSize = 0;
            BtnMRUV.FlatStyle = FlatStyle.Flat;
            BtnMRUV.ForeColor = Color.White;
            BtnMRUV.Location = new Point(433, 102);
            BtnMRUV.Name = "BtnMRUV";
            BtnMRUV.Size = new Size(157, 155);
            BtnMRUV.TabIndex = 26;
            BtnMRUV.TextColor = Color.White;
            BtnMRUV.UseVisualStyleBackColor = false;
            BtnMRUV.Click += BtnMRUV_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(257, 260);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 25;
            label1.Text = "MRU";
            // 
            // BtnEcuaciónHoraria
            // 
            BtnEcuaciónHoraria.BackColor = Color.Teal;
            BtnEcuaciónHoraria.BackgroundColor = Color.Teal;
            BtnEcuaciónHoraria.BackgroundImage = (Image)resources.GetObject("BtnEcuaciónHoraria.BackgroundImage");
            BtnEcuaciónHoraria.BackgroundImageLayout = ImageLayout.Stretch;
            BtnEcuaciónHoraria.BorderColor = Color.Black;
            BtnEcuaciónHoraria.BorderRadius = 76;
            BtnEcuaciónHoraria.BorderSize = 1;
            BtnEcuaciónHoraria.Cursor = Cursors.Hand;
            BtnEcuaciónHoraria.FlatAppearance.BorderSize = 0;
            BtnEcuaciónHoraria.FlatStyle = FlatStyle.Flat;
            BtnEcuaciónHoraria.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEcuaciónHoraria.ForeColor = Color.Black;
            BtnEcuaciónHoraria.Location = new Point(205, 102);
            BtnEcuaciónHoraria.Name = "BtnEcuaciónHoraria";
            BtnEcuaciónHoraria.Size = new Size(157, 155);
            BtnEcuaciónHoraria.TabIndex = 24;
            BtnEcuaciónHoraria.TextAlign = ContentAlignment.MiddleRight;
            BtnEcuaciónHoraria.TextColor = Color.Black;
            BtnEcuaciónHoraria.UseVisualStyleBackColor = false;
            BtnEcuaciónHoraria.Click += BtnEcuaciónHoraria_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(481, 260);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 27;
            label2.Text = "MRUV";
            // 
            // Cinematica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(BtnMRUV);
            Controls.Add(label1);
            Controls.Add(BtnEcuaciónHoraria);
            Name = "Cinematica";
            Text = "Cinematica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RJButton.RJButton BtnEcuaciónHoraria;
        private Label label2;
    }
}