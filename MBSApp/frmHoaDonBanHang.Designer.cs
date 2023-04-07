
namespace MBSApp
{
    partial class frmHoaDonBanHang
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
            this.gbThongTinChung = new System.Windows.Forms.GroupBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.lbDMHoaDonBan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbGiamGia = new System.Windows.Forms.Label();
            this.lbTenHang = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinChung.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTinChung
            // 
            this.gbThongTinChung.Controls.Add(this.cboMaKH);
            this.gbThongTinChung.Controls.Add(this.dtpNgayBan);
            this.gbThongTinChung.Controls.Add(this.label4);
            this.gbThongTinChung.Controls.Add(this.label3);
            this.gbThongTinChung.Controls.Add(this.label6);
            this.gbThongTinChung.Controls.Add(this.label2);
            this.gbThongTinChung.Controls.Add(this.label5);
            this.gbThongTinChung.Controls.Add(this.txtMaHoaDon);
            this.gbThongTinChung.Controls.Add(this.label1);
            this.gbThongTinChung.Controls.Add(this.lbTenKH);
            this.gbThongTinChung.Controls.Add(this.lbMaNV);
            this.gbThongTinChung.Controls.Add(this.lbTenNhanVien);
            this.gbThongTinChung.Location = new System.Drawing.Point(28, 42);
            this.gbThongTinChung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbThongTinChung.Name = "gbThongTinChung";
            this.gbThongTinChung.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbThongTinChung.Size = new System.Drawing.Size(948, 168);
            this.gbThongTinChung.TabIndex = 0;
            this.gbThongTinChung.TabStop = false;
            this.gbThongTinChung.Text = "Thông tin chung";
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(659, 38);
            this.cboMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(247, 24);
            this.cboMaKH.TabIndex = 48;
            this.cboMaKH.TextChanged += new System.EventHandler(this.cboMaKH_TextChanged);
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(659, 123);
            this.dtpNgayBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(247, 22);
            this.dtpNgayBan.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ngày bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Mã khách hàng:";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(140, 32);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(290, 24);
            this.txtMaHoaDon.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // lbTenKH
            // 
            this.lbTenKH.BackColor = System.Drawing.SystemColors.Info;
            this.lbTenKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.Location = new System.Drawing.Point(659, 80);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(247, 25);
            this.lbTenKH.TabIndex = 45;
            // 
            // lbMaNV
            // 
            this.lbMaNV.BackColor = System.Drawing.SystemColors.Info;
            this.lbMaNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(140, 75);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(290, 25);
            this.lbMaNV.TabIndex = 45;
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.BackColor = System.Drawing.SystemColors.Info;
            this.lbTenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.Location = new System.Drawing.Point(140, 122);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(290, 25);
            this.lbTenNhanVien.TabIndex = 45;
            // 
            // lbDMHoaDonBan
            // 
            this.lbDMHoaDonBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDMHoaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDMHoaDonBan.ForeColor = System.Drawing.Color.Blue;
            this.lbDMHoaDonBan.Location = new System.Drawing.Point(0, 0);
            this.lbDMHoaDonBan.Name = "lbDMHoaDonBan";
            this.lbDMHoaDonBan.Size = new System.Drawing.Size(1005, 40);
            this.lbDMHoaDonBan.TabIndex = 18;
            this.lbDMHoaDonBan.Text = "HÓA ĐƠN BÁN HÀNG";
            this.lbDMHoaDonBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnLuuHD);
            this.groupBox1.Controls.Add(this.btnInHD);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnXoaHD);
            this.groupBox1.Controls.Add(this.btnThemHD);
            this.groupBox1.Controls.Add(this.lbTongTien);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Controls.Add(this.cboMaHang);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lbDonGia);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbDonVi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbGiamGia);
            this.groupBox1.Controls.Add(this.lbTenHang);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(28, 214);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(948, 529);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin các mặt hàng";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(813, 473);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(110, 30);
            this.btnDong.TabIndex = 53;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLuuHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHD.Location = new System.Drawing.Point(450, 473);
            this.btnLuuHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(110, 30);
            this.btnLuuHD.TabIndex = 54;
            this.btnLuuHD.Text = "Lưu HD";
            this.btnLuuHD.UseVisualStyleBackColor = false;
            // 
            // btnInHD
            // 
            this.btnInHD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.Location = new System.Drawing.Point(309, 473);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(110, 30);
            this.btnInHD.TabIndex = 55;
            this.btnInHD.Text = "In HD";
            this.btnInHD.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(813, 128);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 30);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(667, 128);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 30);
            this.btnThem.TabIndex = 57;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHD.Location = new System.Drawing.Point(165, 473);
            this.btnXoaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(110, 30);
            this.btnXoaHD.TabIndex = 56;
            this.btnXoaHD.Text = "Xóa HD";
            this.btnXoaHD.UseVisualStyleBackColor = false;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHD.Location = new System.Drawing.Point(19, 473);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(110, 30);
            this.btnThemHD.TabIndex = 57;
            this.btnThemHD.Text = "Thêm HD";
            this.btnThemHD.UseVisualStyleBackColor = false;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.BackColor = System.Drawing.SystemColors.Info;
            this.lbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(635, 424);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(271, 25);
            this.lbTongTien.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(540, 431);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 18);
            this.label17.TabIndex = 52;
            this.label17.Text = "Tổng tiền:";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.DonGia,
            this.DonVi,
            this.GiamGia,
            this.TongTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(21, 180);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.RowTemplate.Height = 28;
            this.dgvHoaDon.Size = new System.Drawing.Size(902, 201);
            this.dgvHoaDon.TabIndex = 49;
            this.dgvHoaDon.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellEndEdit);
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(92, 30);
            this.cboMaHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(117, 24);
            this.cboMaHang.TabIndex = 48;
            this.cboMaHang.TextChanged += new System.EventHandler(this.cboMaHang_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(253, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 18);
            this.label13.TabIndex = 45;
            this.label13.Text = "Giảm giá:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(92, 73);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(117, 24);
            this.txtSoLuong.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 18);
            this.label14.TabIndex = 45;
            this.label14.Text = "Số lượng:";
            // 
            // lbDonGia
            // 
            this.lbDonGia.BackColor = System.Drawing.SystemColors.Info;
            this.lbDonGia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(732, 76);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(169, 25);
            this.lbDonGia.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(632, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 18);
            this.label12.TabIndex = 45;
            this.label12.Text = "Đơn giá:";
            // 
            // lbDonVi
            // 
            this.lbDonVi.BackColor = System.Drawing.SystemColors.Info;
            this.lbDonVi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonVi.Location = new System.Drawing.Point(732, 29);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(169, 25);
            this.lbDonVi.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(632, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 45;
            this.label10.Text = "Đơn vị:";
            // 
            // lbGiamGia
            // 
            this.lbGiamGia.BackColor = System.Drawing.SystemColors.Info;
            this.lbGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiamGia.Location = new System.Drawing.Point(345, 73);
            this.lbGiamGia.Name = "lbGiamGia";
            this.lbGiamGia.Size = new System.Drawing.Size(229, 25);
            this.lbGiamGia.TabIndex = 45;
            // 
            // lbTenHang
            // 
            this.lbTenHang.BackColor = System.Drawing.SystemColors.Info;
            this.lbTenHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHang.Location = new System.Drawing.Point(345, 30);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(229, 25);
            this.lbTenHang.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(253, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 18);
            this.label15.TabIndex = 45;
            this.label15.Text = "Tên hàng:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 18);
            this.label16.TabIndex = 45;
            this.label16.Text = "Mã hàng:";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 8;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 150;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 8;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 250;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 150;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn Vị";
            this.DonVi.MinimumWidth = 8;
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            this.DonVi.Width = 150;
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "GiamGia";
            this.GiamGia.HeaderText = "Giảm giá";
            this.GiamGia.MinimumWidth = 8;
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.ReadOnly = true;
            this.GiamGia.Width = 150;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle1.NullValue = null;
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle1;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 150;
            // 
            // frmHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 754);
            this.Controls.Add(this.lbDMHoaDonBan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbThongTinChung);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmHoaDonBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.frmHoaDonBanHang_Load);
            this.gbThongTinChung.ResumeLayout(false);
            this.gbThongTinChung.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTinChung;
        private System.Windows.Forms.Label lbDMHoaDonBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbDonVi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbGiamGia;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}