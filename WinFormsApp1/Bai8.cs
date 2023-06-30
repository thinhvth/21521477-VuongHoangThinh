namespace lab1
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }
        private static bool CheckFormat(string s)
        {
            string[] Word = s.Split(',');
            string name = Word[0];
            int n = name.Length;
            for (int i = 0; i < n; ++i)
                if (name[i] <= '9' && name[i] >= '0')
                    return false;
            try
            {
                double toan = double.Parse(Word[1]);
                double ly = double.Parse(Word[2]);
                double hoa = double.Parse(Word[3]);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi định dạng,xin hãy nhập lại");
                return false;
            }
            return true;
        }
        private string Rank(double avg, double toan, double ly, double hoa)
        {
            string res = "";
            if (avg >= 8 && toan >= 6.5 && ly >= 6.5 && hoa >= 6.5)
                res = "Giỏi";
            else if (avg >= 6.5 && avg < 8 && toan >= 5 && ly >= 5 && hoa >= 5)
                res = "Khá ";
            else if (avg >= 5 && avg < 6.5 && toan >= 3.5 && ly >= 3.5 && hoa >= 3.5)
                res = "TB ";
            else if (avg >= 3.5 && avg < 5 && toan >= 2 && ly >= 2 && hoa >= 2)
                res = "Yếu ";
            else
                res = "Kém ";
            return res;
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            if (!CheckFormat(textBox1.Text))
            {
                return;
            }
            else
            {
                string[] word = textBox1.Text.Split(',');
                // word[0]: ten cua sv
                listBox1.Items.Add("Họ và tên: " + word[0] + " ");
                listBox1.Items.Add("Toán: " + word[1] + " ");
                listBox1.Items.Add("Lý: " + word[2] + " ");
                listBox1.Items.Add("Hóa: " + word[3] + "\r\n");
                double toan = double.Parse(word[1]);
                double ly = double.Parse(word[2]);
                double hoa = double.Parse(word[3]);
                double avg = (toan + ly + hoa) / 3;
                listBox1.Items.Add("Điểm tb: " + avg.ToString() + "\r\n");
                listBox1.Items.Add("Môn cao nhất: " + (Math.Max(Math.Max(toan, ly), hoa)).ToString() + " ");
                listBox1.Items.Add("Môn thấp nhất: " + (Math.Min(Math.Min(toan, ly), hoa)).ToString() + "\r\n");
                listBox1.Items.Add("Xếp loại: " + Rank(avg, toan, ly, hoa) + "\r\n");
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.Items.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
