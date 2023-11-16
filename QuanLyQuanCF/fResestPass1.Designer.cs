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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fResestPass1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtNewPass = new TextBox();
            txtPassConfirm = new TextBox();
            button1 = new Button();
            btnClose = new Button();
            toolTip1 = new ToolTip(components);
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
            // txtID
            // 
            txtID.Location = new Point(230, 74);
            txtID.Name = "txtID";
            txtID.Size = new Size(251, 27);
            txtID.TabIndex = 4;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(230, 131);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(251, 27);
            txtNewPass.TabIndex = 5;
            // 
            // txtPassConfirm
            // 
            txtPassConfirm.Location = new Point(230, 186);
            txtPassConfirm.Name = "txtPassConfirm";
            txtPassConfirm.Size = new Size(251, 27);
            txtPassConfirm.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(155, 252);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(290, 252);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // fResestPass1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 329);
            Controls.Add(btnClose);
            Controls.Add(button1);
            Controls.Add(txtPassConfirm);
            Controls.Add(txtNewPass);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fResestPass1";
            Text = "Đổi Mật Khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtNewPass;
        private TextBox txtPassConfirm;
        private Button button1;
        private Button btnClose;
        private ToolTip toolTip1;
    }
}