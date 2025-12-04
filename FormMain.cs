using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GaraOtoApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            // Phân quyền
            btnQuanLyNguoiDung.Enabled = CurrentUser.Role == 0;
            btnQuanLyXe.Enabled = CurrentUser.Role != 2;
            btnKho.Enabled = CurrentUser.Role != 2;
            btnPhieuSuaChua.Enabled = CurrentUser.Role != 2;
            btnLichHen.Enabled = true;  // tất cả có thể xem/đặt lịch
            btnHoaDon.Enabled = CurrentUser.Role != 2;
        }

        //Hàm đóng mở file

        private void OpenChildForm(Form child)
        {
            this.Hide();    // ẩn FormMain

            child.FormClosed += (s, args) =>
            {
                this.Show();   // hiện lại FormMain
            };

            child.Show();
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyNguoiDung());
        }

        private void btnQuanLyXe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyXe());
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKho());
        }

        private void btnPhieuSuaChua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPhieuSuaChua());
        }

        private void btnLichHen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLichHen());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoaDon());
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
