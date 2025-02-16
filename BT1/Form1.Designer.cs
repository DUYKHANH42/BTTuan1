
namespace BT1
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
            this.lblTen = new System.Windows.Forms.Label();
            this.lblHoLot = new System.Windows.Forms.Label();
            this.TxtHoLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnHolot = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHovaTen = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.Red;
            this.lblTen.Location = new System.Drawing.Point(15, 166);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(49, 27);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên";
            this.lblTen.Click += new System.EventHandler(this.lblTen_Click);
            // 
            // lblHoLot
            // 
            this.lblHoLot.AutoSize = true;
            this.lblHoLot.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoLot.ForeColor = System.Drawing.Color.Red;
            this.lblHoLot.Location = new System.Drawing.Point(15, 127);
            this.lblHoLot.Name = "lblHoLot";
            this.lblHoLot.Size = new System.Drawing.Size(72, 27);
            this.lblHoLot.TabIndex = 0;
            this.lblHoLot.Text = "Họ lót";
            this.lblHoLot.Click += new System.EventHandler(this.lblHoLot_Click);
            // 
            // TxtHoLot
            // 
            this.TxtHoLot.Location = new System.Drawing.Point(105, 124);
            this.TxtHoLot.Name = "TxtHoLot";
            this.TxtHoLot.Size = new System.Drawing.Size(323, 35);
            this.TxtHoLot.TabIndex = 1;
            this.TxtHoLot.TextChanged += new System.EventHandler(this.TxtHoLot_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(105, 163);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(323, 35);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.Color.Blue;
            this.lblKQ.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.ForeColor = System.Drawing.Color.White;
            this.lblKQ.Location = new System.Drawing.Point(15, 219);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(413, 83);
            this.lblKQ.TabIndex = 3;
            this.lblKQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKQ.Click += new System.EventHandler(this.lblKQ_Click);
            // 
            // btnHolot
            // 
            this.btnHolot.BackColor = System.Drawing.Color.White;
            this.btnHolot.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHolot.ForeColor = System.Drawing.Color.Red;
            this.btnHolot.Location = new System.Drawing.Point(15, 328);
            this.btnHolot.Name = "btnHolot";
            this.btnHolot.Size = new System.Drawing.Size(69, 26);
            this.btnHolot.TabIndex = 4;
            this.btnHolot.Text = "Họ Lót";
            this.btnHolot.UseVisualStyleBackColor = false;
            this.btnHolot.Click += new System.EventHandler(this.btnHolot_Click);
            // 
            // btnTen
            // 
            this.btnTen.BackColor = System.Drawing.Color.White;
            this.btnTen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTen.ForeColor = System.Drawing.Color.Red;
            this.btnTen.Location = new System.Drawing.Point(101, 328);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(69, 26);
            this.btnTen.TabIndex = 5;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = false;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHovaTen
            // 
            this.btnHovaTen.BackColor = System.Drawing.Color.White;
            this.btnHovaTen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHovaTen.ForeColor = System.Drawing.Color.Red;
            this.btnHovaTen.Location = new System.Drawing.Point(187, 327);
            this.btnHovaTen.Name = "btnHovaTen";
            this.btnHovaTen.Size = new System.Drawing.Size(69, 26);
            this.btnHovaTen.TabIndex = 6;
            this.btnHovaTen.Text = "Họ và Tên";
            this.btnHovaTen.UseVisualStyleBackColor = false;
            this.btnHovaTen.Click += new System.EventHandler(this.btnHovaTen_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.BackColor = System.Drawing.Color.White;
            this.btnTiep.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiep.ForeColor = System.Drawing.Color.Red;
            this.btnTiep.Location = new System.Drawing.Point(273, 328);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(69, 26);
            this.btnTiep.TabIndex = 7;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = false;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(359, 328);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(69, 26);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 505);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnHovaTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHolot);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.TxtHoLot);
            this.Controls.Add(this.lblHoLot);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lblTen);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duy Khanh";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblHoLot;
        private System.Windows.Forms.TextBox TxtHoLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnHolot;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHovaTen;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnThoat;
    }
}

