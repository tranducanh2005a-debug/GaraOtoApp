namespace GaraOtoApp
{
    partial class FormHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.ComboBox comboPhieu, comboPhuongThuc;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThem, btnXoa;
        private System.Windows.Forms.Label lblPhieu, lblTongTien, lblPTTT;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.comboPhieu = new System.Windows.Forms.ComboBox();
            this.comboPhuongThuc = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblPhieu = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblPTTT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.ColumnHeadersHeight = 29;
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.ReadOnly = true;
            this.dataGridViewHoaDon.RowHeadersWidth = 51;
            this.dataGridViewHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(500, 300);
            this.dataGridViewHoaDon.TabIndex = 0;
            // 
            // comboPhieu
            // 
            this.comboPhieu.Location = new System.Drawing.Point(620, 20);
            this.comboPhieu.Name = "comboPhieu";
            this.comboPhieu.Size = new System.Drawing.Size(150, 24);
            this.comboPhieu.TabIndex = 1;
            // 
            // comboPhuongThuc
            // 
            this.comboPhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPhuongThuc.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Thẻ"});
            this.comboPhuongThuc.Location = new System.Drawing.Point(620, 100);
            this.comboPhuongThuc.Name = "comboPhuongThuc";
            this.comboPhuongThuc.Size = new System.Drawing.Size(150, 24);
            this.comboPhuongThuc.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(620, 60);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 22);
            this.txtTongTien.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(520, 140);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(620, 140);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblPhieu
            // 
            this.lblPhieu.Location = new System.Drawing.Point(520, 20);
            this.lblPhieu.Name = "lblPhieu";
            this.lblPhieu.Size = new System.Drawing.Size(100, 23);
            this.lblPhieu.TabIndex = 6;
            this.lblPhieu.Text = "Chọn phiếu:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(520, 60);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(100, 23);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // lblPTTT
            // 
            this.lblPTTT.Location = new System.Drawing.Point(520, 100);
            this.lblPTTT.Name = "lblPTTT";
            this.lblPTTT.Size = new System.Drawing.Size(100, 23);
            this.lblPTTT.TabIndex = 8;
            this.lblPTTT.Text = "Phương thức TT:";
            // 
            // FormHoaDon
            // 
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.dataGridViewHoaDon);
            this.Controls.Add(this.comboPhieu);
            this.Controls.Add(this.comboPhuongThuc);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblPhieu);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblPTTT);
            this.Name = "FormHoaDon";
            this.Text = "Quản lý Hóa đơn";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
