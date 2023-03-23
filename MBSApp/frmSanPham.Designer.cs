
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbDMHoaDonBan = new System.Windows.Forms.Label();
            this.cboMaLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDMSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuuSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnTimKiemSP = new System.Windows.Forms.Button();
            this.btnHienThiSP = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
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
            this.cboMaLoaiSP.Location = new System.Drawing.Point(159, 147);
            this.cboMaLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaLoaiSP.Name = "cboMaLoaiSP";
            this.cboMaLoaiSP.Size = new System.Drawing.Size(216, 24);
            this.cboMaLoaiSP.TabIndex = 56;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(159, 110);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(216, 24);
            this.txtTenSP.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "Loại sản phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(159, 75);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(218, 24);
            this.txtMaSP.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 110);
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
            this.txtDonGiaBan.Location = new System.Drawing.Point(159, 183);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(218, 24);
            this.txtDonGiaBan.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Đơn giá bán:";
            // 
            // dgvDMSanPham
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDMSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDMSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.TenLoaiSP,
            this.DonVi,
            this.DonGia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDMSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDMSanPham.Location = new System.Drawing.Point(23, 241);
            this.dgvDMSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDMSanPham.Name = "dgvDMSanPham";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDMSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDMSanPham.RowHeadersWidth = 62;
            this.dgvDMSanPham.RowTemplate.Height = 28;
            this.dgvDMSanPham.Size = new System.Drawing.Size(1097, 290);
            this.dgvDMSanPham.TabIndex = 65;
            this.dgvDMSanPham.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDMSanPham_CellMouseClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 8;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 150;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 8;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 190;
            // 
            // TenLoaiSP
            // 
            this.TenLoaiSP.DataPropertyName = "TenLoaiSP";
            this.TenLoaiSP.HeaderText = "Loại sản phẩm";
            this.TenLoaiSP.MinimumWidth = 8;
            this.TenLoaiSP.Name = "TenLoaiSP";
            this.TenLoaiSP.Width = 150;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.MinimumWidth = 8;
            this.DonVi.Name = "DonVi";
            this.DonVi.Width = 130;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá bán";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Red;
            this.btnDong.Location = new System.Drawing.Point(1046, 590);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 36);
            this.btnDong.TabIndex = 66;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Location = new System.Drawing.Point(596, 590);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(86, 36);
            this.btnBoQua.TabIndex = 67;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            // 
            // btnLuuSP
            // 
            this.btnLuuSP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLuuSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuSP.Location = new System.Drawing.Point(474, 590);
            this.btnLuuSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuSP.Name = "btnLuuSP";
            this.btnLuuSP.Size = new System.Drawing.Size(86, 36);
            this.btnLuuSP.TabIndex = 68;
            this.btnLuuSP.Text = "Lưu SP";
            this.btnLuuSP.UseVisualStyleBackColor = false;
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSuaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSP.Location = new System.Drawing.Point(353, 590);
            this.btnSuaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(86, 36);
            this.btnSuaSP.TabIndex = 69;
            this.btnSuaSP.Text = "Sửa SP";
            this.btnSuaSP.UseVisualStyleBackColor = false;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.Location = new System.Drawing.Point(232, 590);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(86, 36);
            this.btnXoaSP.TabIndex = 70;
            this.btnXoaSP.Text = "Xóa SP";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.Location = new System.Drawing.Point(111, 590);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(86, 36);
            this.btnThemSP.TabIndex = 71;
            this.btnThemSP.Text = "Thêm SP";
            this.btnThemSP.UseVisualStyleBackColor = false;
            // 
            // btnTimKiemSP
            // 
            this.btnTimKiemSP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTimKiemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSP.Location = new System.Drawing.Point(704, 590);
            this.btnTimKiemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemSP.Name = "btnTimKiemSP";
            this.btnTimKiemSP.Size = new System.Drawing.Size(103, 36);
            this.btnTimKiemSP.TabIndex = 67;
            this.btnTimKiemSP.Text = "Tìm kiếm";
            this.btnTimKiemSP.UseVisualStyleBackColor = false;
            // 
            // btnHienThiSP
            // 
            this.btnHienThiSP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHienThiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiSP.Location = new System.Drawing.Point(828, 590);
            this.btnHienThiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHienThiSP.Name = "btnHienThiSP";
            this.btnHienThiSP.Size = new System.Drawing.Size(148, 36);
            this.btnHienThiSP.TabIndex = 72;
            this.btnHienThiSP.Text = "Hiển thị DSSP";
            this.btnHienThiSP.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(460, 77);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 41);
            this.btnThem.TabIndex = 73;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btXoa.Location = new System.Drawing.Point(608, 77);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 41);
            this.btXoa.TabIndex = 73;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLuu.Location = new System.Drawing.Point(756, 77);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 41);
            this.btnLuu.TabIndex = 73;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(460, 167);
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
            this.btnTimKiem.Location = new System.Drawing.Point(746, 160);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(122, 41);
            this.btnTimKiem.TabIndex = 73;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 635);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHienThiSP);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimKiemSP);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuuSP);
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.dgvDMSanPham);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaLoaiSP);
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
        private System.Windows.Forms.DataGridView dgvDMSanPham;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuuSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnTimKiemSP;
        private System.Windows.Forms.Button btnHienThiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
    }
}