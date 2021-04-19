using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataBusinessLayer;
namespace QuanLiTho_NhomTho
{
    public partial class FrmXe : Form
    {
        DBBusiness db = new DBBusiness();
        DataSet dsX = new DataSet();
        DataSet dsK = new DataSet();
        public FrmXe()
        {
            InitializeComponent();
        }
        private new void DataBindings()
        {
            dsX = db.getXe();
            dgvXe.DataSource = dsX.Tables[0];
            txtMaXe.DataBindings.Clear();
            txtHangXe.DataBindings.Clear();
            cmbChuXe.DataBindings.Clear();
            //
            txtMaXe.DataBindings.Add("Text", dsX.Tables[0], "MaXe");
            txtHangXe.DataBindings.Add("Text", dsX.Tables[0], "HangXe");
            cmbChuXe.DataBindings.Add("Text", dsX.Tables[0], "ChuXe");
            // ComboBox
            dsK = db.getKhach();
            cmbChuXe.DataSource = dsK.Tables[0];
            cmbChuXe.DisplayMember = "TenKH";
            cmbChuXe.ValueMember = "MaKH";
            // cmbNhom.DataBindings.Add("Text", dsT.Tables[0], "TenNhomTho");
            // Đưa dữ liệu lên ComboBox trong DataGridView
            dsK = db.getKhach();
            (dgvXe.Columns["MaKH"] as
            DataGridViewComboBoxColumn).DataSource = dsK.Tables[0];
            (dgvXe.Columns["MaKH"] as
            DataGridViewComboBoxColumn).DisplayMember =
            "TenKH";
            (dgvXe.Columns["MaKH"] as
            DataGridViewComboBoxColumn).ValueMember =
            "MaKH";
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btnInsert.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.panel.Enabled = true;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnDelete.Enabled = true;
            this.btnClose.Enabled = true;
        }
        private void FrmXe_Load(object sender, EventArgs e)
        {
            DataBindings();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.insertXe(ref err, txtMaXe.Text, txtHangXe.Text, cmbChuXe.Text))
                MessageBox.Show(err);
            else DataBindings();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.deleteXe(ref err, txtMaXe.Text))
                MessageBox.Show(err);
            else DataBindings();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.updateXe(ref err, txtMaXe.Text, txtHangXe.Text, cmbChuXe.Text))
                MessageBox.Show(err);
            else DataBindings();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
