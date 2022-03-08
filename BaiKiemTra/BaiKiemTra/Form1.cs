namespace BaiKiemTra
{
    public partial class Form1 : Form
    {
        Form frm = new ThongBao();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String tk =textboxusername.Text, mk=textboxmatkhau.Text;
            if (tk ==" "|| mk =="")
            {
                MessageBox.Show("vuilong dien tai khoan mk");
            }
            if (tk == "admin" && mk == "admin")
            {
                this.Hide();
                frm.ShowDialog();
            }
                
        }
    }
}