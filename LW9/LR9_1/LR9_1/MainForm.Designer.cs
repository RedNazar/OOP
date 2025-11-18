namespace LR9_1
{
    partial class MainForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton4 = new System.Windows.Forms.RadioButton();
            radioButton5 = new System.Windows.Forms.RadioButton();
            button2 = new System.Windows.Forms.Button();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            button3 = new System.Windows.Forms.Button();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            button4 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            radioButton7 = new System.Windows.Forms.RadioButton();
            radioButton6 = new System.Windows.Forms.RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(479, 27);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(130, 69);
            button1.TabIndex = 0;
            button1.Text = "Колір";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(519, 118);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Симетрія";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(491, 159);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(107, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "горизонтальна";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(491, 204);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(94, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "вертикальна";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(491, 247);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(59, 19);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "дві осі";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new System.Drawing.Point(491, 288);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(89, 19);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = "центральна";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new System.Drawing.Point(491, 328);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new System.Drawing.Size(92, 19);
            radioButton5.TabIndex = 6;
            radioButton5.TabStop = true;
            radioButton5.Text = "без симетрії";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(31, 454);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(139, 74);
            button2.TabIndex = 7;
            button2.Text = "Очистити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(214, 454);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Зберегти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(214, 499);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "Друк";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Location = new System.Drawing.Point(479, 403);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(145, 125);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Режим заливки";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new System.Drawing.Point(6, 75);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new System.Drawing.Size(81, 19);
            radioButton7.TabIndex = 1;
            radioButton7.TabStop = true;
            radioButton7.Text = "Вимкнено";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new System.Drawing.Point(6, 34);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new System.Drawing.Size(83, 19);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "Ввімкнено";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(684, 562);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Text = "RudyiNazarPI-232Polotno";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button button2;
        private ColorDialog colorDialog1;
        private System.Windows.Forms.Button button3;
        private SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
    }
}
