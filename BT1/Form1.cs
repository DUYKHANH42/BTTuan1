using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtHoLot_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHolot_Click(object sender, EventArgs e)
        {
            lblKQ.Text = TxtHoLot.Text;
            if (TxtHoLot.Text == "")
            {
                MessageBox.Show("Không để thiếu họ","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                TxtHoLot.Focus();

            }
        }

        private void btnHovaTen_Click(object sender, EventArgs e)
        {
            lblKQ.Text = TxtHoLot.Text + " " + txtTen;

            if (TxtHoLot.Text == "")
            {    
                    MessageBox.Show("Không để thiếu họ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtHoLot.Focus();
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Không để thiếu tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtHoLot.Focus();
            }

        }
        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
            TxtHoLot.Clear();
            lblKQ.Text = "";
            TxtHoLot.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq =MessageBox.Show("Thoát hay không?","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(kq==DialogResult.Yes)
            this.Close();
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblKQ.Text = txtTen.Text;
                if (txtTen.Text == "")
            {
                MessageBox.Show("Không để thiếu tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblHoLot_Click(object sender, EventArgs e)
        {

        }

        private void lblTen_Click(object sender, EventArgs e)
        {

        }

        private void lblKQ_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
