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
    public partial class Form7 : Form
    {
        // Chuỗi kết nối
        string strConnectionString = "Data Source=DESKTOP-C6NONEG;Initial Catalog=QuanLyBanHang;Integrated Security = True";
        // Đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtKhachHang
        SqlDataAdapter daSanPham = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtSanPham = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        void LoadData()
        {

            try
            {
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu vào DataTable dtKhachHang
                daSanPham = new SqlDataAdapter("SELECT MaSP ,TenSP ,DonViTinh ,DonGia, Hinh FROM SANPHAM", conn);
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                daSanPham.Fill(dtSanPham);
                // Đưa dữ liệu lên DataGridView
                dgvSANPHAM.DataSource = dtSanPham;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table SANPHAM.Lỗi rồi!!!");
            }
        }
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            //  dtKhachHang.Dispose();
            //  dtKhachHang = null;
            dtSanPham.Dispose();
            dtSanPham = null;
            // Hủy kết nối
            conn = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaSP.ResetText();
            this.txtTenSP.ResetText();
            this.txtDonViTinh.ResetText();
            this.txtDonGia.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến TextField txtThanhPho
            this.txtMaSP.Focus();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            // Thứ tự dòng hiện hành
            int r = dgvSANPHAM.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaSP.Text =
            dgvSANPHAM.Rows[r].Cells[0].Value.ToString();
            this.txtTenSP.Text =
            dgvSANPHAM.Rows[r].Cells[1].Value.ToString();
            this.txtDonViTinh.Text =
            dgvSANPHAM.Rows[r].Cells[2].Value.ToString();
            this.txtDonGia.Text =
            dgvSANPHAM.Rows[r].Cells[3].Value.ToString();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến TextField txtMaNV
            this.txtMaSP.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            conn.Open();
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Lệnh Insert InTo
                    cmd.CommandText = System.String.Concat("Insert Into SanPham(MaSP ,TenSP ,DonViTinh ,DonGia) Values(" + "'" +
                    this.txtMaSP.Text.ToString() + "','" +
                    this.txtTenSP.Text.ToString() + "','" +
                    this.txtDonViTinh.Text.ToString() + "','" +
                    float.Parse(this.txtDonGia.Text.ToString()) + "')");
                   // cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            if (!Them)
            {
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Thứ tự dòng hiện hành
                    int r = dgvSANPHAM.CurrentCell.RowIndex;
                    // MaKH hiện hành
                    string strMASP =
                    dgvSANPHAM.Rows[r].Cells[0].Value.ToString();
                    // Câu lệnh SQL
                    cmd.CommandText = System.String.Concat("Update SanPham Set MaSP = '" +
                    this.txtMaSP.Text.ToString() + "', TenSP ='"
                    + this.txtTenSP.Text.ToString() + "',DonViTinh = '" +
                    this.txtDonViTinh.Text.ToString() + "', DonGia = '" +
                    "' Where MaSP = '" + strMASP + "'");
                    // Cập nhật
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!");
                }
            }
            // Đóng kết nối
            conn.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtMaSP.ResetText();
            this.txtTenSP.ResetText();
            this.txtDonViTinh.ResetText();
            this.txtDonGia.ResetText();
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
                int r = dgvSANPHAM.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strMASP =
                dgvSANPHAM.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                cmd.CommandText = System.String.Concat("Delete From SanPham Where MaSP = '" + strMASP + "'");
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

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
