using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GaraOtoApp
{
    public partial class FormQuanLyXe : Form
    {
        string connectionString = @"Data Source=DESKTOP-GU6T7OF\SQLEXPRESS;Initial Catalog=GaraOto;Integrated Security=True;Trust Server Certificate=True";

        public FormQuanLyXe()
        {
            InitializeComponent();
        }

        private void FormQuanLyXe_Load(object sender, EventArgs e)
        {
            LoadXe();
            LoadComboBox();
            SetPlaceholders();
        }

        private void LoadXe()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT XeId, BienSo, HangXe, MauXe, NamSanXuat FROM Xe", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewXe.DataSource = dt;
            }
        }

        private void LoadComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Chu sở hữu
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT NguoiDungId, HoTen FROM NguoiDung WHERE VaiTro=2", conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                comboChuSoHuu.DataSource = dt1;
                comboChuSoHuu.DisplayMember = "HoTen";
                comboChuSoHuu.ValueMember = "NguoiDungId";

                // Loại xe
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT LoaiXeId, TenLoai FROM LoaiXe", conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                comboLoaiXe.DataSource = dt2;
                comboLoaiXe.DisplayMember = "TenLoai";
                comboLoaiXe.ValueMember = "LoaiXeId";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtBienSo.Text == "Biển số" || txtBienSo.Text.Trim() == "")
            {
                MessageBox.Show("Nhập Biển số!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Xe (ChuSoHuuId, LoaiXeId, BienSo, HangXe, MauXe, NamSanXuat) " +
                    "VALUES (@chu, @loai, @bien, @hang, @mau, @nam)", conn);
                cmd.Parameters.AddWithValue("@chu", comboChuSoHuu.SelectedValue);
                cmd.Parameters.AddWithValue("@loai", comboLoaiXe.SelectedValue);
                cmd.Parameters.AddWithValue("@bien", txtBienSo.Text);
                cmd.Parameters.AddWithValue("@hang", txtHang.Text);
                cmd.Parameters.AddWithValue("@mau", txtMau.Text);
                cmd.Parameters.AddWithValue("@nam", int.Parse(txtNam.Text));
                cmd.ExecuteNonQuery();
            }
            LoadXe();
            MessageBox.Show("Thêm xe thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewXe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn xe cần xóa!");
                return;
            }

            int xeId = Convert.ToInt32(dataGridViewXe.SelectedRows[0].Cells["XeId"].Value);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Xe WHERE XeId=@id", conn);
                cmd.Parameters.AddWithValue("@id", xeId);
                cmd.ExecuteNonQuery();
            }
            LoadXe();
            MessageBox.Show("Xóa xe thành công!");
        }

        private void SetPlaceholders()
        {
            SetPlaceholder(txtBienSo, "Biển số");
            SetPlaceholder(txtHang, "Hãng xe");
            SetPlaceholder(txtMau, "Màu xe");
            SetPlaceholder(txtNam, "Năm sản xuất");
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

        private void txtBienSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
