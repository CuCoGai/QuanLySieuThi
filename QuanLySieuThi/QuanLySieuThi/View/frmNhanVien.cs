using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi.Model;

namespace QuanLySieuThi.View
{
    public partial class frmNhanVien : Form
    {
        BANHANGSIEUTHIEntities1 db=new BANHANGSIEUTHIEntities1();
        public frmNhanVien()
        {
            InitializeComponent();
        }
    }
}
