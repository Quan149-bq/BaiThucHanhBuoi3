namespace Winform_Buoi3
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
            this.lblTenBan = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.btnTenBan = new System.Windows.Forms.Button();
            this.lblCopy = new System.Windows.Forms.Label();
            this.txtCopy = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Location = new System.Drawing.Point(31, 68);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(96, 13);
            this.lblTenBan.TabIndex = 0;
            this.lblTenBan.Text = "Nhập tên của bạn:";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(146, 65);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(157, 20);
            this.txtTenBan.TabIndex = 1;
            this.txtTenBan.TextChanged += new System.EventHandler(this.txtTenBan_TextChanged);
            // 
            // btnTenBan
            // 
            this.btnTenBan.Location = new System.Drawing.Point(356, 62);
            this.btnTenBan.Name = "btnTenBan";
            this.btnTenBan.Size = new System.Drawing.Size(75, 23);
            this.btnTenBan.TabIndex = 2;
            this.btnTenBan.Text = "Hiện";
            this.btnTenBan.UseVisualStyleBackColor = true;
            this.btnTenBan.Click += new System.EventHandler(this.btnTenBan_Click);
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(31, 146);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(72, 13);
            this.lblCopy.TabIndex = 3;
            this.lblCopy.Text = "Bạn đã nhập:";
            // 
            // txtCopy
            // 
            this.txtCopy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCopy.ForeColor = System.Drawing.Color.Wheat;
            this.txtCopy.Location = new System.Drawing.Point(146, 143);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.ReadOnly = true;
            this.txtCopy.Size = new System.Drawing.Size(157, 20);
            this.txtCopy.TabIndex = 4;
            this.txtCopy.TextChanged += new System.EventHandler(this.txtCopy_TextChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(356, 140);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Sao chép";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 327);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtCopy);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.btnTenBan);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.lblTenBan);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Button btnTenBan;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.TextBox txtCopy;
        private System.Windows.Forms.Button btnCopy;
    }
}

