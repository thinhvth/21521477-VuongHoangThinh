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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (!Double.TryParse(textBox1.Text, out double d))
                    MessageBox.Show("Nhập sai, xin hãy nhập lại");
        }
        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (!Double.TryParse(textBox2.Text, out double d))
                    MessageBox.Show("Nhập sai, xin hãy nhập lại");
        }
        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (!Double.TryParse(textBox3.Text, out double d))
                    MessageBox.Show("Nhập sai, xin hãy nhập lại");
        }
        private void FindMinMax_Click(object sender, EventArgs e)
        {
            double d1 = double.Parse(textBox1.Text);
            double d2 = double.Parse(textBox2.Text);
            double d3 = double.Parse(textBox3.Text);
            textBox4.Text = Math.Max(Math.Max(d1, d2), d3).ToString();
            textBox5.Text = Math.Min(Math.Min(d1, d2), d3).ToString();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox5.Text = "";
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("exit the program");
            Close();
        }
    }
}
