using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_лаба_1_номер
{
    public partial class Form1 : Form
    {
        int[] Array = new int[10];
        Random Rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i=0; i<10; i++)
            {
                Array[i] = Rand.Next(-10, 10);
                listBox1.Items.Add(String.Format("a[{0,1}] = {1,5}", i, Array[i]));
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Array[i]>0)
                {
                    sum += Array[i];
                }
                label1.Text = sum.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int otr = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Array[i] > 0)
                {
                    otr++;
                }
                label2.Text = otr.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            double k = Convert.ToDouble(textBox1.Text);
            for (int i = 0; i < 10; i++)
            {
                if (Array[i] > k)
                {
                    a++;
                }
                else if (Array[i] <k)
                {
                    b++;
                }
                else { c++; }
                label3.Text = "кол-во чисел больше k: " + a.ToString() 
                    + '\n' + "кол-во чисел меньше k: " + b.ToString()
                    + '\n' + "кол-во чисел равных k: " + c.ToString();
            }
        }
    }
}
