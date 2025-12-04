namespace GaraOtoApp
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnQuanLyNguoiDung;
        private System.Windows.Forms.Button btnQuanLyXe;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnPhieuSuaChua;
        private System.Windows.Forms.Button btnLichHen;
        private System.Windows.Forms.Button btnHoaDon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblUser = new System.Windows.Forms.Label();
            this.btnQuanLyNguoiDung = new System.Windows.Forms.Button();
            this.btnQuanLyXe = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnPhieuSuaChua = new System.Windows.Forms.Button();
            this.btnLichHen = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUser.Location = new System.Drawing.Point(20, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 25);
            this.lblUser.TabIndex = 0;
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // btnQuanLyNguoiDung
            // 
            this.btnQuanLyNguoiDung.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnQuanLyNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQuanLyNguoiDung.Location = new System.Drawing.Point(43, 60);
            this.btnQuanLyNguoiDung.Name = "btnQuanLyNguoiDung";
            this.btnQuanLyNguoiDung.Size = new System.Drawing.Size(200, 40);
            this.btnQuanLyNguoiDung.TabIndex = 1;
            this.btnQuanLyNguoiDung.Text = "Quản lý người dùng";
            this.btnQuanLyNguoiDung.UseVisualStyleBackColor = false;
            this.btnQuanLyNguoiDung.Click += new System.EventHandler(this.btnQuanLyNguoiDung_Click);
            // 
            // btnQuanLyXe
            // 
            this.btnQuanLyXe.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnQuanLyXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQuanLyXe.Location = new System.Drawing.Point(43, 119);
            this.btnQuanLyXe.Name = "btnQuanLyXe";
            this.btnQuanLyXe.Size = new System.Drawing.Size(200, 40);
            this.btnQuanLyXe.TabIndex = 2;
            this.btnQuanLyXe.Text = "Quản lý xe";
            this.btnQuanLyXe.UseVisualStyleBackColor = false;
            this.btnQuanLyXe.Click += new System.EventHandler(this.btnQuanLyXe_Click);
            // 
            // btnKho
            // 
            this.btnKho.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnKho.Location = new System.Drawing.Point(43, 181);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(200, 47);
            this.btnKho.TabIndex = 3;
            this.btnKho.Text = "Quản lý kho/phụ tùng";
            this.btnKho.UseVisualStyleBackColor = false;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnPhieuSuaChua
            // 
            this.btnPhieuSuaChua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPhieuSuaChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPhieuSuaChua.Location = new System.Drawing.Point(43, 256);
            this.btnPhieuSuaChua.Name = "btnPhieuSuaChua";
            this.btnPhieuSuaChua.Size = new System.Drawing.Size(200, 40);
            this.btnPhieuSuaChua.TabIndex = 4;
            this.btnPhieuSuaChua.Text = "Phiếu sửa chữa";
            this.btnPhieuSuaChua.UseVisualStyleBackColor = false;
            this.btnPhieuSuaChua.Click += new System.EventHandler(this.btnPhieuSuaChua_Click);
            // 
            // btnLichHen
            // 
            this.btnLichHen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLichHen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLichHen.Location = new System.Drawing.Point(43, 319);
            this.btnLichHen.Name = "btnLichHen";
            this.btnLichHen.Size = new System.Drawing.Size(200, 40);
            this.btnLichHen.TabIndex = 5;
            this.btnLichHen.Text = "Lịch hẹn";
            this.btnLichHen.UseVisualStyleBackColor = false;
            this.btnLichHen.Click += new System.EventHandler(this.btnLichHen_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHoaDon.Location = new System.Drawing.Point(43, 397);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(200, 40);
            this.btnHoaDon.TabIndex = 6;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(453, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(278, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(682, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(293, 191);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 522);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnQuanLyNguoiDung);
            this.Controls.Add(this.btnQuanLyXe);
            this.Controls.Add(this.btnKho);
            this.Controls.Add(this.btnPhieuSuaChua);
            this.Controls.Add(this.btnLichHen);
            this.Controls.Add(this.btnHoaDon);
            this.ForeColor = System.Drawing.Color.GhostWhite;
            this.Name = "FormMain";
            this.Text = "Gara Ô tô - Quản lý";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
