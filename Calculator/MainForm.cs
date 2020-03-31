using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        double FirstNumber;
        string Operation;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
                textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            firstLabel.Text = "";
            OPLabel.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out FirstNumber);
            textBox1.Text = "";
            firstLabel.Text = FirstNumber.ToString();
            Operation = "/";
            OPLabel.Text = Operation;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out FirstNumber);
            firstLabel.Text = FirstNumber.ToString();
            textBox1.Text = "";
            Operation = "x";
            OPLabel.Text = Operation;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out FirstNumber);
            firstLabel.Text = FirstNumber.ToString();
            textBox1.Text = "";
            Operation = "+";
            OPLabel.Text = Operation;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out FirstNumber);
            firstLabel.Text = FirstNumber.ToString();
            textBox1.Text = "";
            Operation = "-";
            OPLabel.Text = Operation;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            double result;
            double SecondNumber;

            SecondNumber = Convert.ToDouble(textBox1.Text);
            if (Operation == "+")
            {
                result = (FirstNumber + SecondNumber);
                textBox1.Text = result.ToString();
                FirstNumber = result;
            }
            else if (Operation == "-")
            {
                result = (FirstNumber - SecondNumber);
                textBox1.Text = result.ToString();
                FirstNumber = result;
            }
            else if (Operation == "x")
            {
                result = (FirstNumber * SecondNumber);
                textBox1.Text = result.ToString();
                FirstNumber = result;
            }
            else if (Operation == "/")
            {
                result = (FirstNumber / SecondNumber);
                textBox1.Text = result.ToString();
                FirstNumber = result;
            }
            else if (Operation == "%")
            {
                result = (FirstNumber % SecondNumber);
                textBox1.Text = result.ToString();
                FirstNumber = result;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out FirstNumber);
            firstLabel.Text = FirstNumber.ToString();
            textBox1.Text = "";
            Operation = "%";
            OPLabel.Text = Operation;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }
    }
}
