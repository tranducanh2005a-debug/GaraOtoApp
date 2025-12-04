using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace GaraOtoApp
{
    public partial class FormPhieuSuaChua : Form
    {
        string connectionString = @"Data Source=DESKTOP-GU6T7OF\SQLEXPRESS;Initial Catalog=GaraOto;Integrated Security=True;Trust Server Certificate=True";

        public FormPhieuSuaChua()
        {
            InitializeComponent();
        }

        private void FormPhieuSuaChua_Load(object sender, EventArgs e)
        {
            LoadPhieuSuaChua();
            LoadXe();
            LoadNhanVien();
        }

        private void LoadPhieuSuaChua()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT PhieuId, XeId, NhanVienId, TrangThai, MoTa, NgayTao, NgayHoanThanh FROM PhieuSuaChua", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPSC.DataSource = dt;
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
            if (comboXe.SelectedItem == null || comboNhanVien.SelectedItem == null)
            {
                MessageBox.Show("Chọn xe và nhân viên!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO PhieuSuaChua (XeId, NhanVienId, TrangThai, MoTa) VALUES (@xe,@nv,@tt,@mo)", conn);
                cmd.Parameters.AddWithValue("@xe", ((ComboBoxItem)comboXe.SelectedItem).Value);
                cmd.Parameters.AddWithValue("@nv", ((ComboBoxItem)comboNhanVien.SelectedItem).Value);
                cmd.Parameters.AddWithValue("@tt", comboTrangThai.SelectedIndex);
                cmd.Parameters.AddWithValue("@mo", txtMoTa.Text);
                cmd.ExecuteNonQuery();
            }
            LoadPhieuSuaChua();
            MessageBox.Show("Thêm phiếu sửa chữa thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewPSC.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewPSC.SelectedRows[0].Cells["PhieuId"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM PhieuSuaChua WHERE PhieuId=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                LoadPhieuSuaChua();
                MessageBox.Show("Xóa phiếu sửa chữa thành công!");
            }
        }
    }
}
