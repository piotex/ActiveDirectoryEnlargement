using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rob
{
    public partial class Form1 : Form
    {
        private int a = 0;
        private Timer t;

        public Form1()
        {
            InitializeComponent();
            t = new Timer();
            t.Interval = 50;
            t.Tick += TOnTick;
            t.Start();
        }

        private void TOnTick(object sender, EventArgs eventArgs)
        {
            a++;
            MessageBox.Show("error");
            if (a> 200)
            {
                t.Stop();
            }
        }
    }
}
