using Clinc_BussnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cccc
{
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
        }


        public string Username;


         public  void FillDataToControl(string username)
         {
            clsUser User = clsUser.Find(username);
            lblUserID.Text = User.UserID.ToString();
            lblUsername.Text = username;
            Username = username;
         }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditUserForm New = new EditUserForm(Username);
            New.ShowDialog();
        }
    }
}
