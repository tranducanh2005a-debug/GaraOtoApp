using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace GaraOtoApp
{
    public partial class FormKho : Form
    {
        string connectionString = @"Data Source=DESKTOP-GU6T7OF\SQLEXPRESS;Initial Catalog=GaraOto;Integrated Security=True;Trust Server Certificate=True";

        public FormKho()
        {
            InitializeComponent();
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            LoadPhuTung();
        }

        private void LoadPhuTung()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhuTung", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewKho.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO PhuTung (TenPhuTung, DonGia, SoLuongTon, DonVi) VALUES (@ten,@gia,@sl,@dv)", conn);
                cmd.Parameters.AddWithValue("@ten", txtTen.Text);
                cmd.Parameters.AddWithValue("@gia", txtDonGia.Text);
                cmd.Parameters.AddWithValue("@sl", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@dv", txtDonVi.Text);
                cmd.ExecuteNonQuery();
            }
            LoadPhuTung();
            MessageBox.Show("Thêm phụ tùng thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewKho.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewKho.SelectedRows[0].Cells["PhuTungId"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM PhuTung WHERE PhuTungId=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                LoadPhuTung();
                MessageBox.Show("Xóa phụ tùng thành công!");
            }
        }
    }
}
