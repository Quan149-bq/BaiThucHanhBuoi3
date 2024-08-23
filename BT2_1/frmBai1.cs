using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2_1
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void rdMauXanh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMauXanh.Checked)
                txtDonGia.Text = "22000";
        }

        private void rdMauDo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMauDo.Checked)
                txtDonGia.Text = "21000";
        }

        private void rdMauTrang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMauTrang.Checked)
                txtDonGia.Text = "20000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soTien = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
            lblTongTien.Text = soTien.ToString();
        }
    }
}
