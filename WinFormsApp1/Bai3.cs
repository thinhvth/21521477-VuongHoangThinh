using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        private static string Convert(params char[] ch)
        {
            string res = "";
            foreach (char c in ch)
                res += c.ToString();
            return res;
        }
        private static string OneDigit(string[] Digits, char digit)
        {
            return Digits[digit - '0'];
        }
        private static string TwoDigit(string[] Digits, string s)
        {
            string res = "";
            if (s[1] == '0')
            {
                if (s[0] == '1')
                    res += "Mười ";
                else
                    res += OneDigit(Digits, s[0]) + "Mươi ";
            }
            else
            {
                if (s[0] == '1')
                {
                    res += "Mười ";
                    if (s[1] == '5')
                        res += "Lăm ";
                    else if (s[1] == '1')
                        res += "Một ";
                    else
                        res += OneDigit(Digits, s[1]);
                }
                else
                {
                    res += OneDigit(Digits, s[0]) + "Mươi ";
                    if (s[1] == '5')
                        res += "Lăm ";
                    else if (s[1] == '1')
                        res += "Mốt ";
                    else
                        res += OneDigit(Digits, s[1]);
                }
            }
            return res;
        }
        private static string ThreeDigit(string[] Digits, string s)
        {
            string res = OneDigit(Digits, s[0]) + "Trăm ";
            if (s[1] == '0')
            {
                if (s[2] != '0')
                    res += "Lẻ " + OneDigit(Digits, s[2]);
            }
            else
            {
                res += TwoDigit(Digits, Convert(s[1], s[2]));
            }
            return res;
        }
        private static string ReadNum(string s)
        {
            string[] Digit = { "Không ", "Một ", "Hai ", "Ba ", "Bốn ", "Năm ", "Sáu ", "Bảy ", "Tám ", "Chín " };
            string res = "";
            int length = s.Length;
            int temp = length;
            string num = "";
            if (length == 1)
            {
                res += OneDigit(Digit, s[0]);
                return res;
            }
            if (length == 2)
            {
                res += TwoDigit(Digit, s);
                return res;
            }
            if (length == 3)
            {
                res += ThreeDigit(Digit, s);
                return res;
            }
            // số lần đọc 
            int Group = (length % 3 == 0) ? (length / 3) : (length / 3 + 1);
            int pos = 0;
            for (int i = 0; i < Group; i++)
            {
                int gr = temp % 3;
                if (gr == 0)
                {
                    res += ThreeDigit(Digit, Convert(s[pos], s[pos + 1], s[pos + 2]));
                    temp -= 3;
                    pos += 3;
                }
                if (gr == 1)
                {
                    res += OneDigit(Digit, s[pos]);
                    temp -= 1;
                    pos += 1;
                }
                if (gr == 2)
                {
                    res += TwoDigit(Digit, Convert(s[pos], s[pos + 1]));
                    temp -= 2;
                    pos += 2;
                }
                if (temp == 9)
                    res += "Tỉ ";
                if (temp == 6)
                    res += "Triệu ";
                if (temp == 3)
                    res += "Ngàn ";
            }
            return res;
        }
        private void Read_Click(object sender, EventArgs e)
        {
            if(!long.TryParse(textBox1.Text,out long value))
            {
                MessageBox.Show("Nhập sai, xin hãy nhập lại");
                return;
            }
            textBox2.Text = ReadNum(textBox1.Text);
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text = "";
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kết thúc chương trình");
            Close();
        }
    }
}
