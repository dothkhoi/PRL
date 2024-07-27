namespace PRL
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            panel1 = new Panel();
            DangKy = new LinkLabel();
            linkLabel2 = new LinkLabel();
            QuenMK = new LinkLabel();
            button1 = new Button();
            panel2 = new Panel();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(DangKy);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(QuenMK);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(306, 461);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // DangKy
            // 
            DangKy.AutoSize = true;
            DangKy.LinkColor = Color.FromArgb(0, 117, 214);
            DangKy.Location = new Point(38, 426);
            DangKy.Name = "DangKy";
            DangKy.Size = new Size(64, 20);
            DangKy.TabIndex = 23;
            DangKy.TabStop = true;
            DangKy.Text = "Đăng Ký";
            DangKy.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.FromArgb(0, 117, 214);
            linkLabel2.Location = new Point(222, 426);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(47, 20);
            linkLabel2.TabIndex = 22;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Thoát";
            // 
            // QuenMK
            // 
            QuenMK.AutoSize = true;
            QuenMK.LinkColor = Color.FromArgb(0, 117, 214);
            QuenMK.Location = new Point(158, 313);
            QuenMK.Name = "QuenMK";
            QuenMK.Size = new Size(111, 20);
            QuenMK.TabIndex = 21;
            QuenMK.TabStop = true;
            QuenMK.Text = "Quên Mật Khẩu";
            QuenMK.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 214);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(35, 355);
            button1.Name = "button1";
            button1.Size = new Size(231, 37);
            button1.TabIndex = 20;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.ForeColor = Color.FromArgb(0, 117, 214);
            panel2.Location = new Point(35, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 1);
            panel2.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(0, 117, 214);
            textBox2.Location = new Point(65, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 21);
            textBox2.TabIndex = 18;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(35, 261);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 117, 214);
            panel3.ForeColor = Color.FromArgb(0, 117, 214);
            panel3.Location = new Point(35, 222);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 1);
            panel3.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Barlow Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(62, 219, 255);
            label1.Location = new Point(76, 125);
            label1.Name = "label1";
            label1.Size = new Size(153, 54);
            label1.TabIndex = 15;
            label1.Text = "Welcome";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 117, 214);
            textBox1.Location = new Point(65, 189);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 24);
            textBox1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(35, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(308, 486);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel DangKy;
        private LinkLabel linkLabel2;
        private LinkLabel QuenMK;
        private Button button1;
        private Panel panel2;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
