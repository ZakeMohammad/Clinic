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
    public partial class MedicalRecordInfoForm : Form
    {
        public MedicalRecordInfoForm(int medialRecordID)
        {
            InitializeComponent();
            MedialRecordID = medialRecordID;
        }

        int MedialRecordID;

        private void MedicalRecordInfoForm_Load(object sender, EventArgs e)
        {
            clsMedecalRecords Record = clsMedecalRecords.Find(MedialRecordID);

            lblDescription.Text = Record.VisitDescrition;
            lblDiagnos.Text=Record.Diognas.ToString();
            lblNotes.Text = Record.Notes.ToString();
            lblRecordID.Text=Record.RecordID.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
