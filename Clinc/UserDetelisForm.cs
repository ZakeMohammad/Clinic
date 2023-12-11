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
    public partial class UserDetelisForm : Form
    {
        public UserDetelisForm(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string Username;

        private void UserDetelisForm_Load(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(Username);

            ctrlPersonInfo1.FIllDataPersonToControl(User.PersonID);
            ctrlUserInfo1.FillDataToControl(Username);
        }
    }
}
