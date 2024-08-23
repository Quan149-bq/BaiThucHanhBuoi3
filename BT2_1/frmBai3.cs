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
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tu = txtTuMoi.Text;
            var nghia = txtNghia.Text;
            libDSTM.Items.Add(tu);
            list.Add(nghia);

            txtTuMoi.Focus();
            txtTuMoi.Text = "";
            txtNghia.Text = "";

            libDSTM.SelectedIndex = libDSTM.Items.Count - 1;
            txtHienNghia.Text = nghia;
        }

        private void libDSTM_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = libDSTM.SelectedIndex;
            txtHienNghia.Text = list[stt];
        }
    }
}
