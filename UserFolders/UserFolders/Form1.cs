using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserFolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            config();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 1; x <= 50; x++)
            {
                listBox1.Items.Add("Item " + x.ToString());
            }
            listBox1.SetSelected(1, true);
        }

        public void config()
        {
            Logic logic = new Logic();
            //logic.GetUserFolders(@"TEST0\AdminTG", @"C:\Users\Administrator\Desktop\test\1\11\121\1211");
            var a  = logic.GetUserFolders(@"TEST0\AdminTG", @"C:\");
            foreach (var b in a)
            {
                textBox1.Text += b + "\r\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
