namespace QuanLyQuanCF
{
    partial class fLogin
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnClose = new Button();
            btnLogin = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 232);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 116);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 69);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(113, 63);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(364, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(113, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(364, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(303, 167);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(158, 167);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(223, 12);
            label1.Name = "label1";
            label1.Size = new Size(80, 33);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 254);
            Controls.Add(panel1);
            Name = "fLogin";
            Text = "Form1";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnClose;
        private Button btnLogin;
        private Label label1;
    }
}