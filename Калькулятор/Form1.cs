using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        byte oper = 0;
        float a;
        float b;
        bool clicker = false;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Oper(char a)
        {
            label1.Text = textBox1.Text + a;
            this.a = float.Parse(textBox1.Text);
            textBox1.Clear();
            clicker = false;
        }
        private void calculate()
        {
            switch (oper)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                default: break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
               
        }

            private void button1_Click(object sender, EventArgs e)
            {
            textBox1.Text = textBox1.Text + 1;
            }

            private void button2_Click(object sender, EventArgs e)
            {
            textBox1.Text = textBox1.Text + 2;
            }
            private void button3_Click(object sender, EventArgs e)
            {
            textBox1.Text = textBox1.Text + 3;
            }

            private void button4_Click(object sender, EventArgs e)
            {
            textBox1.Text = textBox1.Text + 4;
            }
            private void button5_Click(object sender, EventArgs e)
            {
            textBox1.Text = textBox1.Text + 5;
            }

            private void button6_Click(object sender, EventArgs e)
            {
            textBox1.Text = textBox1.Text + 6;
            }
            private void button7_Click(object sender, EventArgs e)
            {
            textBox1.Text = textBox1.Text + 7;
            }

            private void button8_Click(object sender, EventArgs e)
            {
            textBox1.Text = textBox1.Text + 8;
            }
            private void button9_Click(object sender, EventArgs e)
            {
            textBox1.Text = textBox1.Text + 9;
            }

            private void button10_Click(object sender, EventArgs e)
            {
            textBox1.Text = textBox1.Text + 0;
            }
             private void button17_Click(object sender, EventArgs e)
             {
             textBox1.Text = textBox1.Text + ',';
             }
            private void SumButton_Click(object sender, EventArgs e)
            {
            Oper('+');
            oper = 1;
            }
            private void DifButton_Click(object sender, EventArgs e)
            {
            Oper('-');
            oper = 2;
            }
            private void DivButton_Click(object sender, EventArgs e)
            {
            Oper('/');
            oper = 3;
            }
            private void MulButton_Click(object sender, EventArgs e)
            {
            Oper('*');
            oper = 4;
            }
            private void BcspButton_Click(object sender, EventArgs e)
            {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++) { textBox1.Text = textBox1.Text + text[i]; }
            }


        private void ClrButton_Click(object sender, EventArgs e)
            {
                textBox1.Clear();
                label1.Text = null;
            }
            private void NegButton_Click(object sender, EventArgs e)
            {
                if (clicker == true)
                {
                    textBox1.Text =  textBox1.Text.Remove(0,1);
                    clicker = false;
                }
                else
                {
                textBox1.Text = '-' + textBox1.Text;
                clicker = true;
                }
            }
            private void ResButton_Click(object sender, EventArgs e)
            {
            calculate();
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



