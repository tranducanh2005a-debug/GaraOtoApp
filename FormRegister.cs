using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GaraOtoApp
{
    public partial class FormRegister : Form
    {
        string connectionString =
            @"Data Source=DESKTOP-GU6T7OF\SQLEXPRESS;Initial Catalog=GaraOto;Integrated Security=True;Trust Server Certificate=True";

        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            int role = 2;

            if (fullName == "" || phone == "" || address == "" || user == "" || pass == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra trùng tên đăng nhập
                    string checkQuery = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap=@u";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@u", user);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!");
                        return;
                    }

                    // Thêm người dùng mới
                    string insertQuery = @"INSERT INTO NguoiDung (HoTen, DienThoai, DiaChi, TenDangNhap, MatKhau, VaiTro)
                                           VALUES (@hn, @dt, @dc, @u, @p, @r)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@hn", fullName);
                    cmd.Parameters.AddWithValue("@dt", phone);
                    cmd.Parameters.AddWithValue("@dc", address);
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@p", pass);
                    cmd.Parameters.AddWithValue("@r", role);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load_1(object sender, EventArgs e)
        {

        }
    }
}
