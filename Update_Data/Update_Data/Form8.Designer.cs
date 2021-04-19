
namespace Update_Data
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.timeHD = new System.Windows.Forms.DateTimePicker();
            this.timeNhanHang = new System.Windows.Forms.DateTimePicker();
            this.panel = new System.Windows.Forms.Panel();
            this.cbNV = new System.Windows.Forms.ComboBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.dgvHOADON = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HDtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanHangtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOADON)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã KH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã NV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày lập HĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày nhận hàng";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(68, 16);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(173, 22);
            this.txtMaHD.TabIndex = 5;
            // 
            // timeHD
            // 
            this.timeHD.Location = new System.Drawing.Point(538, 21);
            this.timeHD.Name = "timeHD";
            this.timeHD.Size = new System.Drawing.Size(200, 22);
            this.timeHD.TabIndex = 8;
            // 
            // timeNhanHang
            // 
            this.timeNhanHang.Location = new System.Drawing.Point(538, 110);
            this.timeNhanHang.Name = "timeNhanHang";
            this.timeNhanHang.Size = new System.Drawing.Size(200, 22);
            this.timeNhanHang.TabIndex = 9;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cbNV);
            this.panel.Controls.Add(this.cbMaKH);
            this.panel.Controls.Add(this.timeNhanHang);
            this.panel.Controls.Add(this.timeHD);
            this.panel.Controls.Add(this.txtMaHD);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(5, 6);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(771, 153);
            this.panel.TabIndex = 0;
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(68, 108);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(180, 24);
            this.cbNV.TabIndex = 11;
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(68, 63);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(264, 24);
            this.cbMaKH.TabIndex = 10;
            // 
            // dgvHOADON
            // 
            this.dgvHOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHOADON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.MaNV,
            this.HDtime,
            this.NhanHangtime});
            this.dgvHOADON.Location = new System.Drawing.Point(7, 165);
            this.dgvHOADON.Name = "dgvHOADON";
            this.dgvHOADON.RowHeadersWidth = 51;
            this.dgvHOADON.RowTemplate.Height = 24;
            this.dgvHOADON.Size = new System.Drawing.Size(770, 195);
            this.dgvHOADON.TabIndex = 1;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã HĐ";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 125;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "TenCty";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // HDtime
            // 
            this.HDtime.DataPropertyName = "NgayLapHD";
            this.HDtime.HeaderText = "Ngày lập HĐ";
            this.HDtime.MinimumWidth = 6;
            this.HDtime.Name = "HDtime";
            this.HDtime.Width = 150;
            // 
            // NhanHangtime
            // 
            this.NhanHangtime.DataPropertyName = "NgayNhanHang";
            this.NhanHangtime.HeaderText = "Ngày Nhận hàng";
            this.NhanHangtime.MinimumWidth = 6;
            this.NhanHangtime.Name = "NhanHangtime";
            this.NhanHangtime.Width = 150;
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTroVe.Location = new System.Drawing.Point(682, 366);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(95, 32);
            this.btnTroVe.TabIndex = 15;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(572, 366);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 32);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHuyBo.Location = new System.Drawing.Point(463, 366);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(89, 32);
            this.btnHuyBo.TabIndex = 13;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuu.Location = new System.Drawing.Point(353, 366);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 32);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Location = new System.Drawing.Point(237, 366);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 32);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Location = new System.Drawing.Point(128, 366);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 32);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReload.Location = new System.Drawing.Point(8, 366);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(89, 32);
            this.btnReload.TabIndex = 9;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 406);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvHOADON);
            this.Controls.Add(this.panel);
            this.Name = "Form8";
            this.Text = "Form8";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOADON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DateTimePicker timeHD;
        private System.Windows.Forms.DateTimePicker timeNhanHang;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox cbNV;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.DataGridView dgvHOADON;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanHangtime;
    }
}