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
    public partial class EditMedicalRecordForm : Form
    {
        public EditMedicalRecordForm(int recordID)
        {
            InitializeComponent();
            RecordID = recordID;
        }

        int RecordID;
        clsMedecalRecords _Record;
        private void EditMedicalRecordForm_Load(object sender, EventArgs e)
        {
            clsMedecalRecords Record = clsMedecalRecords.Find(RecordID);

            lblRecordID.Text=RecordID.ToString();
            TxtDescription.Text = Record.VisitDescrition;
            TxtDiagnosis.Text = Record.Diognas;
            TxtNotes.Text = Record.Notes;
            _Record= Record;

        }


        void UpdateRecord()
        {
            _Record.VisitDescrition = TxtDescription.Text;
            _Record.Diognas = TxtDiagnosis.Text;
            _Record.Notes= TxtNotes.Text;
            _Record.RecordID= RecordID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateRecord();

            if(_Record.Save())
            {
                MessageBox.Show("Record Succssfilly Updated", "Medical Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Record Does Not Updated", "Medical Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }




    }
}
