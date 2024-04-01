namespace WinForms_Calculator_with_number
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_C = new Button();
            btn_twicezero = new Button();
            btn_bolme = new Button();
            btn_vurma = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_toplama = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_cixma = new Button();
            btn_1 = new Button();
            btn_beraber = new Button();
            btn_noqte = new Button();
            btn_zero = new Button();
            btn2 = new Button();
            btn3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 50);
            label1.Name = "label1";
            label1.Size = new Size(334, 54);
            label1.TabIndex = 0;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // btn_C
            // 
            btn_C.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_C.Location = new Point(19, 143);
            btn_C.Name = "btn_C";
            btn_C.Size = new Size(158, 66);
            btn_C.TabIndex = 1;
            btn_C.Text = "C";
            btn_C.UseVisualStyleBackColor = true;
            btn_C.Click += btn_C_Click;
            // 
            // btn_twicezero
            // 
            btn_twicezero.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_twicezero.Location = new Point(193, 143);
            btn_twicezero.Name = "btn_twicezero";
            btn_twicezero.Size = new Size(72, 66);
            btn_twicezero.TabIndex = 3;
            btn_twicezero.Text = "00";
            btn_twicezero.UseVisualStyleBackColor = true;
            btn_twicezero.Click += btn_twicezero_Click;
            // 
            // btn_bolme
            // 
            btn_bolme.BackColor = Color.FromArgb(255, 128, 0);
            btn_bolme.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_bolme.ForeColor = Color.White;
            btn_bolme.Location = new Point(281, 143);
            btn_bolme.Name = "btn_bolme";
            btn_bolme.Size = new Size(72, 66);
            btn_bolme.TabIndex = 4;
            btn_bolme.Text = "/";
            btn_bolme.UseVisualStyleBackColor = false;
            btn_bolme.Click += btn_bolme_Click;
            // 
            // btn_vurma
            // 
            btn_vurma.BackColor = Color.FromArgb(255, 128, 0);
            btn_vurma.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_vurma.ForeColor = Color.White;
            btn_vurma.Location = new Point(280, 222);
            btn_vurma.Name = "btn_vurma";
            btn_vurma.Size = new Size(72, 66);
            btn_vurma.TabIndex = 8;
            btn_vurma.Text = "*";
            btn_vurma.UseVisualStyleBackColor = false;
            btn_vurma.Click += btn_vurma_Click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_9.Location = new Point(193, 222);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(72, 66);
            btn_9.TabIndex = 7;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_8.Location = new Point(106, 222);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(72, 66);
            btn_8.TabIndex = 6;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_7.Location = new Point(19, 222);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(72, 66);
            btn_7.TabIndex = 5;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_toplama
            // 
            btn_toplama.BackColor = Color.FromArgb(255, 128, 0);
            btn_toplama.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_toplama.ForeColor = Color.White;
            btn_toplama.Location = new Point(281, 301);
            btn_toplama.Name = "btn_toplama";
            btn_toplama.Size = new Size(72, 66);
            btn_toplama.TabIndex = 12;
            btn_toplama.Text = "+";
            btn_toplama.UseVisualStyleBackColor = false;
            btn_toplama.Click += btn_toplama_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_6.Location = new Point(193, 301);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(72, 66);
            btn_6.TabIndex = 11;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_5.Location = new Point(106, 301);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(72, 66);
            btn_5.TabIndex = 10;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_4.Location = new Point(19, 301);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(72, 66);
            btn_4.TabIndex = 9;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_cixma
            // 
            btn_cixma.BackColor = Color.FromArgb(255, 128, 0);
            btn_cixma.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_cixma.ForeColor = Color.White;
            btn_cixma.Location = new Point(280, 380);
            btn_cixma.Name = "btn_cixma";
            btn_cixma.Size = new Size(72, 66);
            btn_cixma.TabIndex = 16;
            btn_cixma.Text = "-";
            btn_cixma.UseVisualStyleBackColor = false;
            btn_cixma.Click += btn_cixma_Click;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_1.Location = new Point(19, 380);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(72, 66);
            btn_1.TabIndex = 13;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_beraber
            // 
            btn_beraber.BackColor = Color.FromArgb(255, 128, 0);
            btn_beraber.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_beraber.ForeColor = Color.White;
            btn_beraber.Location = new Point(281, 474);
            btn_beraber.Name = "btn_beraber";
            btn_beraber.Size = new Size(72, 66);
            btn_beraber.TabIndex = 20;
            btn_beraber.Text = "=";
            btn_beraber.UseVisualStyleBackColor = false;
            btn_beraber.Click += btn_beraber_Click;
            // 
            // btn_noqte
            // 
            btn_noqte.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_noqte.Location = new Point(193, 474);
            btn_noqte.Name = "btn_noqte";
            btn_noqte.Size = new Size(72, 66);
            btn_noqte.TabIndex = 19;
            btn_noqte.Text = ".";
            btn_noqte.UseVisualStyleBackColor = true;
            btn_noqte.Click += btn_noqte_Click;
            // 
            // btn_zero
            // 
            btn_zero.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn_zero.Location = new Point(19, 474);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(158, 67);
            btn_zero.TabIndex = 17;
            btn_zero.Text = "0";
            btn_zero.UseVisualStyleBackColor = true;
            btn_zero.Click += btn_zero_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn2.Location = new Point(106, 380);
            btn2.Name = "btn2";
            btn2.Size = new Size(72, 66);
            btn2.TabIndex = 21;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            btn3.Location = new Point(193, 380);
            btn3.Name = "btn3";
            btn3.Size = new Size(72, 66);
            btn3.TabIndex = 22;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(376, 562);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn_beraber);
            Controls.Add(btn_noqte);
            Controls.Add(btn_zero);
            Controls.Add(btn_cixma);
            Controls.Add(btn_1);
            Controls.Add(btn_toplama);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_vurma);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_bolme);
            Controls.Add(btn_twicezero);
            Controls.Add(btn_C);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_C;
        private Button button2;
        private Button btn_twicezero;
        private Button btn_bolme;
        private Button btn_vurma;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_toplama;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_cixma;
        private Button button14;
        private Button button15;
        private Button btn_1;
        private Button btn_beraber;
        private Button btn_noqte;
        private Button button19;
        private Button btn_zero;
        private Button btn2;
        private Button btn3;
    }
}
