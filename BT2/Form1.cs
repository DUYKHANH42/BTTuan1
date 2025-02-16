using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txthesoA.Focus();
        }

        private void lblTieude_Click(object sender, EventArgs e)
        {

        }

        private void lblsoA_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            string nghiem;
            if(!int.TryParse(txthesoA.Text, out a))
            {
                MessageBox.Show("Hệ số a không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthesoA.Focus();
                return;
            }
            if (!int.TryParse(txthesoB.Text, out b))
            {
                MessageBox.Show("Hệ số b không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthesoB.Focus();
                return;
            }
             a = int.Parse(txthesoA.Text);
             b = int.Parse(txthesoB.Text);

            if (a == 0)
            {
                if (b == 0)
                {
                    nghiem = "Phương trình vô số nghiệm";
                }
                else
                {
                    nghiem = "Phương trình vô nghiệm";
                }
            }
            else
            {
              float  x = (float)-b / a;
              nghiem = $"Phương trình có nghiệm x=  {x} " ;

            } 
            txtKq.Text=nghiem ;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            txtKq.Clear();
            txthesoA.Clear();
            txthesoB.Clear();
            txthesoA.Focus();
        }

        private void txtKq_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult kq = MessageBox.Show("Thoát hay không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }
    }
}
