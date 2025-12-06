using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GaraOtoApp
{
    public partial class Form1 : Form
    {
        string connectionString =
            @"Data Source=DESKTOP-GU6T7OF\SQLEXPRESS;Initial Catalog=GaraOto;Integrated Security=True;Trust Server Certificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog(); // Hiện form đăng ký
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (user == "" || pass == "")
            {
                MessageBox.Show("Nhập đầy đủ tài khoản và mật khẩu!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM NguoiDung WHERE TenDangNhap=@u AND MatKhau=@p";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@p", pass);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        MessageBox.Show("Đăng nhập thành công!");

                        // Gán dữ liệu người dùng
                        CurrentUser.UserId = Convert.ToInt32(rd["NguoiDungId"]);
                        CurrentUser.FullName = rd["HoTen"].ToString();
                        CurrentUser.UserName = rd["TenDangNhap"].ToString();
                        CurrentUser.Role = Convert.ToInt32(rd["VaiTro"]);

                        // Mở form chính
                        FormMain formMain = new FormMain();
                        formMain.Show();

                        // Ẩn form đăng nhập
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void labelPass_Click(object sender, EventArgs e)
        {

        }
    }
}
