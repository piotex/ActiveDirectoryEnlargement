using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProlichtAD.Code;

namespace ProlichtAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Config();
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Config()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FolderPathButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(UserIdTextBox.Text))
            {
                MessageBox.Show("Path is incortect");
            }
            else
            {
                CodeFactory.strFolderPath = UserIdTextBox.Text;
                CodeFactory.GetUserList(EFiltration.UsersFromPath);
                UsersForm user = new UsersForm();
                user.Show();
            }
        }

        private void UserIdButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(UserIdTextBox.Text))
            {
                MessageBox.Show("User is incortect");
            }
            else
            {
                CodeFactory.strFolderPath = UserIdTextBox.Text;
                CodeFactory.GetUserList(EFiltration.FoldersFromUser);
                UsersForm user = new UsersForm();
                user.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
