using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace GaraOtoApp
{
    public partial class FormLichHen : Form
    {
        string connectionString = @"Data Source=DESKTOP-GU6T7OF\SQLEXPRESS;Initial Catalog=GaraOto;Integrated Security=True;Trust Server Certificate=True";

        public FormLichHen()
        {
            InitializeComponent();
        }

        private void FormLichHen_Load(object sender, EventArgs e)
        {
            LoadLichHen();
            LoadXe();
            LoadKhachHang();
            LoadNhanVien();
        }

        private void LoadLichHen()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT LichHenId, XeId, KhachHangId, NhanVienId, ThoiGianHen, GhiChu, TrangThai FROM LichHen", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewLichHen.DataSource = dt;
            }
        }

        private void LoadXe()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT XeId, BienSo FROM Xe", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                comboXe.Items.Clear();
                while (reader.Read())
                {
                    comboXe.Items.Add(new ComboBoxItem(reader["BienSo"].ToString(), reader["XeId"]));
                }
            }
        }

        private void LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT NguoiDungId, HoTen FROM NguoiDung WHERE VaiTro=2", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                comboKhachHang.Items.Clear();
                while (reader.Read())
                {
                    comboKhachHang.Items.Add(new ComboBoxItem(reader["HoTen"].ToString(), reader["NguoiDungId"]));
                }
            }
        }

        private void LoadNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT NguoiDungId, HoTen FROM NguoiDung WHERE VaiTro=1", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                comboNhanVien.Items.Clear();
                while (reader.Read())
                {
                    comboNhanVien.Items.Add(new ComboBoxItem(reader["HoTen"].ToString(), reader["NguoiDungId"]));
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (comboXe.SelectedItem == null || comboKhachHang.SelectedItem == null)
            {
                MessageBox.Show("Chọn Xe và Khách hàng!");
                return;
            }

            int xeId = ((ComboBoxItem)comboXe.SelectedItem).Value;
            int khId = ((ComboBoxItem)comboKhachHang.SelectedItem).Value;
            int nvId = comboNhanVien.SelectedItem != null ? ((ComboBoxItem)comboNhanVien.SelectedItem).Value : (int?)null ?? 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO LichHen (XeId, KhachHangId, NhanVienId, ThoiGianHen, GhiChu, TrangThai) " +
                    "VALUES (@Xe, @Kh, @Nv, @TG, @GhiChu, 0)", conn);
                cmd.Parameters.AddWithValue("@Xe", xeId);
                cmd.Parameters.AddWithValue("@Kh", khId);
                cmd.Parameters.AddWithValue("@Nv", nvId);
                cmd.Parameters.AddWithValue("@TG", dateTimePickerHen.Value);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                cmd.ExecuteNonQuery();
            }

            LoadLichHen();
            MessageBox.Show("Thêm lịch hẹn thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewLichHen.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn dòng cần xóa!");
                return;
            }

            int id = Convert.ToInt32(dataGridViewLichHen.SelectedRows[0].Cells["LichHenId"].Value);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM LichHen WHERE LichHenId=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            LoadLichHen();
            MessageBox.Show("Xóa thành công!");
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public ComboBoxItem(string text, object value)
        {
            Text = text;
            Value = Convert.ToInt32(value);
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
