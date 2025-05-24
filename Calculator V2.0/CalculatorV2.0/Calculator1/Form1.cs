using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double first = 0;
        double second = 0;
        double result = 0;
        string operChecker = "";
        string history = "";
        bool isEqualsPressed = false;


        public void operation()
        {
            switch (operChecker)
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
        private void rjButton3_Click_2(object sender, EventArgs e)
        {
            if (isEqualsPressed == true)
            {
                textDisp.Text = "";
                textDisp.Text += btn9.Text;
            }
            else
            {
                textDisp.Text += btn9.Text;
            }
        }
        private void rjButton1_Click_2(object sender, EventArgs e)
        {
            if (isEqualsPressed == true)
            {
                textDisp.Text = "";
                textDisp.Text += btn8.Text;
            }
            else
            {
                textDisp.Text += btn8.Text;
            }
        }
        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (isEqualsPressed == true)
            {
                textDisp.Text = "";
                textDisp.Text += btn7.Text;
            }
            else
            {
                textDisp.Text += btn7.Text;
            }
        }
        private void rjButton2_Click_2(object sender, EventArgs e)
        {
            if (isEqualsPressed == true)
            {
                textDisp.Text = "";
                textDisp.Text += btn6.Text;
            }
            else
            {
                textDisp.Text += btn6.Text;
            }
        }
        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            if (isEqualsPressed == true)
            {
                textDisp.Text = "";
                textDisp.Text += btn5.Text;
            }
            else
            {
                textDisp.Text += btn5.Text;
            }
        }
        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            if (isEqualsPressed == true)
            {
                textDisp.Text = "";
                textDisp.Text += btn4.Text;
            }
            else
            {
                textDisp.Text += btn4.Text;
            }
        }
        private void rjButton1_Click_3(object sender, EventArgs e)
        {
            if (isEqualsPressed == true)
            {
                textDisp.Text = "";
                textDisp.Text += btn3.Text;
            }
            else
            {
                textDisp.Text += btn3.Text;
            }
        }
        private void rjButton3_Click_1(object sender, EventArgs e)
        {
            if (isEqualsPressed == true)
            {
                textDisp.Text = "";
                textDisp.Text += btn2.Text;
            }
            else
            {
                textDisp.Text += btn2.Text;
            }
        }
        private void rjButton3_Click(object sender, EventArgs e)
        {

            if (isEqualsPressed == true)
            {
                textDisp.Text = "";
                textDisp.Text += btn1.Text;
            }
            else
            {
                textDisp.Text += btn1.Text;
            }
        }
        private void rjButton1_Click_4(object sender, EventArgs e)
        {
            if (isEqualsPressed == true)
            {
                textDisp.Text = "";
                textDisp.Text += btn0.Text;
            }
            else
            {
                textDisp.Text += btn0.Text;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                first = Convert.ToDouble(textDisp.Text);
                textDisp.Text = "";
                operChecker = "+";

            }
            catch (System.FormatException) { }

        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                first = Convert.ToDouble(textDisp.Text);
                textDisp.Text = "";
                operChecker = "*";
            }
            catch (System.FormatException) { }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                second = Convert.ToDouble(textDisp.Text);
                operation();
            }
            catch (System.FormatException) { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            textDisp.Text = "";
            textBox1.Text = "";
            isEqualsPressed = false;

        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            try
            {
                first = Convert.ToDouble(textDisp.Text);
                first = first * -1;
                textDisp.Text = Convert.ToString(first);
            }
            catch (System.FormatException) { }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                first = Convert.ToDouble(textDisp.Text);
                history = Convert.ToString(textDisp.Text) + "%";
                textBox1.Text = history;
                first = first / 100;
                textDisp.Text += "%";
                textDisp.Text = Convert.ToString(first);
                

            }
            catch (System.FormatException) { }
        }

        private void btnDiv_Click_1(object sender, EventArgs e)
        {
            try
            {
                first = Convert.ToDouble(textDisp.Text);
                history = Convert.ToString(first) + "÷";
                textBox1.Text = history;
                textDisp.Text = "";
                operChecker = "/";
                isEqualsPressed = false;
            }
            catch (System.FormatException) { }
        }
        private void rjButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEqualsPressed == false)
                {
                    second = Convert.ToDouble(textDisp.Text);
                    history += Convert.ToString(second);
                    textBox1.Text = history;
                    operation();
                    isEqualsPressed = true;
                }
                else
                {
                    return;
                }
                    
            }
            catch (System.FormatException) { }
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            try
            {
                first = Convert.ToDouble(textDisp.Text);
                history = Convert.ToString(first) + "+";
                textBox1.Text = history;
                textDisp.Text = "";
                operChecker = "+";
                isEqualsPressed=false;

            }
            catch (System.FormatException) { }
        }

        private void rjButton3_Click_3(object sender, EventArgs e)
        {
            try
            {
                first = Convert.ToDouble(textDisp.Text);
                history = Convert.ToString(first) + "-";
                textBox1.Text = history;
                textDisp.Text = "";
                operChecker = "-";
                isEqualsPressed = false;
            }
            catch (System.FormatException) { }
        }

        private void rjButton1_Click_5(object sender, EventArgs e)
        {
            try
            {
                first = Convert.ToDouble(textDisp.Text);
                history = Convert.ToString(first) + "×";
                textBox1.Text = history;
                textDisp.Text = "";
                operChecker = "*";
                isEqualsPressed = false;
            }
            catch (System.FormatException) { }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void rjButton1_Click_6(object sender, EventArgs e)
        {
            if (isEqualsPressed)
            {
                textDisp.Text = "0,";
                isEqualsPressed = false;
            }
            else if (!textDisp.Text.Contains(","))
            {
                if (textDisp.Text == "")
                    textDisp.Text = "0,";
                else
                    textDisp.Text += ",";
            }
        }
    }
}
