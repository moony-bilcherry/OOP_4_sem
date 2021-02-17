using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int MemoryValue = 0;

        private int Calculate()
        {
            string[] words = textBox1.Text.Split(new Char[] { '+', '-', '*', '/', '%' });
            int count = 0;
            int res = Convert.ToInt32(words[count]);
            count++;
            
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                switch (textBox1.Text[i])
                {
                    case '+':
                        {
                            res += Convert.ToInt32(words[count]);
                            count++;
                            break;
                        }
                    case '-':
                        {
                            res -= Convert.ToInt32(words[count]);
                            count++;
                            break;
                        }
                    case '*':
                        {
                            res *= Convert.ToInt32(words[count]);
                            count++;
                            break;
                        }
                    case '/':
                        {
                            res /= Convert.ToInt32(words[count]);
                            count++;
                            break;
                        }
                    case '%':
                        {
                            res %= Convert.ToInt32(words[count]);
                            count++;
                            break;
                        }
                    
                }
            }
            return res;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)         // =
        {
            try
            {
                int result = Calculate();
                textBox1.Clear();
                textBox1.AppendText("= " + result);
            }
            catch (Exception ex)
            {
                textBox1.Clear();
                textBox1.AppendText("ERROR");
                MessageBox.Show(ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";
        }

        private void button26_Click(object sender, EventArgs e)     //M store
        {
            MemoryValue = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            textBox1.AppendText("Value saved to M");
        }

        private void button20_Click(object sender, EventArgs e)     //M
        {
            textBox1.Text += MemoryValue;
        }

        private void button27_Click(object sender, EventArgs e)     //M clear
        {
            MemoryValue = 0;
            textBox1.Clear();
            textBox1.AppendText("M cleared");
        }
    }
}
