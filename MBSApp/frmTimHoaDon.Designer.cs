
namespace MBSApp
{
    partial class frmTimHoaDon
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
            this.btnDong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHDThang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDMKhachHang = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtHDNam = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnTimHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Location = new System.Drawing.Point(523, 430);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(155, 46);
            this.btnDong.TabIndex = 45;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Năm:";
            // 
            // txtHDThang
            // 
            this.txtHDThang.Location = new System.Drawing.Point(188, 80);
            this.txtHDThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHDThang.Name = "txtHDThang";
            this.txtHDThang.Size = new System.Drawing.Size(71, 22);
            this.txtHDThang.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tháng:";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(188, 34);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(216, 22);
            this.txtMaHoaDon.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // dgvDMKhachHang
            // 
            this.dgvDMKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.MaNhanVien,
            this.NgayBan,
            this.MaKhachHang,
            this.TongTien});
            this.dgvDMKhachHang.Location = new System.Drawing.Point(44, 182);
            this.dgvDMKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDMKhachHang.Name = "dgvDMKhachHang";
            this.dgvDMKhachHang.ReadOnly = true;
            this.dgvDMKhachHang.RowHeadersWidth = 62;
            this.dgvDMKhachHang.RowTemplate.Height = 28;
            this.dgvDMKhachHang.Size = new System.Drawing.Size(786, 218);
            this.dgvDMKhachHang.TabIndex = 36;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã hóa đơn";
            this.MaHoaDon.MinimumWidth = 8;
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Width = 150;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 8;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 250;
            // 
            // NgayBan
            // 
            this.NgayBan.HeaderText = "Ngày bán";
            this.NgayBan.MinimumWidth = 8;
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.Width = 150;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.HeaderText = "Mã khách";
            this.MaKhachHang.MinimumWidth = 8;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Width = 150;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 150;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(617, 38);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(182, 22);
            this.txtMaKhachHang.TabIndex = 44;
            // 
            // txtHDNam
            // 
            this.txtHDNam.Location = new System.Drawing.Point(331, 82);
            this.txtHDNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHDNam.Name = "txtHDNam";
            this.txtHDNam.Size = new System.Drawing.Size(72, 22);
            this.txtHDNam.TabIndex = 44;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(188, 131);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(216, 22);
            this.txtMaNhanVien.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Mã nhân viên:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(617, 80);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(182, 22);
            this.txtTongTien.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tổng tiền:";
            // 
            // btnTimLai
            // 
            this.btnTimLai.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTimLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimLai.ForeColor = System.Drawing.Color.Red;
            this.btnTimLai.Location = new System.Drawing.Point(363, 430);
            this.btnTimLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(155, 46);
            this.btnTimLai.TabIndex = 45;
            this.btnTimLai.Text = "Tìm lại";
            this.btnTimLai.UseVisualStyleBackColor = false;
            // 
            // btnTimHD
            // 
            this.btnTimHD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTimHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimHD.ForeColor = System.Drawing.Color.Red;
            this.btnTimHD.Location = new System.Drawing.Point(203, 430);
            this.btnTimHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimHD.Name = "btnTimHD";
            this.btnTimHD.Size = new System.Drawing.Size(155, 46);
            this.btnTimHD.TabIndex = 45;
            this.btnTimHD.Text = "Tìm kiếm";
            this.btnTimHD.UseVisualStyleBackColor = false;
            // 
            // frmTimHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 502);
            this.Controls.Add(this.btnTimHD);
            this.Controls.Add(this.btnTimLai);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHDThang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHDNam);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDMKhachHang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTimHoaDon";
            this.Text = "Tìm kiếm hóa đơn ";
            this.Load += new System.EventHandler(this.frmTimHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHDThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDMKhachHang;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtHDNam;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btnTimHD;
    }
}