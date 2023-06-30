using lab1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private int tempIndex;
        private Form CurrentChildForm;
        public static List<string> ColorList = new()
            {  "#3F51B5",
            "#009688",
            "#FF5722",
            "#607D8B",
            "#FF9800",
            "#9C27B0",
            "#2196F3",
            "#EA676C",
            };
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form child)
        {
            if(CurrentChildForm!= null)
            {
                CurrentChildForm.Close();
            }
            CurrentChildForm = child;
            child.TopLevel = false;
            child.FormBorderStyle= FormBorderStyle.None;
            child.Dock=DockStyle.Fill;
            panel2.Controls.Add(child);
            panel2.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bai1());
            label1.Text = "     "+button1.Text;
            label1.BackColor = panel3.BackColor = ColorTranslator.FromHtml(ColorList[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bai2());
            label1.Text = "     "+button2.Text;
            label1.BackColor = panel3.BackColor = ColorTranslator.FromHtml(ColorList[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bai3());
            label1.Text = "    "+button3.Text;
            label1.BackColor = panel3.BackColor = ColorTranslator.FromHtml(ColorList[2]);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bai4());
            label1.Text = "    " + button4.Text;
            label1.BackColor = panel3.BackColor = ColorTranslator.FromHtml(ColorList[3]);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bai5());
            label1.Text = "    " + button5.Text;
            label1.BackColor = panel3.BackColor = ColorTranslator.FromHtml(ColorList[4]);

        }
        private void button6_click(object sender, EventArgs e)
        {
            OpenChildForm(new Bai6());
            label1.Text = "    " + button6.Text;
            label1.BackColor = panel3.BackColor = ColorTranslator.FromHtml(ColorList[5]);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bai7());
            label1.Text = "    " + button7.Text;
            label1.BackColor = panel3.BackColor = ColorTranslator.FromHtml(ColorList[6]);

        }
        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bai8());
            label1.Text = "    " + button8.Text;
            label1.BackColor = panel3.BackColor = ColorTranslator.FromHtml(ColorList[7]);

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}