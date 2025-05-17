using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double first = 0;
        double second = 0;
        double result = 0;
        string operChecker = "";

        public void operation()
        {
            switch(operChecker)
            {
                case "+":
                    result = first + second;
                    textDisp.Text = Convert.ToString(result);
                    break;

                case "-":
                    result = first - second;
                    textDisp.Text = Convert.ToString(result);
                    break;
                
                case "*":
                    result = first * second;
                    textDisp.Text = Convert.ToString(result);
                    break;
                    
                case "/":
                    if (second == 0)
                    {
                        textDisp.Text = "Error";
                    }
                    else
                    {
                        result = first / second;
                        textDisp.Text = Convert.ToString(result);
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textDisp.Text += btn7.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textDisp.Text += btn9.Text;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            textDisp.Text += btn8.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textDisp.Text += btn6.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
             textDisp.Text += btn5.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textDisp.Text += btn4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textDisp.Text += btn3.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textDisp.Text += btn2.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textDisp.Text += btn1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textDisp.Text);
            textDisp.Text = "";
            operChecker = "+";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textDisp.Text);
            textDisp.Text = "";
            operChecker = "-";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textDisp.Text);
            textDisp.Text = "";
            operChecker = "*";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textDisp.Text += btn0.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(textDisp.Text);
            operation();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textDisp.Text);
            textDisp.Text = "";
            operChecker = "/";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textDisp.Text = "";
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textDisp.Text);
            first = first / 100;
            textDisp.Text += "%";
            textDisp.Text = Convert.ToString(first);
            
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            first= Convert.ToDouble(textDisp.Text);
            first = first * -1;
            textDisp.Text = Convert.ToString(first);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
