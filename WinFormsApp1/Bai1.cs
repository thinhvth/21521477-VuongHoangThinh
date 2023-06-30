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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        private void textbox1_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (!long.TryParse(textBox1.Text, out _))
                    MessageBox.Show("Nhập sai xin hãy nhập một số nguyên");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            long s1=long.Parse(textBox1.Text);
            long s2=long.Parse(textBox2.Text);
            textBox3.Text = (s1 + s2).ToString();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }
    }
}
