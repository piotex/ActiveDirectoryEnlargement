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

        }

        public void config()
        {
            Logic logic = new Logic();
            logic.GetUserFolders(@"BUILTIN\Administrators", @"C:\Users\Administrator\Desktop\test");
        }

    }
}
