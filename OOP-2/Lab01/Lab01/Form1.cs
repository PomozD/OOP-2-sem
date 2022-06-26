using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        Calculation Calc;
        int countOfPress = 0;

        double result = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        bool znak = true;

        public Form1()
        {
            InitializeComponent();
            Calc = new Calculation();
            textBox1.Text = "0"; // значение 0 в поле
        }

        private void button_click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" || isOperationPerformed)
                {
                        textBox1.Clear(); // при вводе числа поле очищается от 0
                }
                isOperationPerformed = false;
                Button button = (Button)sender;
                if (button.Text == ",")
                {
                    if (textBox1.Text[0] == ',') // исключение при вводе , первым
                        throw new Exception("Неверный формат!");
                    if (!textBox1.Text.Contains(","))
                        textBox1.Text = textBox1.Text + button.Text; // ввод иррационального числа
                }
                else
                    textBox1.Text = textBox1.Text + button.Text; // запись в поле вводимого числа
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            try
            {

                Button button = (Button)sender;
                operationPerformed = button.Text;
                result = double.Parse(textBox1.Text);
                labelCurrentOperation.Text = result + " " + operationPerformed;
                isOperationPerformed = true;
                znak = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonC_Click(object sender, EventArgs e)
        {
            // очистка поля
            textBox1.Text = "0";
            result = 0;
            labelCurrentOperation.Text = "";
            countOfPress = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operationPerformed)
                {
                    //считывание введенного числа и операции с введенным числом записывание в textBox1.Text и вывод в поле 
                    case "+":
                        textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                        break;
                    case "*":
                        textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                        break;
                    case "/":
                        if (double.Parse(textBox1.Text) != 0)
                        {
                            textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                        }
                        else
                        {
                            throw new Exception("Error!\nDivide by zero");
                        }
                            break;
                    case "%":
                        textBox1.Text = (result % double.Parse(textBox1.Text)).ToString();
                        break;
                    default:
                        break;
                }
                result = double.Parse(textBox1.Text);
                labelCurrentOperation.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0]=='-')
            {
                znak = false;
            }
            if (znak)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            } else if(znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void buttonMRC_Click(object sender, EventArgs e)
        {
            countOfPress++;
            if (countOfPress == 1)
            {
                textBox1.Text = Calc.MemoryShow().ToString(); // при одном нажатии вывод числа из памяти
            }
            if (countOfPress == 2) // при двух нажатиях память очищается с в поле выводится 0
            {
                Calc.Memory_Clear();
                textBox1.Text = "0";
                countOfPress = 0;
            }
        }
        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            Calc.M_Sum(double.Parse(textBox1.Text)); // сложение числа из памяти с введенным
        }
        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            Calc.M_Sub(double.Parse(textBox1.Text)); // вычитание числа из памяти с введенным
        }
        
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyValue!=8 && e.KeyValue!=13)
                throw new Exception("Неверный формат");
            }
            catch (Exception ex)
            {
                textBox1.Text = "0";
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
