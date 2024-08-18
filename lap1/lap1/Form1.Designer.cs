namespace lap1
{
    partial class frmlap1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlap1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblUseName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblĐăngNhậpHệThốngNhânViên = new System.Windows.Forms.Label();
            this.lblLưuthôngtinđăngnhập = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(366, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblUseName
            // 
            this.lblUseName.AutoSize = true;
            this.lblUseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseName.Location = new System.Drawing.Point(156, 56);
            this.lblUseName.Name = "lblUseName";
            this.lblUseName.Size = new System.Drawing.Size(80, 16);
            this.lblUseName.TabIndex = 4;
            this.lblUseName.Text = "UseName:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(156, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 16);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // lblĐăngNhậpHệThốngNhânViên
            // 
            this.lblĐăngNhậpHệThốngNhânViên.AutoSize = true;
            this.lblĐăngNhậpHệThốngNhânViên.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblĐăngNhậpHệThốngNhânViên.ForeColor = System.Drawing.Color.Red;
            this.lblĐăngNhậpHệThốngNhânViên.Location = new System.Drawing.Point(53, 9);
            this.lblĐăngNhậpHệThốngNhânViên.Name = "lblĐăngNhậpHệThốngNhânViên";
            this.lblĐăngNhậpHệThốngNhânViên.Size = new System.Drawing.Size(494, 29);
            this.lblĐăngNhậpHệThốngNhânViên.TabIndex = 6;
            this.lblĐăngNhậpHệThốngNhânViên.Text = "Đăng Nhập Hệ Thống Quản Lý Nhân Viên";
            // 
            // lblLưuthôngtinđăngnhập
            // 
            this.lblLưuthôngtinđăngnhập.AutoSize = true;
            this.lblLưuthôngtinđăngnhập.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLưuthôngtinđăngnhập.Location = new System.Drawing.Point(268, 137);
            this.lblLưuthôngtinđăngnhập.Name = "lblLưuthôngtinđăngnhập";
            this.lblLưuthôngtinđăngnhập.Size = new System.Drawing.Size(140, 15);
            this.lblLưuthôngtinđăngnhập.TabIndex = 7;
            this.lblLưuthôngtinđăngnhập.Text = "Lưu thông tin đăng nhập";
            this.lblLưuthôngtinđăngnhập.Click += new System.EventHandler(this.lblLưuthôngtinđăngnhập_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(20, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "z5296013350668_59563e406596cfb117a3c7fb712e843b.jpg");
            this.imageList1.Images.SetKeyName(1, "avatar.png");
            // 
            // btn1
            // 
            this.btn1.ImageIndex = 1;
            this.btn1.ImageList = this.imageList1;
            this.btn1.Location = new System.Drawing.Point(27, 50);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(123, 102);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "button3";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // frmlap1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(625, 235);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblLưuthôngtinđăngnhập);
            this.Controls.Add(this.lblĐăngNhậpHệThốngNhânViên);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUseName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmlap1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lap1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblUseName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblĐăngNhậpHệThốngNhânViên;
        private System.Windows.Forms.Label lblLưuthôngtinđăngnhập;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn1;
    }
}

