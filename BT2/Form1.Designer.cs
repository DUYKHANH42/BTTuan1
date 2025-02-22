
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
            this.lblTieude = new System.Windows.Forms.Label();
            this.lblsoA = new System.Windows.Forms.Label();
            this.lblsoB = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txthesoA = new System.Windows.Forms.TextBox();
            this.txthesoB = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieude
            // 
            this.lblTieude.BackColor = System.Drawing.Color.Blue;
            this.lblTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieude.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieude.ForeColor = System.Drawing.Color.White;
            this.lblTieude.Location = new System.Drawing.Point(0, 0);
            this.lblTieude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(995, 102);
            this.lblTieude.TabIndex = 0;
            this.lblTieude.Text = "GIẢI PHƯƠNG TRÌNH BẬC NHẤT";
            this.lblTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTieude.Click += new System.EventHandler(this.lblTieude_Click);
            // 
            // lblsoA
            // 
            this.lblsoA.AutoSize = true;
            this.lblsoA.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoA.Location = new System.Drawing.Point(67, 186);
            this.lblsoA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblsoA.Name = "lblsoA";
            this.lblsoA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblsoA.Size = new System.Drawing.Size(109, 31);
            this.lblsoA.TabIndex = 2;
            this.lblsoA.Text = "Hệ số a:";
            this.lblsoA.Click += new System.EventHandler(this.lblsoA_Click);
            // 
            // lblsoB
            // 
            this.lblsoB.AutoSize = true;
            this.lblsoB.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoB.Location = new System.Drawing.Point(67, 243);
            this.lblsoB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblsoB.Name = "lblsoB";
            this.lblsoB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblsoB.Size = new System.Drawing.Size(110, 31);
            this.lblsoB.TabIndex = 3;
            this.lblsoB.Text = "Hệ số b:";
            this.lblsoB.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(67, 307);
            this.lblKQ.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKQ.Size = new System.Drawing.Size(116, 31);
            this.lblKQ.TabIndex = 4;
            this.lblKQ.Text = "Kết quả:";
            this.lblKQ.Click += new System.EventHandler(this.lblKQ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txthesoA
            // 
            this.txthesoA.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthesoA.ForeColor = System.Drawing.Color.Red;
            this.txthesoA.Location = new System.Drawing.Point(239, 185);
            this.txthesoA.Margin = new System.Windows.Forms.Padding(6);
            this.txthesoA.Name = "txthesoA";
            this.txthesoA.Size = new System.Drawing.Size(522, 32);
            this.txthesoA.TabIndex = 5;
            this.txthesoA.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txthesoB
            // 
            this.txthesoB.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthesoB.ForeColor = System.Drawing.Color.Red;
            this.txthesoB.Location = new System.Drawing.Point(239, 242);
            this.txthesoB.Margin = new System.Windows.Forms.Padding(6);
            this.txthesoB.Name = "txthesoB";
            this.txthesoB.Size = new System.Drawing.Size(522, 32);
            this.txthesoB.TabIndex = 6;
            this.txthesoB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtKq
            // 
            this.txtKq.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKq.ForeColor = System.Drawing.Color.Red;
            this.txtKq.Location = new System.Drawing.Point(239, 306);
            this.txtKq.Margin = new System.Windows.Forms.Padding(6);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(522, 32);
            this.txtKq.TabIndex = 7;
            this.txtKq.TextChanged += new System.EventHandler(this.txtKq_TextChanged);
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.White;
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.ForeColor = System.Drawing.Color.Red;
            this.btnTinh.Location = new System.Drawing.Point(238, 392);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(6);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(120, 67);
            this.btnTinh.TabIndex = 8;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.BackColor = System.Drawing.Color.White;
            this.btnTiep.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiep.ForeColor = System.Drawing.Color.Red;
            this.btnTiep.Location = new System.Drawing.Point(439, 392);
            this.btnTiep.Margin = new System.Windows.Forms.Padding(6);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(120, 67);
            this.btnTiep.TabIndex = 9;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = false;
            this.btnTiep.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(640, 392);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 67);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 562);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txthesoB);
            this.Controls.Add(this.txthesoA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lblsoB);
            this.Controls.Add(this.lblsoA);
            this.Controls.Add(this.lblTieude);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieude;
        private System.Windows.Forms.Label lblsoA;
        private System.Windows.Forms.Label lblsoB;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthesoA;
        private System.Windows.Forms.TextBox txthesoB;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnThoat;
    }
}

