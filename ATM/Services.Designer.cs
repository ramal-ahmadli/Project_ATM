namespace ATM
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            btn_sifrenideyis = new Button();
            btn_hesabiartir = new Button();
            btn_imt = new Button();
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
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 72);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(690, 46);
            label3.Name = "label3";
            label3.Size = new Size(123, 13);
            label3.TabIndex = 5;
            label3.Text = "Texniki dəstək mərkəzi";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(664, 16);
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
            label4.Location = new Point(695, 12);
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
            label2.Location = new Point(153, 43);
            label2.Name = "label2";
            label2.Size = new Size(68, 13);
            label2.TabIndex = 2;
            label2.Text = "Birinci Bank";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 47);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(98, 12);
            label1.Name = "label1";
            label1.Size = new Size(124, 35);
            label1.TabIndex = 0;
            label1.Text = "Red Bank";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(250, 108);
            label6.Name = "label6";
            label6.Size = new Size(366, 40);
            label6.TabIndex = 11;
            label6.Text = "Xahiş edirik, xidmət seçin";
            // 
            // btn_sifrenideyis
            // 
            btn_sifrenideyis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sifrenideyis.ForeColor = Color.DarkRed;
            btn_sifrenideyis.Location = new Point(38, 199);
            btn_sifrenideyis.Name = "btn_sifrenideyis";
            btn_sifrenideyis.Size = new Size(253, 52);
            btn_sifrenideyis.TabIndex = 14;
            btn_sifrenideyis.Text = "Şifrəni dəyişdirmək";
            btn_sifrenideyis.TextAlign = ContentAlignment.MiddleLeft;
            btn_sifrenideyis.UseVisualStyleBackColor = true;
            btn_sifrenideyis.Click += btn_sifrenideyis_Click;
            // 
            // btn_hesabiartir
            // 
            btn_hesabiartir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_hesabiartir.ForeColor = Color.DarkRed;
            btn_hesabiartir.Location = new Point(38, 284);
            btn_hesabiartir.Name = "btn_hesabiartir";
            btn_hesabiartir.Size = new Size(253, 52);
            btn_hesabiartir.TabIndex = 15;
            btn_hesabiartir.Text = "Hesabı artırmaq";
            btn_hesabiartir.TextAlign = ContentAlignment.MiddleLeft;
            btn_hesabiartir.UseVisualStyleBackColor = true;
            // 
            // btn_imt
            // 
            btn_imt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_imt.ForeColor = Color.DarkRed;
            btn_imt.Location = new Point(560, 199);
            btn_imt.Name = "btn_imt";
            btn_imt.Size = new Size(253, 52);
            btn_imt.TabIndex = 16;
            btn_imt.Text = "İmtina etmək";
            btn_imt.TextAlign = ContentAlignment.MiddleRight;
            btn_imt.UseVisualStyleBackColor = true;
            btn_imt.Click += btn_imt_Click;
            // 
            // Services
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(853, 452);
            Controls.Add(btn_imt);
            Controls.Add(btn_hesabiartir);
            Controls.Add(btn_sifrenideyis);
            Controls.Add(panel1);
            Controls.Add(label6);
            Name = "Services";
            Text = "Services";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label6;
        private Button btn_sifrenideyis;
        private Button btn_hesabiartir;
        private Button btn_imt;
    }
}