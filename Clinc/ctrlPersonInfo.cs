using cccc.Properties;
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
    public partial class ctrlPersonInfo : UserControl
    {
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        public int PersonID { get; set; }
       
       public void FIllDataPersonToControl(int PersonID)
        {
            clsPerson Person = clsPerson.Find(PersonID);

            lblAddress.Text=Person.Address;
            lblEmail.Text=Person.Email;
            lblGender.Text=Person.Gender.ToString();
            lblBirthDate.Text=Person.DateOfBirth.ToShortDateString();
            lblPersonID.Text=Person.PersonID.ToString();

            if(Person.ImagePath!="")
            {
                PictreForPerson.Image=Image.FromFile(Person.ImagePath);
            }
            else
            {
                PictreForPerson.Image = Resources.man__1_;
            }

            lblPersonName.Text=Person.Name;
            lblPhone.Text = Person.PhoneNumber;
         
        }

    }
}
