namespace BT2_1
{
    partial class frmBai2
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.libDSHH = new System.Windows.Forms.ListBox();
            this.lblTextL = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTextR1 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnBoHang = new System.Windows.Forms.Button();
            this.libMHKM = new System.Windows.Forms.ListBox();
            this.lblTextR = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.btnChonHang);
            this.pnlLeft.Controls.Add(this.libDSHH);
            this.pnlLeft.Controls.Add(this.lblTextL);
            this.pnlLeft.Location = new System.Drawing.Point(13, 13);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(377, 425);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnChonHang
            // 
            this.btnChonHang.Location = new System.Drawing.Point(266, 179);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(92, 23);
            this.btnChonHang.TabIndex = 2;
            this.btnChonHang.Text = "Chọn hàng >>";
            this.btnChonHang.UseVisualStyleBackColor = true;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // libDSHH
            // 
            this.libDSHH.FormattingEnabled = true;
            this.libDSHH.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in",
            "USB Kingmax\t"});
            this.libDSHH.Location = new System.Drawing.Point(23, 74);
            this.libDSHH.Name = "libDSHH";
            this.libDSHH.Size = new System.Drawing.Size(224, 238);
            this.libDSHH.TabIndex = 1;
            // 
            // lblTextL
            // 
            this.lblTextL.AutoSize = true;
            this.lblTextL.Location = new System.Drawing.Point(89, 30);
            this.lblTextL.Name = "lblTextL";
            this.lblTextL.Size = new System.Drawing.Size(116, 13);
            this.lblTextL.TabIndex = 0;
            this.lblTextL.Text = "Danh Sách Hàng Hóa:";
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.lblTongTien);
            this.pnlRight.Controls.Add(this.lblTextR1);
            this.pnlRight.Controls.Add(this.btnTinhTien);
            this.pnlRight.Controls.Add(this.btnBoHang);
            this.pnlRight.Controls.Add(this.libMHKM);
            this.pnlRight.Controls.Add(this.lblTextR);
            this.pnlRight.Location = new System.Drawing.Point(397, 13);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(391, 425);
            this.pnlRight.TabIndex = 1;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Blue;
            this.lblTongTien.Location = new System.Drawing.Point(209, 379);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 20);
            this.lblTongTien.TabIndex = 5;
            // 
            // lblTextR1
            // 
            this.lblTextR1.AutoSize = true;
            this.lblTextR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextR1.Location = new System.Drawing.Point(22, 379);
            this.lblTextR1.Name = "lblTextR1";
            this.lblTextR1.Size = new System.Drawing.Size(181, 20);
            this.lblTextR1.TabIndex = 4;
            this.lblTextR1.Text = "Tổng tiền thanh toán:";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(213, 330);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 3;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnBoHang
            // 
            this.btnBoHang.Location = new System.Drawing.Point(29, 179);
            this.btnBoHang.Name = "btnBoHang";
            this.btnBoHang.Size = new System.Drawing.Size(75, 23);
            this.btnBoHang.TabIndex = 2;
            this.btnBoHang.Text = "<< Bỏ hàng";
            this.btnBoHang.UseVisualStyleBackColor = true;
            this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
            // 
            // libMHKM
            // 
            this.libMHKM.FormattingEnabled = true;
            this.libMHKM.Location = new System.Drawing.Point(126, 74);
            this.libMHKM.Name = "libMHKM";
            this.libMHKM.Size = new System.Drawing.Size(245, 238);
            this.libMHKM.TabIndex = 1;
            // 
            // lblTextR
            // 
            this.lblTextR.AutoSize = true;
            this.lblTextR.Location = new System.Drawing.Point(172, 30);
            this.lblTextR.Name = "lblTextR";
            this.lblTextR.Size = new System.Drawing.Size(132, 13);
            this.lblTextR.TabIndex = 0;
            this.lblTextR.Text = "Các mặt hàng khách mua:";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "frmBai2";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.frmBai2_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.ListBox libDSHH;
        private System.Windows.Forms.Label lblTextL;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblTextR;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.Button btnBoHang;
        private System.Windows.Forms.ListBox libMHKM;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTextR1;
        private System.Windows.Forms.Button btnTinhTien;
    }
}