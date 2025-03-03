namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b;
        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);

            if (checkBox1.Checked == true)
            {
                MessageBox.Show("a + b = " + (a + b));
            }
            if (checkBox2.Checked == true)
            {
                MessageBox.Show("a - b = " + (a - b));
            }
            if (checkBox3.Checked == true)
            {
                MessageBox.Show("a * b = " + (a * b));
            }
            if (checkBox4.Checked == true)
            {
                MessageBox.Show("a / b = " + (a / b));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir deðer seçin");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);

            if (listBox1.SelectedIndex != -1)
            {
                string islem = listBox1.SelectedItem.ToString();

                switch (islem)
                {
                    case "+":
                        label6.Text = (a + b).ToString();
                        break;
                    case "-":
                        label6.Text = (a - b).ToString();
                        break;
                    case "*":
                        label6.Text = (a * b).ToString();
                        break;
                    case "/":
                        label6.Text = (a / b).ToString();
                        break;
                    default:
                        MessageBox.Show("Seçin!!");
                        break;
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox3.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir deðer seçin");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);

            if (comboBox1.SelectedIndex != -1)
            {
                string islem = comboBox1.SelectedItem.ToString();

                switch (islem)
                {
                    case "+":
                        label7.Text = (a + b).ToString();
                        break;
                    case "-":
                        label7.Text = (a - b).ToString();
                        break;
                    case "*":
                        label7.Text = (a * b).ToString();
                        break;
                    case "/":
                        label7.Text = (a / b).ToString();
                        break;
                    default:
                        MessageBox.Show("Seçin!!");
                        break;
                }
            }
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                progressBar1.Value += 10;
            }
            if(radioButton2.Checked == true)
            {
                progressBar1.Value -= 10;
            }
        }
    }
}
