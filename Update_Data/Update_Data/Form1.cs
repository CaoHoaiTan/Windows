using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Update_Data
{
    public partial class frm : Form
    {
        // Hàm xemm danh mục
        void XemDanhMuc(int intDanhMuc)
        {
            Form frm = new Form3();
            frm.Text = intDanhMuc.ToString();
            frm.ShowDialog();
        }
        public frm()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {

            Form frm2 = new frmlogin();
            frm2.ShowDialog();

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm2 = new frmlogin();
            frm2.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void danhMụcThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);

        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }

        private void danhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5);

        }

        private void danhMMucjChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);

        }

        private void danhMụcThànhPhốToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.Text = "Quản lý Danh mục Thành Phố";
            frm.ShowDialog();
        }

        private void danhMụcKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form5();
            frm.Text = "Quản lý Danh mục khách hàng";
            frm.ShowDialog();
        }

        private void danhMụcNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form6();
            frm.Text = "Quản lý Danh mục Nhân Viên";
            frm.ShowDialog();
        }

        private void danhMụcSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form7();
            frm.Text = "Quản lý Danh mục Sản Phẩm";
            frm.ShowDialog();
        }

        private void danhMụcHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form8();
            frm.Text = "Quản lý Danh mục Hóa Đơn";
            frm.ShowDialog();
        }

        private void danhMụcChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form9();
            frm.Text = "Quản lý Danh mục Chi Tiết Hóa Đơn";
            frm.ShowDialog();
        }
    }
}
