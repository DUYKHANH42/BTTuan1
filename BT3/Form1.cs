namespace BT3
{
    public partial class Manhinh : Form
    {
        public Manhinh()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemSo_Click(object sender, EventArgs e)
        {
            lstNhapSo.Items.Add(txtNhapso.Text);
            lstNhapSo.Focus();
        }

        private void bntTinhtong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < lstNhapSo.Items.Count; i++)
            {
                int x = Convert.ToInt32(lstNhapSo.Items[i]);
                tong = x + tong;
            }
            MessageBox.Show($"Tổng listbox= {tong}");
            lstNhapSo.Focus();
        }

        private void Manhinh_Load(object sender, EventArgs e)
        {
            txtNhapso.Focus();
        }

        private void bntXoaDauvaCuoi_Click(object sender, EventArgs e)
        {
            if (lstNhapSo.Items.Count >= 2)
            {
                lstNhapSo.Items.RemoveAt(0);
                lstNhapSo.Items.RemoveAt(lstNhapSo.Items.Count - 1);
            }

            lstNhapSo.Focus();
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstNhapSo.Items.Count; i++)
            {
                // Lấy giá trị hiện tại của mục
                string x = (string)lstNhapSo.Items[i];

                // Kiểm tra xem giá trị có phải là số không
                if (int.TryParse(x, out int a))
                {
                    // Tăng giá trị lên 2
                    a += 2;

                    // Cập nhật lại mục trong ListBox
                    lstNhapSo.Items[i] = x;
                }
                MessageBox.Show($"List box khi tăng lên 2 = {x}");
            }
            lstNhapSo.Focus();

        }

        private void bntTinhchanle_Click(object sender, EventArgs e)
        {
            int sochan = 0;
            int sole = 0;
            for (int i = 0; i < lstNhapSo.SelectedItems.Count; i++)
            {
                if (lstNhapSo.SelectedItems.Count / 2 == 0)
                {
                    sochan++;
                }
                else
                {
                    sole++;
                }

                MessageBox.Show($"Số chẳn{sochan} , Số lẻ{sole}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstNhapSo.SelectedIndex == -1) return;
            lstNhapSo.Items.RemoveAt(lstNhapSo.SelectedIndex);


        }

        private void Manhinh_Load_1(object sender, EventArgs e)
        {

        }

        private void Manhinh_Load_2(object sender, EventArgs e)
        {

        }

        private void Manhinh_Load_3(object sender, EventArgs e)
        {

        }
    }
}
