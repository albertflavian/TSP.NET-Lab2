using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double value = 0;
        string operation = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (result.Text != "0")
            {
                if (result.Text[0] == '-')
                    result.Text = result.Text.Remove(0, 1);
                else
                    result.Text = result.Text.Insert(0, "-");
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (result.Text == "0")
                result.Text = btn.Text;
            else
                result.Text += btn.Text;
        }

       
        private void button0_Click(object sender, EventArgs e)
        {
            if (result.Text != "0")
                result.Text += "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            operation = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            result.Text = result.Text.Remove(result.Text.Length - 1, 1);
            if (result.Text == "" || result.Text == "-" || result.Text == "-0")
                result.Text = "0";
        }

        private void buttonComa_Click(object sender, EventArgs e)
        {
            if (!result.Text.Contains(","))
                result.Text += ",";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            value = Double.Parse(result.Text);
            result.Text = "0";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (operation != "")
            {
                double tmp = Double.Parse(result.Text);

                switch (operation)
                {
                    case "+":
                        value += tmp;
                        result.Text = value.ToString();
                        break;
                    case "-":
                        value -= tmp;
                        result.Text = value.ToString();
                        break;
                    case "÷":
                        value /= tmp;
                        result.Text = value.ToString();
                        break;
                    case "x":
                        value *= tmp;
                        result.Text = value.ToString();
                        break;
                    default:
                        break;
                }


                operation = "";
                
            }
                
        }
    }
}
