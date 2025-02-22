namespace BT3
{
    partial class Manhinh
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
            btnThemSo = new Button();
            lblNhapso = new Label();
            txtNhapso = new TextBox();
            lstNhapSo = new ListBox();
            bntTinhtong = new Button();
            bntXoaDauvaCuoi = new Button();
            btnTang2 = new Button();
            bntTinhchanle = new Button();
            btnXoa = new Button();
            SuspendLayout();
            // 
            // btnThemSo
            // 
            btnThemSo.Location = new Point(535, 81);
            btnThemSo.Name = "btnThemSo";
            btnThemSo.Size = new Size(236, 46);
            btnThemSo.TabIndex = 2;
            btnThemSo.Text = "Thêm";
            btnThemSo.UseVisualStyleBackColor = true;
            btnThemSo.Click += btnThemSo_Click;
            // 
            // lblNhapso
            // 
            lblNhapso.AutoSize = true;
            lblNhapso.Location = new Point(54, 81);
            lblNhapso.Name = "lblNhapso";
            lblNhapso.Size = new Size(108, 32);
            lblNhapso.TabIndex = 1;
            lblNhapso.Text = "Nhập số:";
            lblNhapso.Click += label1_Click;
            // 
            // txtNhapso
            // 
            txtNhapso.Location = new Point(176, 78);
            txtNhapso.Name = "txtNhapso";
            txtNhapso.Size = new Size(324, 39);
            txtNhapso.TabIndex = 1;
            // 
            // lstNhapSo
            // 
            lstNhapSo.FormattingEnabled = true;
            lstNhapSo.Location = new Point(176, 156);
            lstNhapSo.Name = "lstNhapSo";
            lstNhapSo.Size = new Size(324, 164);
            lstNhapSo.TabIndex = 0;
            // 
            // bntTinhtong
            // 
            bntTinhtong.Location = new Point(535, 133);
            bntTinhtong.Name = "bntTinhtong";
            bntTinhtong.Size = new Size(236, 46);
            bntTinhtong.TabIndex = 3;
            bntTinhtong.Text = "Tính Tổng";
            bntTinhtong.UseVisualStyleBackColor = true;
            bntTinhtong.Click += bntTinhtong_Click;
            // 
            // bntXoaDauvaCuoi
            // 
            bntXoaDauvaCuoi.Location = new Point(535, 185);
            bntXoaDauvaCuoi.Name = "bntXoaDauvaCuoi";
            bntXoaDauvaCuoi.Size = new Size(236, 46);
            bntXoaDauvaCuoi.TabIndex = 4;
            bntXoaDauvaCuoi.Text = "Xóa Đầu và Cuối";
            bntXoaDauvaCuoi.UseVisualStyleBackColor = true;
            bntXoaDauvaCuoi.Click += bntXoaDauvaCuoi_Click;
            // 
            // btnTang2
            // 
            btnTang2.Location = new Point(535, 237);
            btnTang2.Name = "btnTang2";
            btnTang2.Size = new Size(236, 46);
            btnTang2.TabIndex = 5;
            btnTang2.Text = "Tăng mỗi số lên 2";
            btnTang2.UseVisualStyleBackColor = true;
            btnTang2.Click += btnTang2_Click;
            // 
            // bntTinhchanle
            // 
            bntTinhchanle.Location = new Point(535, 289);
            bntTinhchanle.Name = "bntTinhchanle";
            bntTinhchanle.Size = new Size(236, 46);
            bntTinhchanle.TabIndex = 6;
            bntTinhchanle.Text = "Chọn các số chẳn";
            bntTinhchanle.UseVisualStyleBackColor = true;
            bntTinhchanle.Click += bntTinhchanle_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(535, 341);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(236, 46);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // Manhinh
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstNhapSo);
            Controls.Add(txtNhapso);
            Controls.Add(lblNhapso);
            Controls.Add(btnXoa);
            Controls.Add(bntTinhchanle);
            Controls.Add(btnTang2);
            Controls.Add(bntXoaDauvaCuoi);
            Controls.Add(bntTinhtong);
            Controls.Add(btnThemSo);
            Name = "Manhinh";
            Text = "Form1";
            Load += Manhinh_Load_3;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThemSo;
        private Label lblNhapso;
        private TextBox txtNhapso;
        private ListBox lstNhapSo;
        private Button bntTinhtong;
        private Button bntXoaDauvaCuoi;
        private Button btnTang2;
        private Button bntTinhchanle;
        private Button btnXoa;
    }
}
