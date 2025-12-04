namespace GaraOtoApp
{
    partial class FormPhieuSuaChua
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPSC;
        private System.Windows.Forms.ComboBox comboXe, comboNhanVien, comboTrangThai;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnThem, btnXoa;
        private System.Windows.Forms.Label lblXe, lblNhanVien, lblTrangThai, lblMoTa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewPSC = new System.Windows.Forms.DataGridView();
            this.comboXe = new System.Windows.Forms.ComboBox();
            this.comboNhanVien = new System.Windows.Forms.ComboBox();
            this.comboTrangThai = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblXe = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPSC)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPSC
            // 
            this.dataGridViewPSC.ColumnHeadersHeight = 29;
            this.dataGridViewPSC.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPSC.Name = "dataGridViewPSC";
            this.dataGridViewPSC.ReadOnly = true;
            this.dataGridViewPSC.RowHeadersWidth = 51;
            this.dataGridViewPSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPSC.Size = new System.Drawing.Size(500, 300);
            this.dataGridViewPSC.TabIndex = 0;
            // 
            // comboXe
            // 
            this.comboXe.Location = new System.Drawing.Point(620, 20);
            this.comboXe.Name = "comboXe";
            this.comboXe.Size = new System.Drawing.Size(150, 24);
            this.comboXe.TabIndex = 1;
            // 
            // comboNhanVien
            // 
            this.comboNhanVien.Location = new System.Drawing.Point(620, 60);
            this.comboNhanVien.Name = "comboNhanVien";
            this.comboNhanVien.Size = new System.Drawing.Size(150, 24);
            this.comboNhanVien.TabIndex = 2;
            // 
            // comboTrangThai
            // 
            this.comboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrangThai.Items.AddRange(new object[] {
            "Chờ",
            "Đang sửa",
            "Hoàn tất"});
            this.comboTrangThai.Location = new System.Drawing.Point(620, 100);
            this.comboTrangThai.Name = "comboTrangThai";
            this.comboTrangThai.Size = new System.Drawing.Size(150, 24);
            this.comboTrangThai.TabIndex = 3;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(620, 140);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(150, 22);
            this.txtMoTa.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(545, 199);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(672, 199);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblXe
            // 
            this.lblXe.Location = new System.Drawing.Point(520, 20);
            this.lblXe.Name = "lblXe";
            this.lblXe.Size = new System.Drawing.Size(100, 23);
            this.lblXe.TabIndex = 7;
            this.lblXe.Text = "Xe:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Location = new System.Drawing.Point(520, 60);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(100, 23);
            this.lblNhanVien.TabIndex = 8;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Location = new System.Drawing.Point(520, 100);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(100, 23);
            this.lblTrangThai.TabIndex = 9;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.Location = new System.Drawing.Point(520, 140);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(100, 23);
            this.lblMoTa.TabIndex = 10;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // FormPhieuSuaChua
            // 
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.dataGridViewPSC);
            this.Controls.Add(this.comboXe);
            this.Controls.Add(this.comboNhanVien);
            this.Controls.Add(this.comboTrangThai);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblXe);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblMoTa);
            this.Name = "FormPhieuSuaChua";
            this.Text = "Quản lý Phiếu sửa chữa";
            this.Load += new System.EventHandler(this.FormPhieuSuaChua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPSC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
