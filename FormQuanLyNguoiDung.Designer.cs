namespace GaraOtoApp
{
    partial class FormQuanLyNguoiDung
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewNguoiDung;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.ComboBox comboVaiTro;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;

        private System.Windows.Forms.TextBox txtSearch;     // <--- THÊM
        private System.Windows.Forms.Button btnTimKiem;     // <--- THÊM

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewNguoiDung = new System.Windows.Forms.DataGridView();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.comboVaiTro = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNguoiDung
            // 
            this.dataGridViewNguoiDung.ColumnHeadersHeight = 29;
            this.dataGridViewNguoiDung.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewNguoiDung.Name = "dataGridViewNguoiDung";
            this.dataGridViewNguoiDung.ReadOnly = true;
            this.dataGridViewNguoiDung.RowHeadersWidth = 51;
            this.dataGridViewNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNguoiDung.Size = new System.Drawing.Size(620, 420);
            this.dataGridViewNguoiDung.TabIndex = 0;
            this.dataGridViewNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNguoiDung_CellClick);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtHoTen.Location = new System.Drawing.Point(660, 16);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(240, 40);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDienThoai.Location = new System.Drawing.Point(660, 76);
            this.txtDienThoai.Multiline = true;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(240, 40);
            this.txtDienThoai.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDiaChi.Location = new System.Drawing.Point(660, 136);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(240, 40);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(660, 196);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(240, 40);
            this.txtTenDangNhap.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtMatKhau.Location = new System.Drawing.Point(660, 255);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(240, 40);
            this.txtMatKhau.TabIndex = 5;
            // 
            // comboVaiTro
            // 
            this.comboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboVaiTro.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên",
            "Khách hàng"});
            this.comboVaiTro.Location = new System.Drawing.Point(660, 315);
            this.comboVaiTro.Name = "comboVaiTro";
            this.comboVaiTro.Size = new System.Drawing.Size(200, 28);
            this.comboVaiTro.TabIndex = 6;
            this.comboVaiTro.SelectedIndexChanged += new System.EventHandler(this.comboVaiTro_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.Location = new System.Drawing.Point(660, 382);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 46);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.Location = new System.Drawing.Point(800, 382);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 46);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.Location = new System.Drawing.Point(730, 434);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 46);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSearch.Location = new System.Drawing.Point(12, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(450, 28);
            this.txtSearch.TabIndex = 100;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimKiem.Location = new System.Drawing.Point(480, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(120, 35);
            this.btnTimKiem.TabIndex = 101;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FormQuanLyNguoiDung
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 509);
            this.Controls.Add(this.dataGridViewNguoiDung);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.comboVaiTro);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "FormQuanLyNguoiDung";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.FormQuanLyNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
