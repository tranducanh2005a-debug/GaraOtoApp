namespace GaraOtoApp
{
    partial class FormKho
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewKho;
        private System.Windows.Forms.TextBox txtTen, txtDonGia, txtSoLuong, txtDonVi;
        private System.Windows.Forms.Button btnThem, btnXoa;
        private System.Windows.Forms.Label lblTen, lblDonGia, lblSoLuong, lblDonVi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewKho = new System.Windows.Forms.DataGridView();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();

            this.lblTen = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonVi = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKho)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewKho
            // 
            this.dataGridViewKho.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewKho.Size = new System.Drawing.Size(500, 300);
            this.dataGridViewKho.ReadOnly = true;
            this.dataGridViewKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // 
            // Labels
            // 
            this.lblTen.Text = "Tên phụ tùng:"; this.lblTen.Location = new System.Drawing.Point(520, 20);
            this.lblDonGia.Text = "Đơn giá:"; this.lblDonGia.Location = new System.Drawing.Point(520, 60);
            this.lblSoLuong.Text = "Số lượng:"; this.lblSoLuong.Location = new System.Drawing.Point(520, 100);
            this.lblDonVi.Text = "Đơn vị:"; this.lblDonVi.Location = new System.Drawing.Point(520, 140);

            // 
            // TextBoxes
            // 
            this.txtTen.Location = new System.Drawing.Point(600, 20); this.txtTen.Width = 150;
            this.txtDonGia.Location = new System.Drawing.Point(600, 60); this.txtDonGia.Width = 150;
            this.txtSoLuong.Location = new System.Drawing.Point(600, 100); this.txtSoLuong.Width = 150;
            this.txtDonVi.Location = new System.Drawing.Point(600, 140); this.txtDonVi.Width = 150;

            // 
            // Buttons
            // 
            this.btnThem.Text = "Thêm"; this.btnThem.Location = new System.Drawing.Point(520, 180); this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnXoa.Text = "Xóa"; this.btnXoa.Location = new System.Drawing.Point(600, 180); this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // FormKho
            // 
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.dataGridViewKho);
            this.Controls.Add(this.txtTen); this.Controls.Add(this.txtDonGia); this.Controls.Add(this.txtSoLuong); this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.btnThem); this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblTen); this.Controls.Add(this.lblDonGia); this.Controls.Add(this.lblSoLuong); this.Controls.Add(this.lblDonVi);
            this.Text = "Quản lý kho";
            this.Load += new System.EventHandler(this.FormKho_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
