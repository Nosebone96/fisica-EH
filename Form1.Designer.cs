namespace física_EH
{
    partial class Matemáticas
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtánguloA = new TextBox();
            TxtánguloB = new TextBox();
            TxtLadoa = new TextBox();
            TxtángulC = new TextBox();
            TxtLadoc = new TextBox();
            TxtLadob = new TextBox();
            BtnCalcular = new RJButton.RJButton();
            BtnLimpiar = new RJButton.RJButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite el ángulo A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(37, 98);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite el ángulo B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(36, 154);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Digite el ángulo C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(365, 142);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Digite el lado C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(364, 92);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 4;
            label5.Text = "Digite el lado B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(363, 38);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 5;
            label6.Text = "Digite el lado A";
            // 
            // TxtánguloA
            // 
            TxtánguloA.Location = new Point(161, 35);
            TxtánguloA.Name = "TxtánguloA";
            TxtánguloA.Size = new Size(102, 23);
            TxtánguloA.TabIndex = 6;
            // 
            // TxtánguloB
            // 
            TxtánguloB.Location = new Point(161, 95);
            TxtánguloB.Name = "TxtánguloB";
            TxtánguloB.Size = new Size(102, 23);
            TxtánguloB.TabIndex = 7;
            // 
            // TxtLadoa
            // 
            TxtLadoa.Location = new Point(489, 38);
            TxtLadoa.Name = "TxtLadoa";
            TxtLadoa.Size = new Size(102, 23);
            TxtLadoa.TabIndex = 8;
            // 
            // TxtángulC
            // 
            TxtángulC.Location = new Point(161, 151);
            TxtángulC.Name = "TxtángulC";
            TxtángulC.Size = new Size(102, 23);
            TxtángulC.TabIndex = 9;
            // 
            // TxtLadoc
            // 
            TxtLadoc.Location = new Point(489, 139);
            TxtLadoc.Name = "TxtLadoc";
            TxtLadoc.Size = new Size(102, 23);
            TxtLadoc.TabIndex = 10;
            // 
            // TxtLadob
            // 
            TxtLadob.Location = new Point(489, 84);
            TxtLadob.Name = "TxtLadob";
            TxtLadob.Size = new Size(102, 23);
            TxtLadob.TabIndex = 11;
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.FromArgb(54, 57, 62);
            BtnCalcular.BackgroundColor = Color.FromArgb(54, 57, 62);
            BtnCalcular.BorderColor = Color.White;
            BtnCalcular.BorderRadius = 1;
            BtnCalcular.BorderSize = 1;
            BtnCalcular.Cursor = Cursors.Hand;
            BtnCalcular.FlatAppearance.BorderSize = 0;
            BtnCalcular.FlatStyle = FlatStyle.Flat;
            BtnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcular.ForeColor = Color.White;
            BtnCalcular.Location = new Point(37, 237);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(121, 36);
            BtnCalcular.TabIndex = 24;
            BtnCalcular.Text = "📅 CALCULAR";
            BtnCalcular.TextColor = Color.White;
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.FromArgb(54, 57, 62);
            BtnLimpiar.BackgroundColor = Color.FromArgb(54, 57, 62);
            BtnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLimpiar.BorderColor = Color.White;
            BtnLimpiar.BorderRadius = 15;
            BtnLimpiar.BorderSize = 1;
            BtnLimpiar.FlatAppearance.BorderSize = 0;
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLimpiar.ForeColor = Color.White;
            BtnLimpiar.Location = new Point(195, 238);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(142, 35);
            BtnLimpiar.TabIndex = 51;
            BtnLimpiar.Text = "\U0001f9f9  LIMPIAR";
            BtnLimpiar.TextColor = Color.White;
            BtnLimpiar.UseMnemonic = false;
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // Matemáticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnCalcular);
            Controls.Add(TxtLadob);
            Controls.Add(TxtLadoc);
            Controls.Add(TxtángulC);
            Controls.Add(TxtLadoa);
            Controls.Add(TxtánguloB);
            Controls.Add(TxtánguloA);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Name = "Matemáticas";
            Text = "Matemáticas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtánguloA;
        private TextBox TxtánguloB;
        private TextBox TxtLadoa;
        private TextBox TxtángulC;
        private TextBox TxtLadoc;
        private TextBox TxtLadob;
        private RJButton.RJButton BtnCalcular;
        private RJButton.RJButton BtnLimpiar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}