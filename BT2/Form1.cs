﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
            MessageBox.Show("Bạn chọn giới tính Nam", "Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNu.Checked)
            MessageBox.Show("Bạn chọn giới tính Nữ", "Thông báo");
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if(rdMauDo.Checked)
                txtHopMau.BackColor = Color.Red;
            else if(rdMauXanh.Checked)
                txtHopMau.BackColor = Color.Blue;
        }
    }
}
