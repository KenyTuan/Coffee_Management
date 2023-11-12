namespace QuanLyQuanCF
{
    partial class fResestPass1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 24);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "QUÊN MẬT KHẨU";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 78);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập Mã nhân viên  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 132);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 2;
            label3.Text = "Nhập mật khẩu mới :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 186);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 3;
            label4.Text = "Nhập lại mật khẩu mới :";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(230, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(251, 27);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(387, 237);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            // 
            // fResestPass1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 308);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fResestPass1";
            Text = "fResestPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}