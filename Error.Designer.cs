﻿namespace física_EH
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
            BtnLimpiar = new RJButton.RJButton();
            BtnCalcular = new RJButton.RJButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(37, 22);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite el valor aceptado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(16, 73);
            label2.Name = "label2";
            label2.Size = new Size(166, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite el valor experimental:";
            // 
            // txtvalA
            // 
            txtvalA.BorderStyle = BorderStyle.FixedSingle;
            txtvalA.Location = new Point(185, 19);
            txtvalA.Name = "txtvalA";
            txtvalA.Size = new Size(100, 23);
            txtvalA.TabIndex = 2;
            // 
            // txtvalEx
            // 
            txtvalEx.BorderStyle = BorderStyle.FixedSingle;
            txtvalEx.Location = new Point(188, 70);
            txtvalEx.Name = "txtvalEx";
            txtvalEx.Size = new Size(100, 23);
            txtvalEx.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(70, 103);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "%ERROR:";
            // 
            // lblporerror1
            // 
            lblporerror1.AutoSize = true;
            lblporerror1.ForeColor = SystemColors.ControlLight;
            lblporerror1.Location = new Point(134, 103);
            lblporerror1.Name = "lblporerror1";
            lblporerror1.Size = new Size(0, 15);
            lblporerror1.TabIndex = 6;
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
            BtnLimpiar.Location = new Point(171, 140);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(142, 35);
            BtnLimpiar.TabIndex = 23;
            BtnLimpiar.Text = "\U0001f9f9  LIMPIAR";
            BtnLimpiar.TextColor = Color.White;
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click_1;
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.FromArgb(54, 57, 62);
            BtnCalcular.BackgroundColor = Color.FromArgb(54, 57, 62);
            BtnCalcular.BorderColor = Color.White;
            BtnCalcular.BorderRadius = 1;
            BtnCalcular.BorderSize = 1;
            BtnCalcular.FlatAppearance.BorderSize = 0;
            BtnCalcular.FlatStyle = FlatStyle.Flat;
            BtnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcular.ForeColor = SystemColors.ControlLight;
            BtnCalcular.Location = new Point(37, 140);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(126, 36);
            BtnCalcular.TabIndex = 20;
            BtnCalcular.Text = "📅 CALCULAR";
            BtnCalcular.TextColor = SystemColors.ControlLight;
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // Error
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(432, 214);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnCalcular);
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
        private RJButton.RJButton BtnLimpiar;
        private RJButton.RJButton BtnCalcular;
    }
}