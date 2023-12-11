using cccc.Properties;
using Clinc_BussnissLayer;
using Guna.UI2.WinForms;
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
    public partial class MainFormForALLForms : Form
    {
        public MainFormForALLForms(string Username)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            CurrentUser = clsUser.Find(Username);
            lblCurrentUserUsername.Text = Username;
            if (CurrentUser.ImagePath != "")
                PictreForCurrentUser.Image = Image.FromFile(CurrentUser.ImagePath);
            else
                PictreForCurrentUser.Image = Resources.man__1_;
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


        Guna2Button CurrentButton;

        Form CurrentForm;

        clsUser CurrentUser;
        private void OpenChiledForm(Form ChildForm)
        {
            if (CurrentForm != null)
            {
                CurrentForm.Close();
            }

            CurrentForm = ChildForm;
            CurrentForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            PanelForForms.Controls.Add(ChildForm);
            PanelForForms.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            LabelForWhatFormWeOpen.Text = CurrentForm.Tag.ToString();
        }

        public void ActiveButtoun(object senderbutton)
        {
            if (senderbutton != null)
            {
                DesabliButton();
                CurrentButton = (Guna2Button)senderbutton;
                CurrentButton.FillColor = Color.White;
                CurrentButton.BackColor = Color.White;
                CurrentButton.ForeColor = Color.Black; 
                CurrentButton.TextOffset= new Point(25,0);
                CurrentButton.ImageOffset = new Point(25, 0);
            }
        }

        public void DesabliButton()
        {
            if (CurrentButton != null)
            {
                CurrentButton.FillColor = Color.RoyalBlue;
                CurrentButton.BackColor = Color.RoyalBlue;
                CurrentButton.ForeColor = Color.White;
                CurrentButton.TextOffset = new Point(0, 0);
                CurrentButton.ImageOffset = new Point(0, 0);
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashpord_Click(object sender, EventArgs e)
        {
            ActiveButtoun(sender);
            OpenChiledForm(new DashpordForm());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            ActiveButtoun(sender);
            OpenChiledForm(new PatientsForm());
        }

        private void btnDocotrs_Click(object sender, EventArgs e)
        {
            if (!CheakAccess(CurrentUser))
            {
                MessageBox.Show("You Dont Have Access To This Future , Contat Wit your Admin.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            ActiveButtoun(sender);
            OpenChiledForm(new DoctorsForm());
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            if (!CheakAccess(CurrentUser))
            {
                MessageBox.Show("You Dont Have Access To This Future , Contat Wit your Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ActiveButtoun(sender);
            OpenChiledForm(new AppointmentsForm());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (!CheakAccess(CurrentUser))
            {
                MessageBox.Show("You Dont Have Access To This Future , Contat Wit your Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ActiveButtoun(sender);
            OpenChiledForm(new PaymentsFomr());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!CheakAccess(CurrentUser))
            {
                MessageBox.Show("You Dont Have Access To This Future , Contat Wit your Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ActiveButtoun(sender);
            OpenChiledForm(new UsersForm());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ActiveButtoun(sender);
            CurrentUser = null;
            Login New=new Login();
            New.Show();
            this.Close();
        }

        private bool CheakAccess(clsUser User)
        {
            if (User.IsActive == "Yes")
            {
                return true;
            }
            else
                return false;
        }

  
    }
}
