namespace PRL
{
    partial class QuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMK));
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            panel3 = new Panel();
            textBox3 = new TextBox();
            pictureBox4 = new PictureBox();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(304, 449);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.ForeColor = Color.FromArgb(0, 117, 214);
            panel2.Location = new Point(36, 304);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 1);
            panel2.TabIndex = 52;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 117, 214);
            textBox1.Location = new Point(36, 277);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 51;
            textBox1.Tag = "";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 117, 214);
            panel3.ForeColor = Color.FromArgb(0, 117, 214);
            panel3.Location = new Point(36, 247);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 1);
            panel3.TabIndex = 50;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(0, 117, 214);
            textBox3.Location = new Point(66, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 21);
            textBox3.TabIndex = 49;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(36, 214);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 48;
            pictureBox4.TabStop = false;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.FromArgb(0, 117, 214);
            linkLabel3.Location = new Point(39, 414);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(85, 20);
            linkLabel3.TabIndex = 47;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Đăng Nhập";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.FromArgb(0, 117, 214);
            linkLabel2.Location = new Point(206, 414);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(64, 20);
            linkLabel2.TabIndex = 46;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Đăng Ký";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 214);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(36, 350);
            button1.Name = "button1";
            button1.Size = new Size(231, 37);
            button1.TabIndex = 45;
            button1.Text = "Lấy Lại Mật Khẩu";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Barlow Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(62, 219, 255);
            label1.Location = new Point(34, 136);
            label1.Name = "label1";
            label1.Size = new Size(236, 54);
            label1.TabIndex = 44;
            label1.Text = "Quên Mật Khẩu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // QuenMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(308, 486);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuenMK";
            Text = "QuenMK";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Panel panel3;
        private TextBox textBox3;
        private PictureBox pictureBox4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}