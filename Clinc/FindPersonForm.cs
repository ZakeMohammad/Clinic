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
    public partial class FindPersonForm : Form
    {
        public FindPersonForm()
        {
            InitializeComponent();
        }

        public int PersonID;

        public delegate void DataBackEventhandler(object sender, int personid);

        public event DataBackEventhandler BackData;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsPerson Person = clsPerson.Find(Convert.ToInt32(TxtPersonIDSearch.Text));

            if(Person == null)
            {
                return;
            }
            else
            {
                PersonID = Convert.ToInt32(TxtPersonIDSearch.Text);
                ctrlPersonInfo1.FIllDataPersonToControl(PersonID);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {          
            BackData?.Invoke(this,PersonID);
            this.Close();
        }

    }
}
