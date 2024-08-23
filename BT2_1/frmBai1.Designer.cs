namespace BT2_1
{
    partial class frmBai1
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
            this.ptbImg = new System.Windows.Forms.PictureBox();
            this.grbMauXe = new System.Windows.Forms.GroupBox();
            this.rdMauTrang = new System.Windows.Forms.RadioButton();
            this.rdMauDo = new System.Windows.Forms.RadioButton();
            this.rdMauXanh = new System.Windows.Forms.RadioButton();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImg)).BeginInit();
            this.grbMauXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbImg
            // 
            this.ptbImg.Image = global::BT2_1.Properties.Resources.Car2;
            this.ptbImg.Location = new System.Drawing.Point(25, 27);
            this.ptbImg.Name = "ptbImg";
            this.ptbImg.Size = new System.Drawing.Size(308, 163);
            this.ptbImg.TabIndex = 0;
            this.ptbImg.TabStop = false;
            // 
            // grbMauXe
            // 
            this.grbMauXe.Controls.Add(this.rdMauTrang);
            this.grbMauXe.Controls.Add(this.rdMauDo);
            this.grbMauXe.Controls.Add(this.rdMauXanh);
            this.grbMauXe.Location = new System.Drawing.Point(432, 27);
            this.grbMauXe.Name = "grbMauXe";
            this.grbMauXe.Size = new System.Drawing.Size(229, 153);
            this.grbMauXe.TabIndex = 1;
            this.grbMauXe.TabStop = false;
            this.grbMauXe.Text = "Chọn Màu Xe";
            // 
            // rdMauTrang
            // 
            this.rdMauTrang.AutoSize = true;
            this.rdMauTrang.Location = new System.Drawing.Point(25, 113);
            this.rdMauTrang.Name = "rdMauTrang";
            this.rdMauTrang.Size = new System.Drawing.Size(53, 17);
            this.rdMauTrang.TabIndex = 2;
            this.rdMauTrang.Text = "Trắng";
            this.rdMauTrang.UseVisualStyleBackColor = true;
            this.rdMauTrang.CheckedChanged += new System.EventHandler(this.rdMauTrang_CheckedChanged);
            // 
            // rdMauDo
            // 
            this.rdMauDo.AutoSize = true;
            this.rdMauDo.Location = new System.Drawing.Point(25, 70);
            this.rdMauDo.Name = "rdMauDo";
            this.rdMauDo.Size = new System.Drawing.Size(39, 17);
            this.rdMauDo.TabIndex = 1;
            this.rdMauDo.Text = "Đỏ";
            this.rdMauDo.UseVisualStyleBackColor = true;
            this.rdMauDo.CheckedChanged += new System.EventHandler(this.rdMauDo_CheckedChanged);
            // 
            // rdMauXanh
            // 
            this.rdMauXanh.AutoSize = true;
            this.rdMauXanh.Location = new System.Drawing.Point(25, 29);
            this.rdMauXanh.Name = "rdMauXanh";
            this.rdMauXanh.Size = new System.Drawing.Size(50, 17);
            this.rdMauXanh.TabIndex = 0;
            this.rdMauXanh.Text = "Xanh";
            this.rdMauXanh.UseVisualStyleBackColor = true;
            this.rdMauXanh.CheckedChanged += new System.EventHandler(this.rdMauXanh_CheckedChanged);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(432, 267);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(44, 13);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(491, 264);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(170, 20);
            this.txtDonGia.TabIndex = 3;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(678, 267);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(13, 13);
            this.lblMoney.TabIndex = 4;
            this.lblMoney.Text = "$";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(435, 302);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(49, 13);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(491, 302);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(170, 20);
            this.txtSoLuong.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tính tiền";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.Location = new System.Drawing.Point(340, 395);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(186, 20);
            this.lblText1.TabIndex = 8;
            this.lblText1.Text = "Tổng tiền thanh toán: ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(532, 395);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 20);
            this.lblTongTien.TabIndex = 9;
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.Location = new System.Drawing.Point(677, 395);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(19, 20);
            this.lblText2.TabIndex = 10;
            this.lblText2.Text = "$";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.grbMauXe);
            this.Controls.Add(this.ptbImg);
            this.Name = "frmBai1";
            this.Text = "Mua Bán Xe";
            ((System.ComponentModel.ISupportInitialize)(this.ptbImg)).EndInit();
            this.grbMauXe.ResumeLayout(false);
            this.grbMauXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbImg;
        private System.Windows.Forms.GroupBox grbMauXe;
        private System.Windows.Forms.RadioButton rdMauTrang;
        private System.Windows.Forms.RadioButton rdMauDo;
        private System.Windows.Forms.RadioButton rdMauXanh;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblText2;
    }
}