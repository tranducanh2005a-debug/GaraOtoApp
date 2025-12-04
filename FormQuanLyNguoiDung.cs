using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GaraOtoApp
{
    public partial class FormQuanLyNguoiDung : Form
    {
        string connectionString = @"Data Source=DESKTOP-GU6T7OF\SQLEXPRESS;Initial Catalog=GaraOto;Integrated Security=True;Trust Server Certificate=True";
        int selectedId = -1;

        public FormQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void FormQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            LoadNguoiDung();
            SetPlaceholders();
        }

        private void LoadNguoiDung()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NguoiDung", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewNguoiDung.DataSource = dt;
            }
        }

        //==========================================================
        // CHECK TRÙNG TÊN ĐĂNG NHẬP
        //==========================================================
        private bool CheckUserExist(string username, int ignoreId = -1)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap=@u AND NguoiDungId<>@id",
                    conn);

                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@id", ignoreId);

                int result = (int)cmd.ExecuteScalar();

                return result > 0;
            }
        }

        //==========================================================
        // THÊM NGƯỜI DÙNG
        //==========================================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text.Trim();
            string dt = txtDienThoai.Text.Trim();
            string dc = txtDiaChi.Text.Trim();
            string tdn = txtTenDangNhap.Text.Trim();
            string mk = txtMatKhau.Text.Trim();
            int vt = comboVaiTro.SelectedIndex;

            if (hoten == "" || dt == "" || dc == "" || tdn == "" || mk == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (CheckUserExist(tdn))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO NguoiDung(HoTen, DienThoai, DiaChi, TenDangNhap, MatKhau, VaiTro) " +
                    "VALUES(@ht, @dt, @dc, @tdn, @mk, @vt)", conn);

                cmd.Parameters.AddWithValue("@ht", hoten);
                cmd.Parameters.AddWithValue("@dt", dt);
                cmd.Parameters.AddWithValue("@dc", dc);
                cmd.Parameters.AddWithValue("@tdn", tdn);
                cmd.Parameters.AddWithValue("@mk", mk);
                cmd.Parameters.AddWithValue("@vt", vt);

                cmd.ExecuteNonQuery();
            }

            LoadNguoiDung();
            MessageBox.Show("Thêm thành công!");
            ClearForm();
        }

        //==========================================================
        // CHỌN DÒNG ĐỂ SỬA
        //==========================================================
        private void dataGridViewNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dataGridViewNguoiDung.Rows[e.RowIndex].Cells["NguoiDungId"].Value);

                txtHoTen.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                txtDienThoai.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
                txtDiaChi.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtTenDangNhap.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
                comboVaiTro.SelectedIndex = Convert.ToInt32(dataGridViewNguoiDung.Rows[e.RowIndex].Cells["VaiTro"].Value);
            }
        }

        //==========================================================
        // SỬA NGƯỜI DÙNG
        //==========================================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Vui lòng chọn người dùng để sửa!");
                return;
            }

            string hoten = txtHoTen.Text.Trim();
            string dt = txtDienThoai.Text.Trim();
            string dc = txtDiaChi.Text.Trim();
            string tdn = txtTenDangNhap.Text.Trim();
            string mk = txtMatKhau.Text.Trim();
            int vt = comboVaiTro.SelectedIndex;

            if (hoten == "" || dt == "" || dc == "" || tdn == "" || mk == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (CheckUserExist(tdn, selectedId))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE NguoiDung SET HoTen=@ht, DienThoai=@dt, DiaChi=@dc, TenDangNhap=@tdn, MatKhau=@mk, VaiTro=@vt WHERE NguoiDungId=@id",
                    conn);

                cmd.Parameters.AddWithValue("@ht", hoten);
                cmd.Parameters.AddWithValue("@dt", dt);
                cmd.Parameters.AddWithValue("@dc", dc);
                cmd.Parameters.AddWithValue("@tdn", tdn);
                cmd.Parameters.AddWithValue("@mk", mk);
                cmd.Parameters.AddWithValue("@vt", vt);
                cmd.Parameters.AddWithValue("@id", selectedId);

                cmd.ExecuteNonQuery();
            }

            LoadNguoiDung();
            MessageBox.Show("Sửa thành công!");
            ClearForm();
        }

        //==========================================================
        // XÓA
        //==========================================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Chọn người dùng cần xoá!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM NguoiDung WHERE NguoiDungId=@id", conn);
                cmd.Parameters.AddWithValue("@id", selectedId);

                cmd.ExecuteNonQuery();
            }

            LoadNguoiDung();
            MessageBox.Show("Xóa thành công!");
            ClearForm();
        }

        //==========================================================
        // HÀM PHỤ
        //==========================================================
        private void ClearForm()
        {
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            comboVaiTro.SelectedIndex = 0;
            selectedId = -1;
        }

        // Placeholder (giữ nguyên)
        private void SetPlaceholders()
        {
            SetPlaceholder(txtHoTen, "Họ tên");
            SetPlaceholder(txtDienThoai, "Điện thoại");
            SetPlaceholder(txtDiaChi, "Địa chỉ");
            SetPlaceholder(txtTenDangNhap, "Tên đăng nhập");
            SetPlaceholder(txtMatKhau, "Mật khẩu");
        }

        private void SetPlaceholder(TextBox txt, string text)
        {
            txt.Text = text;
            txt.ForeColor = Color.Gray;

            txt.Enter += (s, e) =>
            {
                if (txt.Text == text)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            txt.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = text;
                    txt.ForeColor = Color.Gray;
                }
            };
        }
    }
}
