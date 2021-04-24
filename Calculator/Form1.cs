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
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || operation_pressed)
                result.Clear();
            operation_pressed = false;
            Button button = (Button)sender;
            result.Text += button.Text;
        }
        private void button_Deci_Click(object sender, EventArgs e)
        {
            operation_pressed = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!result.Text.Contains(","))
                    result.Text += button.Text;
            }
            else
            {
                result.Text += button.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (value != 0)
            {
                if (button.Text == "sqrt")
                {
                    if (double.Parse(result.Text) < 0)
                        MessageBox.Show("See complex number i ");
                    result.Text = Operator.Sqrt(double.Parse(result.Text)).ToString();
                }
                if (button.Text == "sq")
                    result.Text = Operator.PowToTwo(double.Parse(result.Text)).ToString();
                if (button.Text == "1 / x")
                {
                    if (result.Text == "0")
                        MessageBox.Show("Division Into Infinity ? ");
                    result.Text = Operator.OneDivX(double.Parse(result.Text)).ToString();
                }
                equal.PerformClick();
                operation_pressed = true;
                operation = button.Text;
                if (operation == "1 / x")
                {
                    equation.Text = $" {value} / 1";
                }
                else
                {
                    if (value < 0)
                    {
                        //equation.Text = $" {value} - ";
                        equation.Text = $" {Math.Abs(value)}- - ";
                    }
                    else
                    {
                        equation.Text = value + " " + operation;
                    }
                }
            }
            else if (button.Text == "sqrt")
            {
                if (double.Parse(result.Text) < 0)
                    MessageBox.Show("See complex number i  ");
                result.Text = Operator.Sqrt(double.Parse(result.Text)).ToString();
                value = Operator.Sqrt(double.Parse(result.Text));
            }
            else if (button.Text == "sq")
            {
                result.Text = Operator.PowToTwo(double.Parse(result.Text)).ToString();
                value = Operator.PowToTwo(double.Parse(result.Text));
            }
            else if (button.Text == "1 / x")
            {
                if (result.Text == "0")
                    MessageBox.Show("Division Into Infinity ? ");
                result.Text = Operator.OneDivX(double.Parse(result.Text)).ToString();
                value = Operator.OneDivX(double.Parse(result.Text));
            }
            else
            {
                operation = button.Text;
                value = double.Parse(result.Text);
                operation_pressed = true;
                if (value < 0)
                {
                    //equation.Text = value + " " + operation;
                    equation.Text = $" {Math.Abs(value)}- - ";
                }
                else
                {
                    equation.Text = value + " " + operation;
                }
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            operation_pressed = false;
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = Operator.Add(value, double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = Operator.Sub(value, double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = Operator.Times(value, double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    if (result.Text == "0")
                        MessageBox.Show("Division Into Infinity ? ");
                    result.Text = Operator.Div(value, double.Parse(result.Text)).ToString();
                    break;
                case "sqrt":
                    if (double.Parse(result.Text) < 0)
                        MessageBox.Show("See complex number i  ");
                    result.Text = Operator.Sqrt(double.Parse(result.Text)).ToString();
                    break;
                case "sq":
                    result.Text = Operator.PowToTwo(double.Parse(result.Text)).ToString();
                    break;
                case "1 / x":
                    if (result.Text == "0")
                        MessageBox.Show("Division Into Infinity ? ");
                    result.Text = Operator.OneDivX(double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = double.Parse(result.Text);
            operation = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());

            //if (e.KeyChar.ToString() == Keys.Enter.ToString())
            //    e.Handled == true;
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "sqrt":
                    sqrt.PerformClick();
                    break;
                case "sq":
                    powToTwo.PerformClick();
                    break;
                case "1 / x":
                    oneDivX.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }

    }
}