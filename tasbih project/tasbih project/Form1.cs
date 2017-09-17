using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasbih_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i;
        private void سبحان_الله_Click(object sender, EventArgs e)
        {
            i++;
            button1.Text = i.ToString();

        }
        int a;
        private void الله_اكبر_Click(object sender, EventArgs e)
        {
            a++;
            button2.Text = a.ToString();

        }
        int b;
        private void لا_اله_الا_الله_Click(object sender, EventArgs e)
        {
            b++;
            button4.Text = b.ToString();
        }
        int c;
        private void الحمد_لله_Click(object sender, EventArgs e)
        {
            c++;
            button3.Text = c.ToString();

        }
        int d;
        private void لا_حول_Click(object sender, EventArgs e)
        {
            d++;
            button8.Text = d.ToString();

        }
        int f;
        private void العظم_وبحمدة_Click(object sender, EventArgs e)
        {
            f++;
            button7.Text = f.ToString();

        }
        int y;
        private void استغفر_الله_Click(object sender, EventArgs e)
        {
            y++;
            button6.Text = y.ToString();

        }
        int k;
        private void اللهم_صلي_Click(object sender, EventArgs e)
        {

            k++;
            button5.Text = k.ToString();
        }
    }
}
