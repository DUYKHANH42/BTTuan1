namespace BT4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntGhi_Click(object sender, EventArgs e)
        {
            SINHVIEN sv;
            if (!txtMaSV.ReadOnly)
            {
                foreach (SINHVIEN a in lstSinhVien.Items)
                {
                    if (a.MaSV == txtMaSV.Text)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaSV.Focus();
                        return;
                    }
                }
                     sv = new SINHVIEN();
                sv.MaSV = txtMaSV.Text;
                sv.Hoten = txtHoTen.Text;
                sv.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                lstSinhVien.Items.Add(sv);
                lstSinhVien.SelectedIndex = lstSinhVien.Items.IndexOf(sv);
                txtMaSV.ReadOnly = true;
            }
            else
            {
                 sv = (lstSinhVien.SelectedItem)as SINHVIEN;
                sv.Hoten = txtHoTen.Text;
                sv.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                lstSinhVien.Items[lstSinhVien.SelectedIndex] = sv;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lstSinhVien.DisplayMember = "HoTen";
            txtHoTen.Focus();
        }

        private void lstSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex == -1)
                return;

            SINHVIEN sv = (lstSinhVien.SelectedItem) as SINHVIEN;
            txtMaSV.Text = sv.MaSV;
            txtHoTen.Text = sv.Hoten;
            txtNgaySinh.Text = sv.NgaySinh.ToShortDateString();

        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                
                    (c as TextBox).Clear();
            }

            txtHoTen.Focus();
            txtMaSV.ReadOnly = false;
        }

        private void bntQuayLai_Click(object sender, EventArgs e)
        {

        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
           if( lstSinhVien.SelectedIndex == -1)
            return;
            lstSinhVien.Items.RemoveAt(lstSinhVien.SelectedIndex);
        }
    }
}
