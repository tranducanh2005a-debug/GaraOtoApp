namespace GaraOtoApp
{
    partial class FormQuanLyXe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewXe;
        private System.Windows.Forms.TextBox txtBienSo, txtHang, txtMau, txtNam;
        private System.Windows.Forms.ComboBox comboChuSoHuu, comboLoaiXe;
        private System.Windows.Forms.Button btnThem, btnXoa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewXe = new System.Windows.Forms.DataGridView();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.comboChuSoHuu = new System.Windows.Forms.ComboBox();
            this.comboLoaiXe = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewXe
            // 
            this.dataGridViewXe.ColumnHeadersHeight = 29;
            this.dataGridViewXe.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewXe.Name = "dataGridViewXe";
            this.dataGridViewXe.ReadOnly = true;
            this.dataGridViewXe.RowHeadersWidth = 51;
            this.dataGridViewXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewXe.Size = new System.Drawing.Size(585, 300);
            this.dataGridViewXe.TabIndex = 0;
            this.dataGridViewXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXe_CellContentClick);
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(620, 20);
            this.txtBienSo.Multiline = true;
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(150, 22);
            this.txtBienSo.TabIndex = 1;
            this.txtBienSo.TextChanged += new System.EventHandler(this.txtBienSo_TextChanged);
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(620, 60);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(150, 22);
            this.txtHang.TabIndex = 2;
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(620, 100);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(150, 22);
            this.txtMau.TabIndex = 3;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(620, 140);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(150, 22);
            this.txtNam.TabIndex = 4;
            // 
            // comboChuSoHuu
            // 
            this.comboChuSoHuu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChuSoHuu.Location = new System.Drawing.Point(620, 180);
            this.comboChuSoHuu.Name = "comboChuSoHuu";
            this.comboChuSoHuu.Size = new System.Drawing.Size(150, 24);
            this.comboChuSoHuu.TabIndex = 5;
            // 
            // comboLoaiXe
            // 
            this.comboLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLoaiXe.Location = new System.Drawing.Point(620, 220);
            this.comboLoaiXe.Name = "comboLoaiXe";
            this.comboLoaiXe.Size = new System.Drawing.Size(150, 24);
            this.comboLoaiXe.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(620, 260);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 30);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(700, 260);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 30);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FormQuanLyXe
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.dataGridViewXe);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.txtHang);
            this.Controls.Add(this.txtMau);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.comboChuSoHuu);
            this.Controls.Add(this.comboLoaiXe);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Name = "FormQuanLyXe";
            this.Text = "Quản lý xe";
            this.Load += new System.EventHandler(this.FormQuanLyXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
