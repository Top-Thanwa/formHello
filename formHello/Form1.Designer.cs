namespace formHello
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            groupBox1 = new GroupBox();
            btnOK = new Button();
            lblResult = new Label();
            label5 = new Label();
            label4 = new Label();
            txtRedius = new TextBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            txtHigh = new TextBox();
            btnOK2 = new Button();
            lblResult2 = new Label();
            label8 = new Label();
            txtLen = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 148);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 43);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(218, 98);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 2;
            label1.Text = "Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 15);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.BackColor = Color.OrangeRed;
            label3.Location = new Point(12, 201);
            label3.Name = "label3";
            label3.Size = new Size(173, 131);
            label3.TabIndex = 4;
            label3.Text = "หลอดไฟ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(12, 345);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "เปิด/ปิด";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnOK);
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtRedius);
            groupBox1.Location = new Point(402, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(590, 265);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณพื้นที่วงกลม";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(370, 47);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 11;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.ControlLight;
            lblResult.Location = new Point(54, 92);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(353, 134);
            lblResult.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 47);
            label5.Name = "label5";
            label5.Size = new Size(41, 25);
            label5.TabIndex = 9;
            label5.Text = "ซ.ม.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 47);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 8;
            label4.Text = "รัศมี";
            // 
            // txtRedius
            // 
            txtRedius.Location = new Point(100, 44);
            txtRedius.Name = "txtRedius";
            txtRedius.Size = new Size(204, 31);
            txtRedius.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Info;
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtHigh);
            groupBox2.Controls.Add(btnOK2);
            groupBox2.Controls.Add(lblResult2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtLen);
            groupBox2.Location = new Point(402, 297);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(590, 265);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวณพื้นที่สามเหลี่ยม";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 38);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 13;
            label7.Text = "ความสูง";
            // 
            // txtHigh
            // 
            txtHigh.Location = new Point(350, 38);
            txtHigh.Name = "txtHigh";
            txtHigh.Size = new Size(101, 31);
            txtHigh.TabIndex = 12;
            // 
            // btnOK2
            // 
            btnOK2.Location = new Point(477, 38);
            btnOK2.Name = "btnOK2";
            btnOK2.Size = new Size(94, 29);
            btnOK2.TabIndex = 11;
            btnOK2.Text = "OK";
            btnOK2.UseVisualStyleBackColor = true;
            btnOK2.Click += btnOK2_Click;
            // 
            // lblResult2
            // 
            lblResult2.BackColor = SystemColors.ControlLight;
            lblResult2.Location = new Point(64, 87);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(353, 134);
            lblResult2.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 38);
            label8.Name = "label8";
            label8.Size = new Size(73, 25);
            label8.TabIndex = 8;
            label8.Text = "ความยาว";
            // 
            // txtLen
            // 
            txtLen.Location = new Point(128, 38);
            txtLen.Name = "txtLen";
            txtLen.Size = new Size(100, 31);
            txtLen.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 574);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Hello";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private GroupBox groupBox1;
        private Button btnOK;
        private Label lblResult;
        private Label label5;
        private Label label4;
        private TextBox txtRedius;
        private GroupBox groupBox2;
        private TextBox txtHigh;
        private Button btnOK2;
        private Label lblResult2;
        private Label label8;
        private TextBox txtLen;
        private Label label7;
    }
}
