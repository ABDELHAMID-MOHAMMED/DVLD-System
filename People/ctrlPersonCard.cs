using DVLDBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;
using System.Xml.Linq;
using System.IO;
using DVLD.Resources;

namespace DVLD
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;

        private int _PersonID=-1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }
        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int  personID)
        {
            _Person= clsPerson.GetPersonInfoByID(personID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + personID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.GetPersonInfoByNationalNo(NationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with NationalNo = " + NationalNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonIDInfo.Text = "[????]";
            lblPersonNatNo.Text = "[????]";
            lblPersonName.Text = "[????]";
            pbGendor.Image = Properties.Resources.Man_32;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDOB.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersoninfo.Image =Properties.Resources.Male_512;
        }
        private void _LoadPersonInfo()
        {
            if (_Person.Gendor == 0)
                pbPersoninfo.Image = Properties.Resources.Male_512;
            else
                pbPersoninfo.Image = Properties.Resources.Female_512;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                    pbPersoninfo.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            _PersonID = _Person.ID;
            lblPersonIDInfo.Text = _PersonID.ToString();
            lblPersonName.Text = _Person.FullName;
            lblPersonNatNo.Text = _Person.NationalNo;
            lblGendor.Text = _Person.Gendor == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDOB.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            lblAddress.Text = _Person.Address;

            _LoadPersonInfo();
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddEditPersonInfo frm = new FrmAddEditPersonInfo(_PersonID);
            frm.ShowDialog();

            LoadPersonInfo(_PersonID);
        }
    }
}
