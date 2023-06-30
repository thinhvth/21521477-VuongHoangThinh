using System.Net;
namespace lab1
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }
        private bool CheckAddress(string s)
        {
            return IPAddress.TryParse(s, out _);
        }
        // kiểm tra một số có phải là một số dạng 2^x
        private bool IsPowerOfTwo(int x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            IPAddress IpAdd = IPAddress.Parse(textBox1.Text);
            IPAddress Subnet = IPAddress.Parse(textBox2.Text);
            IPAddress NetworkIp = IpAdd.GetNetworkAddress(Subnet);
            IPAddress temp1, temp2, temp3, temp4;
            IPAddress BroadCast = IpAdd.GetBroadcastAddress(Subnet);
            IPAddress First = NetworkIp.FirstAddress();
            int subnet = int.Parse(textBox3.Text);
            int BitHost = Subnet.CountBitHost();
            int Borrow = (IsPowerOfTwo(subnet)) ? (int)Math.Log2(subnet) : (int)Math.Log2(subnet) + 1;
            int LeftBitHost = BitHost - Borrow;// số bit host còn lai = số bit host-số bit mượn
            int Host = (int)Math.Pow(2, LeftBitHost) - 2;// số host mỗi subnet
            int jump = (int)Math.Pow(2, 8 - Borrow);// bước nhảy
            IPAddress Last = NetworkIp.LastAddress(Host);
            temp1 = NetworkIp;
            temp2 = First;
            temp3 = Last;
            temp4 = BroadCast;
            for (int i = 0; i < subnet; ++i)
            {
                dataGridView1.Rows.Add(i + 1, temp1, temp2, temp3, temp4);
                temp1 = temp1.NextIp(jump, 2);
                temp2 = temp2.NextIp(jump, 2);
                temp3 = temp3.NextIp(jump, 2);
                temp3 = temp4.NextIp(jump, 2);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = " ";
            dataGridView1.Rows.Clear();
        }
    }
}
