namespace BT4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSinhVien = new Label();
            lblMaSV = new Label();
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            lstSinhVien = new ListBox();
            txtMaSV = new TextBox();
            txtNgaySinh = new TextBox();
            txtHoTen = new TextBox();
            bntLamMoi = new Button();
            bntXoa = new Button();
            bntGhi = new Button();
            bntQuayLai = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblSinhVien
            // 
            lblSinhVien.AutoSize = true;
            lblSinhVien.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold);
            lblSinhVien.Location = new Point(0, 106);
            lblSinhVien.Name = "lblSinhVien";
            lblSinhVien.Size = new Size(385, 31);
            lblSinhVien.TabIndex = 0;
            lblSinhVien.Text = "Chọn sinh viên trong danh sách";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold);
            lblMaSV.Location = new Point(357, 206);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(173, 31);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã Sinh Viên";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold);
            lblHoTen.Location = new Point(357, 143);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(136, 31);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ và Tên";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold);
            lblNgaySinh.Location = new Point(357, 268);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(134, 31);
            lblNgaySinh.TabIndex = 0;
            lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lstSinhVien
            // 
            lstSinhVien.FormattingEnabled = true;
            lstSinhVien.Location = new Point(39, 140);
            lstSinhVien.Name = "lstSinhVien";
            lstSinhVien.Size = new Size(297, 164);
            lstSinhVien.TabIndex = 0;
            lstSinhVien.SelectedIndexChanged += lstSinhVien_SelectedIndexChanged;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(532, 203);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(348, 39);
            txtMaSV.TabIndex = 2;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(532, 265);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(348, 39);
            txtNgaySinh.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(532, 140);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(348, 39);
            txtHoTen.TabIndex = 1;
            // 
            // bntLamMoi
            // 
            bntLamMoi.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold);
            bntLamMoi.Location = new Point(135, 350);
            bntLamMoi.Name = "bntLamMoi";
            bntLamMoi.Size = new Size(150, 76);
            bntLamMoi.TabIndex = 4;
            bntLamMoi.Text = "Làm Mới";
            bntLamMoi.UseVisualStyleBackColor = true;
            bntLamMoi.Click += bntThem_Click;
            // 
            // bntXoa
            // 
            bntXoa.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold);
            bntXoa.Location = new Point(333, 350);
            bntXoa.Name = "bntXoa";
            bntXoa.Size = new Size(150, 76);
            bntXoa.TabIndex = 5;
            bntXoa.Text = "Xóa";
            bntXoa.UseVisualStyleBackColor = true;
            bntXoa.Click += bntXoa_Click;
            // 
            // bntGhi
            // 
            bntGhi.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold);
            bntGhi.Location = new Point(531, 350);
            bntGhi.Name = "bntGhi";
            bntGhi.Size = new Size(150, 76);
            bntGhi.TabIndex = 6;
            bntGhi.Text = "Ghi";
            bntGhi.UseVisualStyleBackColor = true;
            bntGhi.Click += bntGhi_Click;
            // 
            // bntQuayLai
            // 
            bntQuayLai.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold);
            bntQuayLai.Location = new Point(729, 350);
            bntQuayLai.Name = "bntQuayLai";
            bntQuayLai.Size = new Size(150, 76);
            bntQuayLai.TabIndex = 7;
            bntQuayLai.Text = "Quay Về";
            bntQuayLai.UseVisualStyleBackColor = true;
            bntQuayLai.Click += bntQuayLai_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1038, 54);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN SINH VIÊN\r\n";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 574);
            Controls.Add(bntQuayLai);
            Controls.Add(bntGhi);
            Controls.Add(bntXoa);
            Controls.Add(bntLamMoi);
            Controls.Add(txtHoTen);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtMaSV);
            Controls.Add(lstSinhVien);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblHoTen);
            Controls.Add(lblMaSV);
            Controls.Add(label1);
            Controls.Add(lblSinhVien);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DUYKHANH";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSinhVien;
        private Label lblMaSV;
        private Label lblHoTen;
        private Label lblNgaySinh;
        private ListBox lstSinhVien;
        private TextBox txtMaSV;
        private TextBox txtNgaySinh;
        private TextBox txtHoTen;
        private Button bntLamMoi;
        private Button bntXoa;
        private Button bntGhi;
        private Button bntQuayLai;
        private Label label1;
    }
}
