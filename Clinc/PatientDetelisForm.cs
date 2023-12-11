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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace cccc
{
    public partial class PatientDetelisForm : Form
    {
       
        public PatientDetelisForm(int patiantID=-1)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            PatiantID = patiantID;
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

        public int PatiantID;


        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void PatientDetelisForm_Load(object sender, EventArgs e)
        {
            clsPatients Patient = clsPatients.Find(PatiantID);           
           
            ctrlPersonInfo1.FIllDataPersonToControl(Patient.PersonID);
          
            ctrlPatientInfo1.FillDataPateintToControl(PatiantID);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
