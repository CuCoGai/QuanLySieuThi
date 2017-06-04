using QuanLySieuThi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.dgvHanghoa.Columns[1].HeaderText = "Mã loại";
            this.dgvHanghoa.Columns[2].HeaderText = "Tên Hàng";
            this.dgvHanghoa.Columns[3].HeaderText = "Đơn Vị Tính";
            this.dgvHanghoa.Columns[4].HeaderText = "Tên Nhà Xuất Bản";
            this.dgvHanghoa.Columns[5].HeaderText = "Giá Sỉ";
            this.dgvHanghoa.Columns[6].HeaderText = "Giá bán";
            this.dgvHanghoa.Columns[7].HeaderText = "Trạng Thái";
            this.dgvHanghoa.Columns[8].HeaderText = "Ngày Sản Xuất";
            this.dgvHanghoa.Columns[9].HeaderText = "Hạn Sử Dụng";
            this.dgvHanghoa.Columns[10].HeaderText = "Số Lượng";
        }

        private void dgvHanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String ma = this.dgvHanghoa.CurrentRow.Cells[0].Value.ToString();
            HangHoa h= db.HangHoas.Single(s => s.MaHang.Equals(ma));
            txtMahang.Text = h.MaHang.ToString();
            txtMaloai.Text = h.MaLoai.ToString();
            txtTenhang.Text = h.TenHang;
            cmbDonvitinh.Items.Clear();
            cmbDonvitinh.Items.Add("Bao");
            cmbDonvitinh.Items.Add("Hộp");
            cmbDonvitinh.Items.Add("Gói");
            cmbDonvitinh.Items.Add("Túi");
            cmbDonvitinh.Items.Add("Vỉ");
            cmbDonvitinh.Items.Add("Cái");
            txtTennhasanxuat.Text = h.TenNhaSanXuat;
            txtGiasi.Text = h.GiaSi.ToString();
            txtGiaban.Text = h.Gia.ToString();
            txtTrangthai.Text = h.Status.ToString();
            dtpNgaysanxuat.Text = h.NgaySx.ToString();
            dtpHansudung.Text = h.HanSd.ToString();
            txtSoluong.Text = h.SoLuong.ToString();
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
                h.GiaSi = decimal.Parse(txtGiasi.Text);
                h.Gia = decimal.Parse(txtGiaban.Text);
                h.Status = Int32.Parse(txtTrangthai.Text);
                h.NgaySx = DateTime.Parse(dtpNgaysanxuat.Text);
                h.HanSd = DateTime.Parse(dtpHansudung.Text);
                h.SoLuong = Int32.Parse(txtSoluong.Text);
                db.HangHoas.Add(h);
               db.SaveChanges();
                FillData();
                MessageBox.Show("Insert Success!!!");
            }
            catch
            {
                MessageBox.Show("Insert fail!!");
            }
        }

       
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                String ma = this.dgvHanghoa.CurrentRow.Cells[0].Value.ToString();
                HangHoa h = db.HangHoas.Single(s => s.MaHang.Equals(ma));
                if (this.txtMahang.Text.Length != 0)
                    h.MaHang = Int32.Parse(txtMahang.Text);
                if (this.txtMaloai.Text.Length != 0)
                    h.MaLoai = Int32.Parse(txtMaloai.Text);
                if (this.txtTenhang.Text.Length != 0)
                    h.TenHang = this.txtTenhang.Text;
                h.DonViTinh = this.cmbDonvitinh.Text;
                if (this.txtTennhasanxuat.Text.Length != 0)
                    h.TenNhaSanXuat = this.txtTennhasanxuat.Text;
                if(this.txtGiasi.Text.Length!=0)
                    h.GiaSi = decimal.Parse(txtGiasi.Text);
                if(this.txtGiaban.Text.Length!=0)
                    h.Gia= decimal.Parse(txtGiaban.Text);
                if (this.txtTrangthai.Text.Length != 0)
                    h.Status = Int32.Parse(txtTrangthai.Text);
                if (this.dtpNgaysanxuat.Text.Length != 0)
                    h.NgaySx = DateTime.Parse(dtpNgaysanxuat.Text);
                if (this.dtpHansudung.Text.Length != 0)
                    h.HanSd = DateTime.Parse(dtpHansudung.Text);
                if (this.txtSoluong.Text.Length!=0)
                    h.SoLuong = Int32.Parse(txtSoluong.Text);
                db.SaveChanges();
                FillData();
                MessageBox.Show("Fix Success!!");
            }
            catch
            {
                MessageBox.Show("Fix fail!!");
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmTrangChu f = new frmTrangChu();
            f.Show();
            this.Hide();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            BANHANGSIEUTHIEntities db = new BANHANGSIEUTHIEntities();
            var Lst = (from s in db.HangHoas where s.TenHang.Contains(txtTimkiem.Text) select s).ToList();
            dgvHanghoa.DataSource = Lst;
            txtMahang.DataBindings.Clear();
            txtMaloai.DataBindings.Clear();
            txtTenhang.DataBindings.Clear();
            txtTennhasanxuat.DataBindings.Clear();
            txtTrangthai.DataBindings.Clear();
            txtMahang.DataBindings.Add("text", Lst, "MaHang");
            txtMaloai.DataBindings.Add("text", Lst, "MaLoai");
            txtTenhang.DataBindings.Add("text", Lst, "TenHang");
            txtTennhasanxuat.DataBindings.Add("text", Lst, "TenNhaSanXuat");
            txtTrangthai.DataBindings.Add("text", Lst, "Status");
            
        }

        
    }
}
