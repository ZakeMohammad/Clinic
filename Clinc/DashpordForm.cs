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
    public partial class DashpordForm : Form
    {
        public DashpordForm()
        {
            InitializeComponent();
        }

        private void DashpordForm_Load(object sender, EventArgs e)
        {
           lblDoctors.Text=clsDoctor.NumberOfDoctors().ToString();
            lblAppointments.Text=clsAppointments.NumberOfAppointments().ToString();
            lblPatients.Text=clsPatients.NumberOfPatients().ToString(); 
            lblPayments.Text=clsPayments.NumberOfPayments().ToString(); 
            lblUsers.Text=clsUser.NumberOfUsers().ToString();   
        }
    }
}
