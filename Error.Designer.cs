namespace física_EH
{
    partial class Error
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
            label1 = new Label();
            label2 = new Label();
            txtvalA = new TextBox();
            txtvalEx = new TextBox();
            label3 = new Label();
            lblporerror1 = new Label();
            Btnlimpiar = new Button();
            Btnpor = new RJButton.RJButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 95);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite el valor aceptado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 141);
            label2.Name = "label2";
            label2.Size = new Size(166, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite el valor experimental:";
            // 
            // txtvalA
            // 
            txtvalA.Location = new Point(287, 87);
            txtvalA.Name = "txtvalA";
            txtvalA.Size = new Size(100, 23);
            txtvalA.TabIndex = 2;
            // 
            // txtvalEx
            // 
            txtvalEx.Location = new Point(290, 138);
            txtvalEx.Name = "txtvalEx";
            txtvalEx.Size = new Size(100, 23);
            txtvalEx.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 197);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "%ERROR:";
            // 
            // lblporerror1
            // 
            lblporerror1.AutoSize = true;
            lblporerror1.Location = new Point(220, 197);
            lblporerror1.Name = "lblporerror1";
            lblporerror1.Size = new Size(0, 15);
            lblporerror1.TabIndex = 6;
            // 
            // Btnlimpiar
            // 
            Btnlimpiar.Location = new Point(449, 141);
            Btnlimpiar.Name = "Btnlimpiar";
            Btnlimpiar.Size = new Size(104, 34);
            Btnlimpiar.TabIndex = 7;
            Btnlimpiar.Text = "Limpiar";
            Btnlimpiar.UseVisualStyleBackColor = true;
            Btnlimpiar.Click += Btnlimpiar_Click;
            // 
            // Btnpor
            // 
            Btnpor.BackColor = Color.White;
            Btnpor.BackgroundColor = Color.White;
            Btnpor.BorderColor = Color.Cyan;
            Btnpor.BorderRadius = 10;
            Btnpor.BorderSize = 2;
            Btnpor.FlatAppearance.BorderSize = 0;
            Btnpor.FlatStyle = FlatStyle.Flat;
            Btnpor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Btnpor.ForeColor = Color.Black;
            Btnpor.Location = new Point(442, 87);
            Btnpor.Name = "Btnpor";
            Btnpor.Size = new Size(111, 36);
            Btnpor.TabIndex = 8;
            Btnpor.Text = "Calcular";
            Btnpor.TextColor = Color.Black;
            Btnpor.UseVisualStyleBackColor = false;
            Btnpor.Click += Btnpor_Click_1;
            // 
            // Error
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btnpor);
            Controls.Add(Btnlimpiar);
            Controls.Add(lblporerror1);
            Controls.Add(label3);
            Controls.Add(txtvalEx);
            Controls.Add(txtvalA);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Error";
            Text = "Error";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtvalA;
        private TextBox txtvalEx;
        private Label label3;
        private Label lblporerror1;
        private Button Btnlimpiar;
        private RJButton.RJButton Btnpor;
    }
}