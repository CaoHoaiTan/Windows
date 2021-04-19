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
    public partial class FrmTho : Form
    {
        DBBusiness db = new DBBusiness();
        DataSet dsT = new DataSet();
        DataSet dsNT = new DataSet();
        public FrmTho()
        {
            InitializeComponent();
        }
        private new void DataBindings()
        {
            dsT = db.getTho();
            dgvTho.DataSource = dsT.Tables[0];
            txtMaTho.DataBindings.Clear();
            txtTenTho.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            cmbNhom.DataBindings.Clear();
            //
            txtMaTho.DataBindings.Add("Text", dsT.Tables[0], "MaTho");
            txtTenTho.DataBindings.Add("Text", dsT.Tables[0], "TenTho");
            txtSDT.DataBindings.Add("Text", dsT.Tables[0], "SDT");
            txtDiaChi.DataBindings.Add("Text", dsT.Tables[0], "DiaChi");
            cmbNhom.DataBindings.Add("Text", dsT.Tables[0], "MaNhomTho");
            // ComboBox
            dsT = db.getNhomTho();
            cmbNhom.DataSource = dsT.Tables[0];
            cmbNhom.DisplayMember = "MaNhomTho";
            cmbNhom.ValueMember = "MaNhomTho";
            // cmbNhom.DataBindings.Add("Text", dsT.Tables[0], "TenNhomTho");
            // Đưa dữ liệu lên ComboBox trong DataGridView
            dsT = db.getNhomTho();
            (dgvTho.Columns["MaNhomTho"] as
            DataGridViewComboBoxColumn).DataSource = dsT.Tables[0];
            (dgvTho.Columns["MaNhomTho"] as
            DataGridViewComboBoxColumn).DisplayMember =
            "TenNhomTho";
            (dgvTho.Columns["MaNhomTho"] as
            DataGridViewComboBoxColumn).ValueMember =
            "MaNhomTho";
            // Không cho thao tác trên các nút Lưu / Hủy
            this.btnInsert.Enabled = true;
            this.btnUpdate.Enabled = true;
            this.panel.Enabled = true;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnDelete.Enabled = true;
            this.btnClose.Enabled = true;
        }
        private void FrmTho_Load(object sender, EventArgs e)
        {
            DataBindings();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.insertTho(ref err, txtMaTho.Text, txtTenTho.Text, txtSDT.Text, txtDiaChi.Text, cmbNhom.Text))
                MessageBox.Show(err);
            else DataBindings();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.deleteTho(ref err, txtMaTho.Text))
                MessageBox.Show(err);
            else DataBindings();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!db.updateTho(ref err, txtMaTho.Text, txtTenTho.Text, txtSDT.Text, txtDiaChi.Text, cmbNhom.Text))
                MessageBox.Show(err);
            else DataBindings();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
