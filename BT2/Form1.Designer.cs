namespace BT2
{
    partial class Form1
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
            this.grbGioiTinh = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.grbChonMau = new System.Windows.Forms.GroupBox();
            this.btnToMau = new System.Windows.Forms.Button();
            this.rdMauXanh = new System.Windows.Forms.RadioButton();
            this.rdMauDo = new System.Windows.Forms.RadioButton();
            this.txtHopMau = new System.Windows.Forms.TextBox();
            this.grbGioiTinh.SuspendLayout();
            this.grbChonMau.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGioiTinh
            // 
            this.grbGioiTinh.Controls.Add(this.rdNu);
            this.grbGioiTinh.Controls.Add(this.rdNam);
            this.grbGioiTinh.Location = new System.Drawing.Point(63, 41);
            this.grbGioiTinh.Name = "grbGioiTinh";
            this.grbGioiTinh.Size = new System.Drawing.Size(200, 100);
            this.grbGioiTinh.TabIndex = 0;
            this.grbGioiTinh.TabStop = false;
            this.grbGioiTinh.Text = "Chọn giới tính";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(29, 64);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(29, 30);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // grbChonMau
            // 
            this.grbChonMau.Controls.Add(this.btnToMau);
            this.grbChonMau.Controls.Add(this.rdMauXanh);
            this.grbChonMau.Controls.Add(this.rdMauDo);
            this.grbChonMau.Location = new System.Drawing.Point(63, 181);
            this.grbChonMau.Name = "grbChonMau";
            this.grbChonMau.Size = new System.Drawing.Size(200, 100);
            this.grbChonMau.TabIndex = 1;
            this.grbChonMau.TabStop = false;
            this.grbChonMau.Text = "Chọn màu";
            // 
            // btnToMau
            // 
            this.btnToMau.Location = new System.Drawing.Point(118, 47);
            this.btnToMau.Name = "btnToMau";
            this.btnToMau.Size = new System.Drawing.Size(75, 23);
            this.btnToMau.TabIndex = 2;
            this.btnToMau.Text = "Tô";
            this.btnToMau.UseVisualStyleBackColor = true;
            this.btnToMau.Click += new System.EventHandler(this.btnToMau_Click);
            // 
            // rdMauXanh
            // 
            this.rdMauXanh.AutoSize = true;
            this.rdMauXanh.Location = new System.Drawing.Point(22, 64);
            this.rdMauXanh.Name = "rdMauXanh";
            this.rdMauXanh.Size = new System.Drawing.Size(72, 17);
            this.rdMauXanh.TabIndex = 1;
            this.rdMauXanh.Text = "Màu xanh";
            this.rdMauXanh.UseVisualStyleBackColor = true;
            // 
            // rdMauDo
            // 
            this.rdMauDo.AutoSize = true;
            this.rdMauDo.Checked = true;
            this.rdMauDo.Location = new System.Drawing.Point(22, 30);
            this.rdMauDo.Name = "rdMauDo";
            this.rdMauDo.Size = new System.Drawing.Size(62, 17);
            this.rdMauDo.TabIndex = 0;
            this.rdMauDo.TabStop = true;
            this.rdMauDo.Text = "Màu đỏ";
            this.rdMauDo.UseVisualStyleBackColor = true;
            // 
            // txtHopMau
            // 
            this.txtHopMau.Location = new System.Drawing.Point(330, 181);
            this.txtHopMau.Multiline = true;
            this.txtHopMau.Name = "txtHopMau";
            this.txtHopMau.Size = new System.Drawing.Size(142, 100);
            this.txtHopMau.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHopMau);
            this.Controls.Add(this.grbChonMau);
            this.Controls.Add(this.grbGioiTinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbGioiTinh.ResumeLayout(false);
            this.grbGioiTinh.PerformLayout();
            this.grbChonMau.ResumeLayout(false);
            this.grbChonMau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGioiTinh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.GroupBox grbChonMau;
        private System.Windows.Forms.RadioButton rdMauXanh;
        private System.Windows.Forms.RadioButton rdMauDo;
        private System.Windows.Forms.TextBox txtHopMau;
        private System.Windows.Forms.Button btnToMau;
    }
}

