namespace física_EH
{
    partial class Dinámica
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
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            RJButton.RJButton BtnNewton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dinámica));
            label3 = new Label();
            BtnNewton = new RJButton.RJButton();
            SuspendLayout();
            // 
            // BtnNewton
            // 
            BtnNewton.BackColor = Color.MediumSlateBlue;
            BtnNewton.BackgroundColor = Color.MediumSlateBlue;
            BtnNewton.BackgroundImage = (Image)resources.GetObject("BtnNewton.BackgroundImage");
            BtnNewton.BackgroundImageLayout = ImageLayout.Stretch;
            BtnNewton.BorderColor = Color.FromArgb(0, 192, 0);
            BtnNewton.BorderRadius = 44;
            BtnNewton.BorderSize = 1;
            BtnNewton.Cursor = Cursors.Hand;
            BtnNewton.FlatAppearance.BorderSize = 0;
            BtnNewton.FlatStyle = FlatStyle.Flat;
            BtnNewton.ForeColor = Color.White;
            BtnNewton.Location = new Point(143, 105);
            BtnNewton.Name = "BtnNewton";
            BtnNewton.Size = new Size(91, 88);
            BtnNewton.TabIndex = 16;
            BtnNewton.TextColor = Color.White;
            BtnNewton.UseVisualStyleBackColor = false;
            BtnNewton.Click += BtnNewton_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(119, 196);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 17;
            label3.Text = "Leyes De Newton";
            // 
            // Dinámica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 294);
            Controls.Add(label3);
            Controls.Add(BtnNewton);
            Name = "Dinámica";
            Text = "Dinámica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
    }
}