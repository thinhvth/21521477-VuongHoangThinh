namespace lab1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        double GetOilRate(string name)
        {
            double res = 0;
            switch (name)
            {
                case "RON 95-III":
                    res = 26.830;
                    break;
                case "E5 RON 92-II":
                    res = 26.070;
                    break;
                case "DO 0,05S-II":
                    res = 21.310;
                    break;

            }
            return res;
        }
        (double, double) GetVehicleInfo(string name)
        {
            double FuelComsumption = 0;
            double Capacity = 0;
            switch (name.Trim())
            {
                case "Wave Alpha":
                    {
                        FuelComsumption = 1.6;
                        Capacity = 3.7;
                    }
                    break;
                case "Sirius":
                    {
                        FuelComsumption = 1.99;
                        Capacity = 3.8;
                    }

                    break;
                case "Vision":
                    {
                        FuelComsumption = 1.87;
                        Capacity = 5.2;
                    }
                    break;
                case "Lead":
                    {
                        FuelComsumption = 2.02;
                        Capacity = 6;
                    }
                    break;
                case "Winner":
                    {
                        FuelComsumption = 1.7;
                        Capacity = 4.5;
                    }
                    break;
                case "AirBlade 150":
                    {
                        FuelComsumption = 2.17;
                        Capacity = 4.4;
                    }
                    break;
                case "Xe tải 9 tấn":
                    {
                        FuelComsumption = 13;
                        Capacity = 70;
                    }
                    break;

            }
            return (FuelComsumption, Capacity);
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Wave Alpha":
                    {
                        if (comboBox2.Text != "RON 95-III" && comboBox2.Text != "E5 RON 92-II")
                        {
                            MessageBox.Show("Chọn sai loại xăng xin chọn lại");
                            return;
                        }

                    }
                    break;
                case "Sirius":
                    {
                        if (comboBox2.Text != "RON 95-III" && comboBox2.Text != "E5 RON 92-II")
                        {
                            MessageBox.Show("Chọn sai loại xăng xin chọn lại");
                            return;
                        }
                       
                    }
                    break;
                case "Vision":
                    {
                        if (comboBox2.Text != "RON 95-III" && comboBox2.Text != "RON 92-II")
                        {
                            MessageBox.Show("Chọn sai loại xăng xin chọn lại");
                            return;
                        }

                    }
                    break;
                case "Lead":
                    {
                        if (comboBox2.Text != "RON 95-III")
                        {
                            MessageBox.Show("Chọn sai loại xăng xin chọn lại");
                            return;
                        }
                    }
                    break;
                case "Winner":
                    {
                        if (comboBox2.Text != "RON 95-III")
                        {
                            MessageBox.Show("Chọn sai loại xăng xin chọn lại");
                            return;
                        }
                    }
                    break;
                case "AirBlade":
                    {
                        if (comboBox2.Text != "RON 95-III")
                        {
                            MessageBox.Show("Chọn sai loại xăng xin chọn lại");
                            return;
                        }
                    }
                    break;
                case "Xe tải 9 tấn":
                    {
                        if (comboBox2.Text != "D0 0,05S-II")
                        {
                            MessageBox.Show("Chọn sai loại xăng xin chọn lại");
                            return;
                        }
                    }
                    break;
            }
            double Oil = GetOilRate(comboBox2.Text);
            var x = GetVehicleInfo(comboBox1.Text);
            double FuelConsumption = x.Item1;
            double Capacity = x.Item2;
            double TotalPrice = Oil * Capacity;
            double TotalDistance = Capacity * 100 / FuelConsumption;
            textBox1.Text = TotalPrice.ToString();
            textBox2.Text = TotalDistance.ToString();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
        }
    }
}
