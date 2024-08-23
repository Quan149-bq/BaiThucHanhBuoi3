using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTenBan_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTenBan.Text;
            MessageBox.Show($"Chào bạn {tenDaNhap}, Rất vui được gặp bạn!");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            txtCopy.Text = txtTenBan.Text;
        }

        

        private void txtTenBan_TextChanged(object sender, EventArgs e)
        {
            txtCopy.Text = txtTenBan.Text;
        }

        private void txtCopy_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
