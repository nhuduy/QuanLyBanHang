namespace QuanLyBanHang
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.imgDangNhap = new System.Windows.Forms.PictureBox();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.lbTendangnhap = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.lbMatkhau = new System.Windows.Forms.Label();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDangNhap
            // 
            this.imgDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("imgDangNhap.Image")));
            this.imgDangNhap.Location = new System.Drawing.Point(1, -3);
            this.imgDangNhap.Name = "imgDangNhap";
            this.imgDangNhap.Size = new System.Drawing.Size(579, 356);
            this.imgDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDangNhap.TabIndex = 0;
            this.imgDangNhap.TabStop = false;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(200, 444);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(340, 31);
            this.txtTendangnhap.TabIndex = 1;
            // 
            // lbTendangnhap
            // 
            this.lbTendangnhap.AutoSize = true;
            this.lbTendangnhap.Location = new System.Drawing.Point(23, 447);
            this.lbTendangnhap.Name = "lbTendangnhap";
            this.lbTendangnhap.Size = new System.Drawing.Size(157, 25);
            this.lbTendangnhap.TabIndex = 5;
            this.lbTendangnhap.Text = "Tên đăng nhập";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(200, 509);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(340, 31);
            this.txtMatkhau.TabIndex = 2;
            // 
            // lbMatkhau
            // 
            this.lbMatkhau.AutoSize = true;
            this.lbMatkhau.Location = new System.Drawing.Point(23, 512);
            this.lbMatkhau.Name = "lbMatkhau";
            this.lbMatkhau.Size = new System.Drawing.Size(101, 25);
            this.lbMatkhau.TabIndex = 5;
            this.lbMatkhau.Text = "Mật khẩu";
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(200, 574);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(155, 54);
            this.btnDangnhap.TabIndex = 3;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(385, 576);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(155, 52);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnThoat_Click);
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTieuDe.Location = new System.Drawing.Point(124, 373);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(340, 42);
            this.lbTieuDe.TabIndex = 6;
            this.lbTieuDe.Text = "Quản lý Bán Hàng";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 656);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.lbMatkhau);
            this.Controls.Add(this.lbTendangnhap);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTendangnhap);
            this.Controls.Add(this.imgDangNhap);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập vào hệ thống";
            ((System.ComponentModel.ISupportInitialize)(this.imgDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDangNhap;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.Label lbTendangnhap;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label lbMatkhau;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbTieuDe;
    }
}

