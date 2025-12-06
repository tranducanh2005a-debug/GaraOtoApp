using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GaraOtoApp
{
    public partial class FormQuanLyNguoiDung : Form
    {
        string connectionString =
            @"Data Source=DESKTOP-GU6T7OF\SQLEXPRESS;Initial Catalog=GaraOto;Integrated Security=True;Trust Server Certificate=True";

        int selectedId = -1;

        public FormQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void FormQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            LoadNguoiDung();
            SetPlaceholders();
            SetSearchPlaceholder(); 
        }

        // =====================================================
        // LOAD DỮ LIỆU
        // =====================================================
        private void LoadNguoiDung(string keyword = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM NguoiDung";

                // Nếu có từ khóa → thêm WHERE
                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    sql += " WHERE HoTen LIKE @kw OR DienThoai LIKE @kw";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);

                if (!string.IsNullOrWhiteSpace(keyword))
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewNguoiDung.DataSource = dt;
            }
        }


        // =====================================================
        // CHECK TRÙNG TÊN ĐĂNG NHẬP
        // =====================================================
        private bool CheckUserExist(string username, int ignoreId = -1)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap=@u AND NguoiDungId<>@id", conn);

                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@id", ignoreId);

                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        // =====================================================
        // CHECK TRÙNG SĐT
        // =====================================================
        private bool CheckPhoneExist(string phone, int ignoreId = -1)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM NguoiDung WHERE DienThoai=@p AND NguoiDungId<>@id", conn);

                cmd.Parameters.AddWithValue("@p", phone);
                cmd.Parameters.AddWithValue("@id", ignoreId);

                return (int)cmd.ExecuteScalar() > 0;
            }
        }


        // =====================================================
        // PLACEHOLDER
        // =====================================================
        private bool IsPlaceholder(TextBox txt, string placeholder)
        {
            return txt.Text == placeholder && txt.ForeColor == Color.Gray;
        }

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
                if (txt.Text == text && txt.ForeColor == Color.Gray)
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

        // =====================================================
        // PLACEHOLDER CHO Ô TÌM KIẾM
        // =====================================================
        private void SetSearchPlaceholder()
        {
            txtSearch.Text = "Tìm theo tên hoặc SĐT...";
            txtSearch.ForeColor = Color.Gray;

            txtSearch.Enter += (s, e) =>
            {
                if (txtSearch.ForeColor == Color.Gray)
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
            };

            txtSearch.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Tìm theo tên hoặc SĐT...";
                    txtSearch.ForeColor = Color.Gray;
                }
            };
        }

        // =====================================================
        // NÚT TÌM KIẾM
        // =====================================================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.Gray)
            {
                MessageBox.Show("Nhập từ khóa tìm kiếm!");
                return;
            }

            LoadNguoiDung(txtSearch.Text.Trim());
        }


        // =====================================================
        // NÚT THÊM
        // =====================================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (IsPlaceholder(txtHoTen, "Họ tên") ||
                IsPlaceholder(txtDienThoai, "Điện thoại") ||
                IsPlaceholder(txtDiaChi, "Địa chỉ") ||
                IsPlaceholder(txtTenDangNhap, "Tên đăng nhập") ||
                IsPlaceholder(txtMatKhau, "Mật khẩu"))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string hoten = txtHoTen.Text.Trim();
            string dt = txtDienThoai.Text.Trim();
            string dc = txtDiaChi.Text.Trim();
            string tdn = txtTenDangNhap.Text.Trim();
            string mk = txtMatKhau.Text.Trim();
            int vt = comboVaiTro.SelectedIndex;

            if (CheckPhoneExist(dt))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!");
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

        // =====================================================
        // CLICK DÒNG
        // =====================================================
        private void dataGridViewNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(
                    dataGridViewNguoiDung.Rows[e.RowIndex].Cells["NguoiDungId"].Value);

                txtHoTen.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                txtHoTen.ForeColor = Color.Black;

                txtDienThoai.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
                txtDienThoai.ForeColor = Color.Black;

                txtDiaChi.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtDiaChi.ForeColor = Color.Black;

                txtTenDangNhap.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                txtTenDangNhap.ForeColor = Color.Black;

                txtMatKhau.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
                txtMatKhau.ForeColor = Color.Black;

                comboVaiTro.SelectedIndex =
                    Convert.ToInt32(dataGridViewNguoiDung.Rows[e.RowIndex].Cells["VaiTro"].Value);
            }
        }

        // =====================================================
        // NÚT SỬA
        // =====================================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Vui lòng chọn người dùng để sửa!");
                return;
            }

            if (IsPlaceholder(txtHoTen, "Họ tên") ||
                IsPlaceholder(txtDienThoai, "Điện thoại") ||
                IsPlaceholder(txtDiaChi, "Địa chỉ") ||
                IsPlaceholder(txtTenDangNhap, "Tên đăng nhập") ||
                IsPlaceholder(txtMatKhau, "Mật khẩu"))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string hoten = txtHoTen.Text.Trim();
            string dt = txtDienThoai.Text.Trim();
            string dc = txtDiaChi.Text.Trim();
            string tdn = txtTenDangNhap.Text.Trim();
            string mk = txtMatKhau.Text.Trim();
            int vt = comboVaiTro.SelectedIndex;

            if (CheckPhoneExist(dt, selectedId))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!");
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

        // =====================================================
        // NÚT XÓA
        // =====================================================
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

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM NguoiDung WHERE NguoiDungId=@id", conn);

                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.ExecuteNonQuery();
            }

            LoadNguoiDung();
            MessageBox.Show("Xóa thành công!");
            ClearForm();
        }

        // =====================================================
        // CLEAR FORM
        // =====================================================
        private void ClearForm()
        {
            SetPlaceholders();
            comboVaiTro.SelectedIndex = 0;
            selectedId = -1;
        }

        private void comboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
