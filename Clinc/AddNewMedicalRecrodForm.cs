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
    public partial class AddNewMedicalRecrodForm : Form
    {
        public AddNewMedicalRecrodForm()
        {
            InitializeComponent();
        }
        public delegate void DataBackEventhandler(object sender, int rercordid);

        public event DataBackEventhandler BackData;

        int RecordID;

        private void AddNewMedicalRecrodForm_Load(object sender, EventArgs e)
        {
            btnAddPrescription.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsMedecalRecords records= new clsMedecalRecords();

            records.VisitDescrition=TxtVisitDescription.Text;
            records.Diognas=TxtDiognoos.Text;
            records.Notes=TxtAdditionalNote.Text;

            if(records.Save())
            {
                RecordID = records.RecordID;
                btnAddPrescription.Enabled=true;

                BackData.Invoke(this, RecordID);
                MessageBox.Show("Medical Record Has Been Added","Medical Record",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Medical Record  Does Not Added", "Medical Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            AddNewPrescriptionForm frm = new AddNewPrescriptionForm(RecordID);
            frm.ShowDialog();
        }



    }
}
