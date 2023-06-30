namespace lab1
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 19 || textBox2.Text.Length > 19)
            {
                MessageBox.Show("Số quá lớn xin hãy nhập lại");
                textBox2.Text = textBox1.Text = "";
            }
            var A = long.Parse(textBox1.Text.Trim());
            var B = long.Parse(textBox2.Text.Trim());
            var a = "A!=";
            var b = "B!=";
            var s1 = "S1=";
            var s2 = "S2=";
            var s3 = "S3=";
            long res = 2;
            if (A == 0 || A == 1)
            {
                if (A == 0 && B == 0)
                {
                    MessageBox.Show("Không tính được S3");
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    return;
                }
                a += "1\r\n";
                s1 += A.ToString() + "\r\n";
                s3 += A.ToString() + "\r\n";
            }
            else
            {
                for (long i = 3; i <= A; ++i)
                    res *= i;
                a += res.ToString() + "\r\n";
                for (long i = 1; i <= A; ++i)
                {
                    if (i == A)
                        s1 += A.ToString() + "=";
                    else
                        s1 += i.ToString() + "+";
                }
                s1 += ((A / 2) * (A + 1)).ToString() + "\r\n";
            }
            if (B == 0 || B == 1)
            {
                s2 += B.ToString() + "\r\n";
                if (B == 0)
                    s3 += 1.ToString() + "\r\n";
                if (B == 1)
                    s3 += A.ToString() + "\r\n";
            }
            else
            {
                res = 2;
                for (long i = 3; i <= B; ++i)
                    res *= i;
                b += res.ToString() + "\r\n";
                for (long i = 1; i <= B; ++i)
                {
                    if (i == B)
                        s2 += B.ToString() + "=";
                    else   
                        s2 += i.ToString() + "+";
                }
                s2 += ((B / 2) * (B + 1)).ToString() + "\r\n";
                string x = A.ToString();
                for (int i = 0; i <= B; ++i)
                {
                    if (i == B)
                        s3 += x + "^" + B.ToString();
                    else
                        s3 += x + "^" + i.ToString() + "+";
                }
                s3 += "=" + Math.Pow(A, B).ToString();
            }
            listBox1.Items.Add(a);
            listBox1.Items.Add(b);
            listBox1.Items.Add(s1);
            listBox1.Items.Add(s2);
            listBox1.Items.Add(s3);
        }
    }
}
