using QuanLySieuThi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.View
{
    public partial class frmHangHoa : Form
    {
        BANHANGSIEUTHIEntities db = new BANHANGSIEUTHIEntities();

        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            FillData();
        }

        public void FillData()
        {
            this.dgvHanghoa.DataSource = db.HangHoas.ToList();
            this.dgvHanghoa.Columns[0].HeaderText = "Mã Hàng";
            this.dgvHanghoa.Columns[1].HeaderText = "Mã Loại";
            this.dgvHanghoa.Columns[2].HeaderText = "Tác Hàng";
            this.dgvHanghoa.Columns[3].HeaderText = "Đơn Vị Tính";
            this.dgvHanghoa.Columns[4].HeaderText = "Tên Nhà Sản Xuất";
            this.dgvHanghoa.Columns[5].HeaderText = "Giá Tiền";
            this.dgvHanghoa.Columns[6].HeaderText = "Trạng Thái";
        }

        private void dgvHanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String ma = this.dgvHanghoa.CurrentRow.Cells[0].Value.ToString();
            HangHoa h = db.HangHoas.Single(s => s.MaHang.Equals(ma));
            txtMahang.Text = h.MaHang.ToString();
            txtMaloai.Text = h.MaLoai.ToString();
            txtTenhang.Text = h.TenHang;
            cmbDonvitinh.Items.Clear();
            cmbDonvitinh.Items.Add("Lô");
            cmbDonvitinh.Items.Add("Cái");
            cmbDonvitinh.Items.Add("Gói");
            cmbDonvitinh.Items.Add("Bao");
            cmbDonvitinh.Items.Add("Hộp");
            txtTennhasanxuat.Text = h.TenNhaSanXuat;
            txtGia.Text = h.Gia.ToString();
            txtTrangthai.Text = h.Status.ToString();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa h = new HangHoa();
                h.MaHang = Int32.Parse(txtMahang.Text);
                h.MaLoai = Int32.Parse(txtMaloai.Text);
                h.TenHang = this.txtTenhang.Text;
                h.DonViTinh = this.cmbDonvitinh.Text;
                h.TenNhaSanXuat = this.txtTennhasanxuat.Text;
                h.Status = Int32.Parse(txtTrangthai.Text);
                db.HangHoas.Add(h);
                db.SaveChanges();
                FillData();
                MessageBox.Show("Thêm thành công!!");
            }
            catch
            {
                MessageBox.Show("Thêm không thành công!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                String ma = this.dgvHanghoa.CurrentRow.Cells[0].Value.ToString();
                HangHoa h = db.HangHoas.Single(s => s.MaHang.Equals(ma));
                h.MaHang = Int32.Parse(txtMahang.Text);
                h.MaLoai = Int32.Parse(txtMaloai.Text);
                if (this.txtTenhang.Text.Length != 0)
                    h.TenHang = this.txtTenhang.Text;
                if (this.txtTennhasanxuat.Text.Length != 0)
                    h.TenNhaSanXuat = this.txtTennhasanxuat.Text;
                h.Status = Int32.Parse(txtTrangthai.Text);
                db.SaveChanges();
                FillData();
                MessageBox.Show("Updte Success!!");
            }
            catch
            {
                MessageBox.Show("Update fail!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String ma = this.dgvHanghoa.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    HangHoa h = db.HangHoas.Single(s => s.MaHang.Equals(ma));
                    db.HangHoas.Remove(h);
                    db.SaveChanges();
                    FillData();
                    MessageBox.Show("Delete Success");
                }
                catch
                {
                    MessageBox.Show("Delete fail!!");
                }
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            BANHANGSIEUTHIEntities db = new BANHANGSIEUTHIEntities();
            var Lst = (from s in db.HangHoas where s.TenHang.Contains(txtTimkiem.Text) select s).ToList();
            dgvHanghoa.DataSource = Lst;
            txtMahang.DataBindings.Clear();
            txtMaloai.DataBindings.Clear();
            txtTenhang.DataBindings.Clear();
            cmbDonvitinh.DataBindings.Clear();
            txtTennhasanxuat.DataBindings.Clear();
            txtTrangthai.DataBindings.Clear();
            txtMahang.DataBindings.Add("text", Lst, "MaHang");
            txtMaloai.DataBindings.Add("text", Lst, "MaLoai");
            txtTenhang.DataBindings.Add("text", Lst, "TenHang");
            cmbDonvitinh.DataBindings.Add("text", Lst, "DonViTinh");
            txtTennhasanxuat.DataBindings.Add("text", Lst, "TenNhaSanXuat");
            txtTrangthai.DataBindings.Add("text", Lst, "TrangThai");
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmTrangChu f = new frmTrangChu();
            f.Show();
            this.Hide();
        }
    }
}
