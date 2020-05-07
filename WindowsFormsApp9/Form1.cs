using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void f(double x, out double y)
        {      
            if (x > 0) y = x;
            else if ((-1) <= x && x <= 0) y = 0;
            else y = x * x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(A.Text);
                double b = double.Parse(B.Text);
                double h = double.Parse(H.Text);
                double y;
                if (h > 0 && b > a)
                {

                    for (double i = a; i <= b; i += h)
                    {
                        f(i, out y);
                        rez.Text += "f(";
                        rez.Text += i;
                        rez.Text += ") = ";
                        rez.Text += y;
                        rez.Text += Environment.NewLine;
                    }
                }
                else { rez.Text = "Некорректный ввод!"; }
            }
            catch { rez.Text = "Некорректный ввод!"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rez.Clear();
        }
    }
}
