namespace QuanLyQuanCF
{
    partial class fEditrPeparationRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditrPeparationRecipe));
            lsIngredient = new ListView();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            btnAdd = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            btnDelete = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // lsIngredient
            // 
            lsIngredient.Activation = ItemActivation.OneClick;
            lsIngredient.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsIngredient.FullRowSelect = true;
            lsIngredient.HoverSelection = true;
            lsIngredient.Location = new Point(12, 82);
            lsIngredient.Name = "lsIngredient";
            lsIngredient.Size = new Size(628, 356);
            lsIngredient.TabIndex = 1;
            lsIngredient.UseCompatibleStateImageBehavior = false;
            lsIngredient.View = View.Details;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1009, 79);
            label1.TabIndex = 2;
            label1.Text = "Chỉnh Sửa Công Thức Chuẩn Bị";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(646, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 371);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 310);
            panel2.Name = "panel2";
            panel2.Size = new Size(363, 61);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 103);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 103);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 10, 0, 10);
            panel4.Size = new Size(363, 50);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 153);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 10, 0, 10);
            panel5.Size = new Size(363, 50);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 203);
            panel6.Name = "panel6";
            panel6.Size = new Size(363, 47);
            panel6.TabIndex = 5;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 10);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 1;
            label3.Text = "Nguyên Liệu:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 10);
            label4.Name = "label4";
            label4.Size = new Size(120, 30);
            label4.TabIndex = 1;
            label4.Text = "Số Lượng:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Left;
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(120, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 30);
            textBox2.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Left;
            btnAdd.Location = new Point(0, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 60);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(90, 250);
            button2.Name = "button2";
            button2.Size = new Size(90, 60);
            button2.TabIndex = 7;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.Location = new Point(273, 250);
            button3.Name = "button3";
            button3.Size = new Size(90, 60);
            button3.TabIndex = 8;
            button3.Text = "Lưu Lại";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(120, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 28);
            comboBox1.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Right;
            btnDelete.Location = new Point(183, 250);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 60);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // fEditrPeparationRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lsIngredient);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fEditrPeparationRecipe";
            Text = "Chỉnh Sửa Công Thức Chuẩn Bị";
            WindowState = FormWindowState.Minimized;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView lsIngredient;
        private Label label1;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Button button3;
        private Button button2;
        private Button btnAdd;
        private Button btnDelete;
        private ComboBox comboBox1;
    }
}