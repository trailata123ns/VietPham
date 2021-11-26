namespace QLCuaHangBanSach
{
    partial class FrmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass1 = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.BtnDangKy = new System.Windows.Forms.Button();
            this.txtuser1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(191, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng nhập";
            // 
            // txtpass1
            // 
            this.txtpass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtpass1.ForeColor = System.Drawing.Color.Silver;
            this.txtpass1.Location = new System.Drawing.Point(187, 154);
            this.txtpass1.Multiline = true;
            this.txtpass1.Name = "txtpass1";
            this.txtpass1.Size = new System.Drawing.Size(300, 35);
            this.txtpass1.TabIndex = 3;
            this.txtpass1.Text = "Password";
            this.txtpass1.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass1.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Button_Background;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.Location = new System.Drawing.Point(247, 204);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(113, 41);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // BtnDangKy
            // 
            this.BtnDangKy.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Button_Background;
            this.BtnDangKy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnDangKy.Location = new System.Drawing.Point(387, 204);
            this.BtnDangKy.Name = "BtnDangKy";
            this.BtnDangKy.Size = new System.Drawing.Size(100, 41);
            this.BtnDangKy.TabIndex = 5;
            this.BtnDangKy.Text = "Đăng kí";
            this.BtnDangKy.UseVisualStyleBackColor = true;
            this.BtnDangKy.Click += new System.EventHandler(this.BtnDangKy_Click);
            // 
            // txtuser1
            // 
            this.txtuser1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtuser1.ForeColor = System.Drawing.Color.Silver;
            this.txtuser1.Location = new System.Drawing.Point(187, 111);
            this.txtuser1.Multiline = true;
            this.txtuser1.Name = "txtuser1";
            this.txtuser1.Size = new System.Drawing.Size(300, 35);
            this.txtuser1.TabIndex = 2;
            this.txtuser1.Text = "Username";
            this.txtuser1.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser1.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::QLCuaHangBanSach.Properties.Resources.User;
            this.pictureBox2.Location = new System.Drawing.Point(452, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::QLCuaHangBanSach.Properties.Resources.Pass;
            this.pictureBox3.Location = new System.Drawing.Point(452, 154);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::QLCuaHangBanSach.Properties.Resources.avartar1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::QLCuaHangBanSach.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(510, 270);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnDangKy);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtuser1);
            this.Controls.Add(this.txtpass1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button BtnDangKy;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtuser1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

