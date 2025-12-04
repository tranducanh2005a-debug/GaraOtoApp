using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace GaraOtoApp
{
    public partial class FormHoaDon : Form
    {
        string connectionString = @"Data Source=DESKTOP-GU6T7OF\SQLEXPRESS;Initial Catalog=GaraOto;Integrated Security=True;Trust Server Certificate=True";

        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadPhieuSuaChua();
        }

        private void LoadHoaDon()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT HoaDonId, PhieuId, TongTien, NgayThanhToan, PhuongThucTT FROM HoaDon", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewHoaDon.DataSource = dt;
            }
        }

        private void LoadPhieuSuaChua()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT PhieuId FROM PhieuSuaChua", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                comboPhieu.Items.Clear();
                while (reader.Read())
                {
                    comboPhieu.Items.Add(new ComboBoxItem("Phiếu " + reader["PhieuId"].ToString(), reader["PhieuId"]));
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (comboPhieu.SelectedItem == null || txtTongTien.Text.Trim() == "")
            {
                MessageBox.Show("Chọn phiếu và nhập tổng tiền!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO HoaDon (PhieuId, TongTien, PhuongThucTT) VALUES (@phieu,@tong,@pt)", conn);
                cmd.Parameters.AddWithValue("@phieu", ((ComboBoxItem)comboPhieu.SelectedItem).Value);
                cmd.Parameters.AddWithValue("@tong", float.Parse(txtTongTien.Text));
                cmd.Parameters.AddWithValue("@pt", comboPhuongThuc.SelectedItem?.ToString() ?? "Tiền mặt");
                cmd.ExecuteNonQuery();
            }
            LoadHoaDon();
            MessageBox.Show("Thêm hóa đơn thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewHoaDon.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewHoaDon.SelectedRows[0].Cells["HoaDonId"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM HoaDon WHERE HoaDonId=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                LoadHoaDon();
                MessageBox.Show("Xóa hóa đơn thành công!");
            }
        }
    }
}
