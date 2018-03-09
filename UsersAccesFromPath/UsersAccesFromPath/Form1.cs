using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersAccesFromPath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Config();
        }

        private Folder folder;

        private void Config()
        {
            folder = new Folder();
        }

        private int size = 0;
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string path = FolderPathTextBox.Text;
            if (Directory.Exists(path))
            {
                List<User> list = folder.GetUsersList(path);
                var groupList = list.GroupBy(u => u.TypeOfControl).Select(grp => grp.ToList()).ToList();

                foreach (var group in groupList)
                {
                    foreach (var user in group)
                    {
                        textBox1.Text += user.Login + "\r\n";
                        textBox2.Text += user.TypeOfControl + "\r\n";
                    }
                }
                textBox1.Text += "--------------------------------------------------------------------------" + "\r\n";
                textBox2.Text += "-------------------------------------------------------------------------------------------------------------------" + "\r\n";
                size += list.Count;
                if (size * 23 > textBox1.Height)
                {
                    textBox1.Height = size * 23;
                    textBox2.Height = size * 23;
                }
            }
            else
            {
                MessageBox.Show("Provided path is invalid", "Path ERROR");
            }
        }
    }
}
