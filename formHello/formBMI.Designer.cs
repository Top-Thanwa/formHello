namespace formHello
{
    partial class formBMI
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
            groupBox2 = new GroupBox();
            label2 = new Label();
            label7 = new Label();
            txtHeight = new TextBox();
            btnOK = new Button();
            lblResult = new Label();
            label8 = new Label();
            txtWeight = new TextBox();
            lblResult1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Controls.Add(btnOK);
            groupBox2.Controls.Add(lblResult);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtWeight);
            groupBox2.Location = new Point(127, 13);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(738, 267);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวณค่า BMI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 173);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 14;
            label2.Text = "ค่า BMI ของคุณคือ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 115);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 13;
            label7.Text = "กรอกส่วนสูง :";
            // 
            // txtHeight
            // 
            txtHeight.BorderStyle = BorderStyle.FixedSingle;
            txtHeight.Location = new Point(228, 115);
            txtHeight.Margin = new Padding(4);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(157, 31);
            txtHeight.TabIndex = 12;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(433, 84);
            btnOK.Margin = new Padding(4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(118, 36);
            btnOK.TabIndex = 11;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            btnOK.MouseLeave += btnOK_MouseLeave;
            btnOK.MouseHover += btnOK_MouseHover;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.ButtonHighlight;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(110, 207);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(511, 42);
            lblResult.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(110, 63);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 25);
            label8.TabIndex = 8;
            label8.Text = "กรอกน้ำหนัก :";
            // 
            // txtWeight
            // 
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Location = new Point(228, 63);
            txtWeight.Margin = new Padding(4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(157, 31);
            txtWeight.TabIndex = 7;
            // 
            // lblResult1
            // 
            lblResult1.BackColor = SystemColors.ButtonHighlight;
            lblResult1.BorderStyle = BorderStyle.FixedSingle;
            lblResult1.Location = new Point(27, 51);
            lblResult1.Margin = new Padding(4, 0, 4, 0);
            lblResult1.Name = "lblResult1";
            lblResult1.Size = new Size(683, 174);
            lblResult1.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(lblResult1);
            groupBox1.Location = new Point(127, 287);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 249);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "ผลทดสอบ";
            // 
            // formBMI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "formBMI";
            Text = "formBMI";
            Load += formBMI_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label7;
        private TextBox txtHeight;
        private Button btnOK;
        private Label lblResult;
        private Label label8;
        private TextBox txtWeight;
        private Label lblResult1;
        private Label label2;
        private GroupBox groupBox1;
    }
}