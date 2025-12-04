namespace GaraOtoApp
{
    partial class FormLichHen
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewLichHen;
        private System.Windows.Forms.ComboBox comboXe, comboKhachHang, comboNhanVien;
        private System.Windows.Forms.DateTimePicker dateTimePickerHen;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem, btnXoa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewLichHen = new System.Windows.Forms.DataGridView();
            this.comboXe = new System.Windows.Forms.ComboBox();
            this.comboKhachHang = new System.Windows.Forms.ComboBox();
            this.comboNhanVien = new System.Windows.Forms.ComboBox();
            this.dateTimePickerHen = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichHen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLichHen
            // 
            this.dataGridViewLichHen.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLichHen.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewLichHen.ReadOnly = true;
            this.dataGridViewLichHen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // comboXe
            // 
            this.comboXe.Location = new System.Drawing.Point(620, 20);
            this.comboXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboXe.Size = new System.Drawing.Size(150, 24);
            // 
            // comboKhachHang
            // 
            this.comboKhachHang.Location = new System.Drawing.Point(620, 60);
            this.comboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKhachHang.Size = new System.Drawing.Size(150, 24);
            // 
            // comboNhanVien
            // 
            this.comboNhanVien.Location = new System.Drawing.Point(620, 100);
            this.comboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNhanVien.Size = new System.Drawing.Size(150, 24);
            // 
            // dateTimePickerHen
            // 
            this.dateTimePickerHen.Location = new System.Drawing.Point(620, 140);
            this.dateTimePickerHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHen.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerHen.Size = new System.Drawing.Size(150, 22);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(620, 180);
            this.txtGhiChu.Size = new System.Drawing.Size(150, 22);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(620, 220);
            this.btnThem.Size = new System.Drawing.Size(70, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(700, 220);
            this.btnXoa.Size = new System.Drawing.Size(70, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FormLichHen
            // 
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.dataGridViewLichHen);
            this.Controls.Add(this.comboXe);
            this.Controls.Add(this.comboKhachHang);
            this.Controls.Add(this.comboNhanVien);
            this.Controls.Add(this.dateTimePickerHen);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Text = "Quản lý Lịch Hẹn";
            this.Load += new System.EventHandler(this.FormLichHen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichHen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
