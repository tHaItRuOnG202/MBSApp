
namespace MBSApp
{
    partial class frmSanPham
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
            this.lbDMHoaDonBan = new System.Windows.Forms.Label();
            this.cboMaLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuuSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaGiamGia = new System.Windows.Forms.ComboBox();
            this.dgvDMSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDMHoaDonBan
            // 
            this.lbDMHoaDonBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDMHoaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDMHoaDonBan.ForeColor = System.Drawing.Color.Blue;
            this.lbDMHoaDonBan.Location = new System.Drawing.Point(0, 0);
            this.lbDMHoaDonBan.Name = "lbDMHoaDonBan";
            this.lbDMHoaDonBan.Size = new System.Drawing.Size(1166, 55);
            this.lbDMHoaDonBan.TabIndex = 19;
            this.lbDMHoaDonBan.Text = "DANH MỤC SẢN PHẨM";
            this.lbDMHoaDonBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboMaLoaiSP
            // 
            this.cboMaLoaiSP.FormattingEnabled = true;
            this.cboMaLoaiSP.Location = new System.Drawing.Point(162, 160);
            this.cboMaLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaLoaiSP.Name = "cboMaLoaiSP";
            this.cboMaLoaiSP.Size = new System.Drawing.Size(216, 24);
            this.cboMaLoaiSP.TabIndex = 56;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(162, 115);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(216, 24);
            this.txtTenSP.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "Loại sản phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(159, 70);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(218, 24);
            this.txtMaSP.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "Tên sản phẩm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Mã sản phẩm:";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaBan.Location = new System.Drawing.Point(616, 115);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(218, 24);
            this.txtDonGiaBan.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Đơn giá bán:";
            // 
            // btnLuuSP
            // 
            this.btnLuuSP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLuuSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuSP.Location = new System.Drawing.Point(535, 570);
            this.btnLuuSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuSP.Name = "btnLuuSP";
            this.btnLuuSP.Size = new System.Drawing.Size(86, 36);
            this.btnLuuSP.TabIndex = 68;
            this.btnLuuSP.Text = "Lưu";
            this.btnLuuSP.UseVisualStyleBackColor = false;
            this.btnLuuSP.Click += new System.EventHandler(this.btnLuuSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSuaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSP.Location = new System.Drawing.Point(426, 570);
            this.btnSuaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(86, 36);
            this.btnSuaSP.TabIndex = 69;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = false;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.Location = new System.Drawing.Point(304, 570);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(86, 36);
            this.btnXoaSP.TabIndex = 70;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(651, 577);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(248, 24);
            this.txtTimKiem.TabIndex = 55;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimKiem.Location = new System.Drawing.Point(932, 565);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 41);
            this.btnTimKiem.TabIndex = 73;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 57;
            this.label2.Text = "Đơn vị:";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(616, 75);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(218, 24);
            this.txtDonVi.TabIndex = 59;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(188, 570);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 36);
            this.btnThem.TabIndex = 70;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Giảm giá:";
            // 
            // cbMaGiamGia
            // 
            this.cbMaGiamGia.FormattingEnabled = true;
            this.cbMaGiamGia.Location = new System.Drawing.Point(618, 163);
            this.cbMaGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaGiamGia.Name = "cbMaGiamGia";
            this.cbMaGiamGia.Size = new System.Drawing.Size(216, 24);
            this.cbMaGiamGia.TabIndex = 56;
            // 
            // dgvDMSanPham
            // 
            this.dgvDMSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.TenLoaiSP,
            this.DonVi,
            this.DonGia,
            this.GiamGia});
            this.dgvDMSanPham.Location = new System.Drawing.Point(35, 251);
            this.dgvDMSanPham.Name = "dgvDMSanPham";
            this.dgvDMSanPham.RowHeadersWidth = 51;
            this.dgvDMSanPham.RowTemplate.Height = 24;
            this.dgvDMSanPham.Size = new System.Drawing.Size(1103, 271);
            this.dgvDMSanPham.TabIndex = 74;
            this.dgvDMSanPham.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDMSanPham_CellMouseClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 125;
            // 
            // TenLoaiSP
            // 
            this.TenLoaiSP.DataPropertyName = "TenLoaiSP";
            this.TenLoaiSP.HeaderText = "Loại sản phẩm";
            this.TenLoaiSP.MinimumWidth = 6;
            this.TenLoaiSP.Name = "TenLoaiSP";
            this.TenLoaiSP.Width = 125;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.MinimumWidth = 6;
            this.DonVi.Name = "DonVi";
            this.DonVi.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "GiamGia";
            this.GiamGia.HeaderText = "Giảm giá";
            this.GiamGia.MinimumWidth = 6;
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.Width = 125;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 635);
            this.Controls.Add(this.dgvDMSanPham);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLuuSP);
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMaGiamGia);
            this.Controls.Add(this.cboMaLoaiSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDMHoaDonBan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSanPham";
            this.Text = "Danh mục sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDMHoaDonBan;
        private System.Windows.Forms.ComboBox cboMaLoaiSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuuSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaGiamGia;
        private System.Windows.Forms.DataGridView dgvDMSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
    }
}