﻿namespace QuanLySieuThi.View
{
    partial class frmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.grbThongtinhanghoa = new System.Windows.Forms.GroupBox();
            this.dtpHansudung = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaysanxuat = new System.Windows.Forms.DateTimePicker();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTennhasanxuat = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.txtMaloai = new System.Windows.Forms.TextBox();
            this.lbSoluong = new System.Windows.Forms.Label();
            this.lbHansudung = new System.Windows.Forms.Label();
            this.lbNgaysx = new System.Windows.Forms.Label();
            this.lbTrangthai = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbTennhasanxuat = new System.Windows.Forms.Label();
            this.lbDonvitinh = new System.Windows.Forms.Label();
            this.lbTenhang = new System.Windows.Forms.Label();
            this.lbMahang = new System.Windows.Forms.Label();
            this.lbMaloai = new System.Windows.Forms.Label();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.dgvHanghoa = new System.Windows.Forms.DataGridView();
            this.cmbDonvitinh = new System.Windows.Forms.ComboBox();
            this.grbThongtinhanghoa.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(99, 199);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 31);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(262, 199);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 31);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(433, 199);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 31);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(605, 199);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 31);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(99, 19);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(100, 31);
            this.btnTimkiem.TabIndex = 24;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(223, 25);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(388, 20);
            this.txtTimkiem.TabIndex = 25;
            // 
            // grbThongtinhanghoa
            // 
            this.grbThongtinhanghoa.Controls.Add(this.cmbDonvitinh);
            this.grbThongtinhanghoa.Controls.Add(this.dtpHansudung);
            this.grbThongtinhanghoa.Controls.Add(this.dtpNgaysanxuat);
            this.grbThongtinhanghoa.Controls.Add(this.txtSoluong);
            this.grbThongtinhanghoa.Controls.Add(this.btnThoat);
            this.grbThongtinhanghoa.Controls.Add(this.txtTrangthai);
            this.grbThongtinhanghoa.Controls.Add(this.btnXoa);
            this.grbThongtinhanghoa.Controls.Add(this.txtGia);
            this.grbThongtinhanghoa.Controls.Add(this.btnSua);
            this.grbThongtinhanghoa.Controls.Add(this.txtTennhasanxuat);
            this.grbThongtinhanghoa.Controls.Add(this.btnThem);
            this.grbThongtinhanghoa.Controls.Add(this.txtTenhang);
            this.grbThongtinhanghoa.Controls.Add(this.txtMahang);
            this.grbThongtinhanghoa.Controls.Add(this.txtMaloai);
            this.grbThongtinhanghoa.Controls.Add(this.lbSoluong);
            this.grbThongtinhanghoa.Controls.Add(this.lbHansudung);
            this.grbThongtinhanghoa.Controls.Add(this.lbNgaysx);
            this.grbThongtinhanghoa.Controls.Add(this.lbTrangthai);
            this.grbThongtinhanghoa.Controls.Add(this.lbGia);
            this.grbThongtinhanghoa.Controls.Add(this.lbTennhasanxuat);
            this.grbThongtinhanghoa.Controls.Add(this.lbDonvitinh);
            this.grbThongtinhanghoa.Controls.Add(this.lbTenhang);
            this.grbThongtinhanghoa.Controls.Add(this.lbMahang);
            this.grbThongtinhanghoa.Controls.Add(this.lbMaloai);
            this.grbThongtinhanghoa.Location = new System.Drawing.Point(4, 5);
            this.grbThongtinhanghoa.Name = "grbThongtinhanghoa";
            this.grbThongtinhanghoa.Size = new System.Drawing.Size(858, 261);
            this.grbThongtinhanghoa.TabIndex = 26;
            this.grbThongtinhanghoa.TabStop = false;
            this.grbThongtinhanghoa.Text = "Thông Tin Hàng Hóa";
            // 
            // dtpHansudung
            // 
            this.dtpHansudung.Location = new System.Drawing.Point(570, 114);
            this.dtpHansudung.Name = "dtpHansudung";
            this.dtpHansudung.Size = new System.Drawing.Size(222, 20);
            this.dtpHansudung.TabIndex = 39;
            // 
            // dtpNgaysanxuat
            // 
            this.dtpNgaysanxuat.Location = new System.Drawing.Point(570, 85);
            this.dtpNgaysanxuat.Name = "dtpNgaysanxuat";
            this.dtpNgaysanxuat.Size = new System.Drawing.Size(222, 20);
            this.dtpNgaysanxuat.TabIndex = 38;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(570, 148);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(222, 20);
            this.txtSoluong.TabIndex = 37;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(570, 56);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(222, 20);
            this.txtTrangthai.TabIndex = 36;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(570, 27);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(222, 20);
            this.txtGia.TabIndex = 35;
            // 
            // txtTennhasanxuat
            // 
            this.txtTennhasanxuat.Location = new System.Drawing.Point(181, 148);
            this.txtTennhasanxuat.Name = "txtTennhasanxuat";
            this.txtTennhasanxuat.Size = new System.Drawing.Size(222, 20);
            this.txtTennhasanxuat.TabIndex = 34;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(181, 88);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(222, 20);
            this.txtTenhang.TabIndex = 32;
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(181, 56);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(222, 20);
            this.txtMahang.TabIndex = 31;
            // 
            // txtMaloai
            // 
            this.txtMaloai.Location = new System.Drawing.Point(181, 27);
            this.txtMaloai.Name = "txtMaloai";
            this.txtMaloai.Size = new System.Drawing.Size(222, 20);
            this.txtMaloai.TabIndex = 30;
            // 
            // lbSoluong
            // 
            this.lbSoluong.AutoSize = true;
            this.lbSoluong.Location = new System.Drawing.Point(480, 151);
            this.lbSoluong.Name = "lbSoluong";
            this.lbSoluong.Size = new System.Drawing.Size(53, 13);
            this.lbSoluong.TabIndex = 29;
            this.lbSoluong.Text = "Số Lượng";
            // 
            // lbHansudung
            // 
            this.lbHansudung.AutoSize = true;
            this.lbHansudung.Location = new System.Drawing.Point(480, 120);
            this.lbHansudung.Name = "lbHansudung";
            this.lbHansudung.Size = new System.Drawing.Size(72, 13);
            this.lbHansudung.TabIndex = 28;
            this.lbHansudung.Text = "Hạn Sử Dụng";
            // 
            // lbNgaysx
            // 
            this.lbNgaysx.AutoSize = true;
            this.lbNgaysx.Location = new System.Drawing.Point(480, 91);
            this.lbNgaysx.Name = "lbNgaysx";
            this.lbNgaysx.Size = new System.Drawing.Size(79, 13);
            this.lbNgaysx.TabIndex = 27;
            this.lbNgaysx.Text = "Ngày Sản Xuất";
            // 
            // lbTrangthai
            // 
            this.lbTrangthai.AutoSize = true;
            this.lbTrangthai.Location = new System.Drawing.Point(480, 59);
            this.lbTrangthai.Name = "lbTrangthai";
            this.lbTrangthai.Size = new System.Drawing.Size(59, 13);
            this.lbTrangthai.TabIndex = 26;
            this.lbTrangthai.Text = "Trạng Thái";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(480, 30);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(23, 13);
            this.lbGia.TabIndex = 25;
            this.lbGia.Text = "Giá";
            // 
            // lbTennhasanxuat
            // 
            this.lbTennhasanxuat.AutoSize = true;
            this.lbTennhasanxuat.Location = new System.Drawing.Point(68, 151);
            this.lbTennhasanxuat.Name = "lbTennhasanxuat";
            this.lbTennhasanxuat.Size = new System.Drawing.Size(96, 13);
            this.lbTennhasanxuat.TabIndex = 24;
            this.lbTennhasanxuat.Text = "Tên Nhà Sản Xuất";
            // 
            // lbDonvitinh
            // 
            this.lbDonvitinh.AutoSize = true;
            this.lbDonvitinh.Location = new System.Drawing.Point(68, 120);
            this.lbDonvitinh.Name = "lbDonvitinh";
            this.lbDonvitinh.Size = new System.Drawing.Size(65, 13);
            this.lbDonvitinh.TabIndex = 23;
            this.lbDonvitinh.Text = "Đơn Vị Tính";
            // 
            // lbTenhang
            // 
            this.lbTenhang.AutoSize = true;
            this.lbTenhang.Location = new System.Drawing.Point(68, 91);
            this.lbTenhang.Name = "lbTenhang";
            this.lbTenhang.Size = new System.Drawing.Size(55, 13);
            this.lbTenhang.TabIndex = 22;
            this.lbTenhang.Text = "Tên Hàng";
            // 
            // lbMahang
            // 
            this.lbMahang.AutoSize = true;
            this.lbMahang.Location = new System.Drawing.Point(68, 59);
            this.lbMahang.Name = "lbMahang";
            this.lbMahang.Size = new System.Drawing.Size(51, 13);
            this.lbMahang.TabIndex = 21;
            this.lbMahang.Text = "Mã Hàng";
            // 
            // lbMaloai
            // 
            this.lbMaloai.AutoSize = true;
            this.lbMaloai.Location = new System.Drawing.Point(68, 30);
            this.lbMaloai.Name = "lbMaloai";
            this.lbMaloai.Size = new System.Drawing.Size(45, 13);
            this.lbMaloai.TabIndex = 20;
            this.lbMaloai.Text = "Mã Loại";
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.dgvHanghoa);
            this.grbTimKiem.Controls.Add(this.btnTimkiem);
            this.grbTimKiem.Controls.Add(this.txtTimkiem);
            this.grbTimKiem.Location = new System.Drawing.Point(4, 272);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(858, 259);
            this.grbTimKiem.TabIndex = 27;
            this.grbTimKiem.TabStop = false;
            // 
            // dgvHanghoa
            // 
            this.dgvHanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanghoa.Location = new System.Drawing.Point(27, 56);
            this.dgvHanghoa.Name = "dgvHanghoa";
            this.dgvHanghoa.Size = new System.Drawing.Size(821, 194);
            this.dgvHanghoa.TabIndex = 26;
            // 
            // cmbDonvitinh
            // 
            this.cmbDonvitinh.FormattingEnabled = true;
            this.cmbDonvitinh.Location = new System.Drawing.Point(181, 115);
            this.cmbDonvitinh.Name = "cmbDonvitinh";
            this.cmbDonvitinh.Size = new System.Drawing.Size(221, 21);
            this.cmbDonvitinh.TabIndex = 40;
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(864, 532);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.grbThongtinhanghoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHangHoa";
            this.Text = "QUẢN LÝ HÀNG HÓA";
            this.grbThongtinhanghoa.ResumeLayout(false);
            this.grbThongtinhanghoa.PerformLayout();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.GroupBox grbThongtinhanghoa;
        private System.Windows.Forms.ComboBox cmbDonvitinh;
        private System.Windows.Forms.DateTimePicker dtpHansudung;
        private System.Windows.Forms.DateTimePicker dtpNgaysanxuat;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTennhasanxuat;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.TextBox txtMaloai;
        private System.Windows.Forms.Label lbSoluong;
        private System.Windows.Forms.Label lbHansudung;
        private System.Windows.Forms.Label lbNgaysx;
        private System.Windows.Forms.Label lbTrangthai;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbTennhasanxuat;
        private System.Windows.Forms.Label lbDonvitinh;
        private System.Windows.Forms.Label lbTenhang;
        private System.Windows.Forms.Label lbMahang;
        private System.Windows.Forms.Label lbMaloai;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.DataGridView dgvHanghoa;
    }
}