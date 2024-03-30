namespace ATM
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            sifre = new TextBox();
            error_message = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 72);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(712, 46);
            label3.Name = "label3";
            label3.Size = new Size(123, 13);
            label3.TabIndex = 5;
            label3.Text = "Texniki dəstək mərkəzi";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(686, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(717, 12);
            label4.Name = "label4";
            label4.Size = new Size(124, 35);
            label4.TabIndex = 3;
            label4.Text = "(012) 000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(127, 43);
            label2.Name = "label2";
            label2.Size = new Size(68, 13);
            label2.TabIndex = 2;
            label2.Text = "Birinci Bank";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 47);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(72, 12);
            label1.Name = "label1";
            label1.Size = new Size(124, 35);
            label1.TabIndex = 0;
            label1.Text = "Red Bank";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(334, 106);
            label5.Name = "label5";
            label5.Size = new Size(190, 35);
            label5.TabIndex = 1;
            label5.Text = "Xoş gəlmişsiniz";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(305, 156);
            label6.Name = "label6";
            label6.Size = new Size(260, 40);
            label6.TabIndex = 2;
            label6.Text = "Hörmətli müştəri,";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(266, 196);
            label7.Name = "label7";
            label7.Size = new Size(344, 30);
            label7.TabIndex = 3;
            label7.Text = "Xahiş edirik, PİN şifrənizi daxil edin";
            // 
            // sifre
            // 
            sifre.BackColor = Color.FromArgb(192, 0, 0);
            sifre.BorderStyle = BorderStyle.None;
            sifre.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sifre.ForeColor = SystemColors.Window;
            sifre.Location = new Point(347, 284);
            sifre.MaxLength = 4;
            sifre.Name = "sifre";
            sifre.PasswordChar = 'O';
            sifre.PlaceholderText = "O O O O";
            sifre.Size = new Size(160, 54);
            sifre.TabIndex = 4;
            sifre.TextAlign = HorizontalAlignment.Center;
            // 
            // error_message
            // 
            error_message.AutoSize = true;
            error_message.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            error_message.ForeColor = Color.White;
            error_message.Location = new Point(325, 238);
            error_message.Name = "error_message";
            error_message.Size = new Size(205, 30);
            error_message.TabIndex = 5;
            error_message.Text = "PİN şifrəniz yalnışdır";
            error_message.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(360, 383);
            button1.Name = "button1";
            button1.Size = new Size(132, 40);
            button1.TabIndex = 6;
            button1.Text = "Daxil olun";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(853, 452);
            Controls.Add(button1);
            Controls.Add(error_message);
            Controls.Add(sifre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Giris";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox sifre;
        private Label error_message;
        private Button button1;
    }
}
