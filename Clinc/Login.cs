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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                }
            }
            base.WndProc(ref m);
        }


        int NumberOfTimes =3;


        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (TxtUsername.Text == string.Empty || TxtPassword.Text == string.Empty)
            {
                MessageBox.Show("Plese Enter Username / Passwrod", "CLinic", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            clsUser User = clsUser.Find(TxtUsername.Text.ToString());

            if (User != null)
            {

                if (User.Password == TxtPassword.Text.ToString())
                {
                    MainFormForALLForms MainFormforuser = new MainFormForALLForms(User.Username);

                    MainFormforuser.Show();
                    this.Hide();
                }
                else
                {
                    NumberOfTimes--;
                    if (NumberOfTimes == 0)
                    {
                        btnLogin.Enabled = false;
                      
                        TxtPassword.Enabled = false;
                        TxtUsername.Enabled = false;

                        if (MessageBox.Show("❗ You Blocked From Systme, Are You whant to Sin Up Again?", "Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            btnLogin.Enabled = true;
                          
                            TxtPassword.Enabled = true;
                            TxtUsername.Enabled = true;
                            NumberOfTimes = 3;
                        }
                        else
                        {
                            this.Close();
                            return;
                        }
                    }
                    lblWrongOrNot.Text = $"❗ Wrong Password You Have only {NumberOfTimes} Times";
                }
            }
            else
            {
                MessageBox.Show("User Does Not Exist", "Clinic", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
          

        }
    }
}
