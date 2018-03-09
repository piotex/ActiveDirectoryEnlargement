using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProlichtAD
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            for (int i = 0; i < 1000; i++)
            {
                textBox1.Text += i.ToString() + "\r\n";
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar a = vScrollBar1;
            if (a.Value > 0)
            {
                textBox1.SelectionStart = 10;
                textBox1.ScrollToCaret();
            }
        }
    }
}
