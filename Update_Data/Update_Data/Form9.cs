using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Update_Data
{
    public partial class Form9 : Form
    {
        // Chuỗi kết nối
        string strConnectionString = "Data Source=DESKTOP-C6NONEG;Initial Catalog=QuanLyBanHang;Integrated Security = True";
        // Đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtThanhPho
        SqlDataAdapter daSanPham = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtSanPham = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        SqlDataAdapter daChiTietHoaDon = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtChiTietHoaDon = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        void LoadData()
        {

            try
            {
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu vào DataTable dtThanhPho
                daChiTietHoaDon = new SqlDataAdapter("SELECT * FROM CHITIETHOADON", conn);
                dtChiTietHoaDon = new DataTable();
                dtChiTietHoaDon.Clear();
                daChiTietHoaDon.Fill(dtChiTietHoaDon);
                // Đưa dữ liệu lên ComboBox trong DataGridView
                (dgvCHITIETHOADON.Columns["MaHD"] as
                DataGridViewComboBoxColumn).DataSource = dtChiTietHoaDon;
                (dgvCHITIETHOADON.Columns["MaHD"] as
                DataGridViewComboBoxColumn).DisplayMember =
                "MaHD";
                (dgvCHITIETHOADON.Columns["MaHD"] as
                DataGridViewComboBoxColumn).ValueMember =
                "MaHD";
                // Vận chuyển dữ liệu vào DataTable dtThanhPho
                daSanPham = new SqlDataAdapter("SELECT * FROM SANPHAM", conn);
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                daSanPham.Fill(dtSanPham);
                // Đưa dữ liệu lên ComboBox trong DataGridView
                (dgvCHITIETHOADON.Columns["MaSP"] as
                DataGridViewComboBoxColumn).DataSource = dtSanPham;
                (dgvCHITIETHOADON.Columns["MaSP"] as
                DataGridViewComboBoxColumn).DisplayMember =
                "TenSP";
                (dgvCHITIETHOADON.Columns["MaSP"] as
                DataGridViewComboBoxColumn).ValueMember =
                "MaSP";
                //// Vận chuyển dữ liệu vào DataTable dtKhachHang
                //daHoaDon = new SqlDataAdapter("SELECT * FROM HOADON", conn);
                //dtHoaDon = new DataTable();
                //dtHoaDon.Clear();
                //daHoaDon.Fill(dtHoaDon);
                // Đưa dữ liệu lên DataGridView
                dgvCHITIETHOADON.DataSource = dtChiTietHoaDon;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table CHITIETHOADON.Lỗi rồi!!!");
            }
        }
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtChiTietHoaDon.Dispose();
            dtChiTietHoaDon = null;
            dtSanPham.Dispose();
            dtSanPham = null;
            // Hủy kết nối
            conn = null;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            conn.Open();
            // Thêm dữ liệu
            if (Them)
            {
              //  try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Lệnh Insert InTo
                    cmd.CommandText = System.String.Concat("Insert Into ChiTietHoaDon Values(" + "'" +
                    this.cbMaHD.SelectedValue.ToString() + "','" +
                    this.cbMaSP.SelectedValue.ToString() + "','" +
                    this.txtSoLuong.Text.ToString() +
                    "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
               // catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            if (!Them)
            {
        //        try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Thứ tự dòng hiện hành
                    int r = dgvCHITIETHOADON.CurrentCell.RowIndex;
                    // MaKH hiện hành
                    string strMAHD =
                    dgvCHITIETHOADON.Rows[r].Cells[0].Value.ToString();
                    // Câu lệnh SQL
                    cmd.CommandText = System.String.Concat("Update ChiTietHoaDon Set MaHD = '" +
                    this.cbMaHD.SelectedValue.ToString() + "', MaSP='"
                    + this.cbMaSP.SelectedValue.ToString() + "',SoLuong= '" +
                    this.txtSoLuong.Text.ToString() + "' Where MaHD = '" + strMAHD + "'");
                    // Cập nhật
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã sửa xong!");
                }
           //     catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!");
                }
            }
            // Đóng kết nối
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtSoLuong.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa dữ liệu lên ComboBox
            this.cbMaHD.DataSource = dtChiTietHoaDon;
            this.cbMaHD.DisplayMember = "MaHD";
            this.cbMaHD.ValueMember = "MaHD";
            // Đưa dữ liệu lên ComboBox
            this.cbMaSP.DataSource = dtSanPham;
            this.cbMaSP.DisplayMember = "TenSP";
            this.cbMaSP.ValueMember = "MaSP";
            // Đưa con trỏ đến TextField txtThanhPho
            this.cbMaHD.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Đưa dữ liệu lên ComboBox
            this.cbMaHD.DataSource = dtChiTietHoaDon;
            this.cbMaHD.DisplayMember = "MaHD";
            this.cbMaHD.ValueMember = "MaHD";
            // Đưa dữ liệu lên ComboBox
            this.cbMaSP.DataSource = dtSanPham;
            this.cbMaSP.DisplayMember = "TenSP";
            this.cbMaSP.ValueMember = "MaSP";
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            // Thứ tự dòng hiện hành
            int r = dgvCHITIETHOADON.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.cbMaHD.SelectedValue =
            dgvCHITIETHOADON.Rows[r].Cells[0].Value.ToString();
            this.cbMaSP.SelectedValue =
            dgvCHITIETHOADON.Rows[r].Cells[1].Value.ToString();
            this.txtSoLuong.Text =
            dgvCHITIETHOADON.Rows[r].Cells[2].Value.ToString();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.cbMaHD.Focus();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtSoLuong.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            conn.Open();
            try
            {
                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                // Lấy thứ tự record hiện hành
                int r = dgvCHITIETHOADON.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strMAHD =
                dgvCHITIETHOADON.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                cmd.CommandText = System.String.Concat("Delete From ChiTietHoaDon Where MaHD = '" + strMAHD + "'");
                cmd.CommandType = CommandType.Text;
                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã xóa xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
            // Đóng kết nối
            conn.Close();
        }
    }
}
