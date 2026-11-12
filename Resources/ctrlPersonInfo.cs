using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DVLDBussinessLayer;
using System.IO;
namespace DVLD.Resources
{
    public partial class ctrlPersonInfo : UserControl
    {
        public enum enMode { AddNew=0, Update=1};
       private enMode _Mode= enMode.AddNew;

        private int _PersonID = -1;
        private clsPerson _Person;

        public int PersonID => _PersonID;
        public clsPerson SelectedPersonInfo => _Person;

        public ctrlPersonInfo()
        {
            InitializeComponent();
        }
        private bool _HandlePersonImage()
        {
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (Exception ex)
                    {
                       
                    }
                    if (pbPersonImage.ImageLocation != null)
                    {
                        string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                        if (clsUtil.CopyImageToProjectImageFolder(ref SourceImageFile))
                        {
                            pbPersonImage.ImageLocation = SourceImageFile;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
                return true;
        }
        public void LoadPersonInfo(int personID)
        {
            _Person = clsPerson.GetPersonInfoByID(personID);

            if (_Person == null)
            {
                MessageBox.Show("Coud Not Found Selected Person","Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Mode = enMode.Update;
            _PersonID = personID;

            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            dateTimePicker1.Value = _Person.DateOfBirth;

            if (_Person.Gendor == 0)
                rdMale.Checked = true;
            else
                rdFemal.Checked = true;

            comboBox1.SelectedValue = _Person.NationalityCountryID;

            if(!string.IsNullOrEmpty(_Person.ImagePath)&& System.IO.File.Exists(_Person.ImagePath))
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
                llRemoveImage.Visible = true;
            }
            else
            {
                pbPersonImage.ImageLocation= null;
                UpdateDefultImage();
                llRemoveImage.Visible= false;
            }
        }
        private void ctrlPersonInfo_Load(object sender, EventArgs e)
        {
            rdMale.Checked = true;
            DataTable DataCountries = clsCountry.GetAllCountries();
            comboBox1.DataSource = DataCountries;
            comboBox1.DisplayMember = "CountryName";
            comboBox1.ValueMember = "CountryID";
        }
        private void UpdateDefultImage()
        {
            if (!string.IsNullOrEmpty(pbPersonImage.ImageLocation))
                return;

            if (rdMale.Checked)
            {
                pbPersonImage.Image = Properties.Resources.Male_512;
            }
            else if (rdFemal.Checked)
            {
                pbPersonImage.Image = Properties.Resources.Female_512;
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text.Trim()))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "FirstName Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtSecondName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSecondName.Text.Trim()))
            {
                e.Cancel= true;
                txtSecondName.Focus();
                errorProvider1.SetError(txtSecondName, "SecondName Requaired");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSecondName, "");
            }
        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtThirdName.Text.Trim()))
            {
                e.Cancel= true;
                txtThirdName.Focus();
                errorProvider1.SetError(txtThirdName, "ThirdName Requaired");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtThirdName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtLastName.Text.Trim()))
            {
                e.Cancel= true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "LastName Requaired");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace (txtEmail.Text.Trim()))
            {
                e.Cancel= false;
                errorProvider1.SetError(txtEmail, "");
                return;
            }

            string Pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if(!Regex.IsMatch(txtEmail.Text, Pattern))
            {
                e.Cancel= true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Invalid Email");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            int Age = DateTime.Today.Year - dateTimePicker1.Value.Year;
            if (dateTimePicker1.Value.Date > DateTime.Today.AddYears(Age)) Age--;
            
            if(Age<18)
            {
                e.Cancel=true;
                errorProvider1.SetError(dateTimePicker1, "Person must be at least 18 years old");
            }
            else
            {
                e.Cancel=false;
                errorProvider1.SetError(dateTimePicker1, "");
            }
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDefultImage();
        }

        private void rdFemal_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDefultImage();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter= "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.InitialDirectory = @"C:\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SelectedFilePath = openFileDialog1.FileName;

                pbPersonImage.Load(SelectedFilePath);
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            UpdateDefultImage();
            llRemoveImage.Visible=false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
        public event Action<int> DataSaved;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some Fileds are not Valid, Put the mouse Over the red icon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            if(_Mode==enMode.AddNew)
                _Person= new clsPerson();
            
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.DateOfBirth = dateTimePicker1.Value;

            if (rdMale.Checked)
                _Person.Gendor = 0;
            else _Person.Gendor = 1;

            _Person.NationalityCountryID = (int)comboBox1.SelectedValue;
            _Person.ImagePath = pbPersonImage.ImageLocation ?? "";

            if (_Person.Save())
            {
                _PersonID = _Person.ID;
                _Mode = enMode.Update;

                MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataSaved?.Invoke(_Person.ID);
               
            }
            else
            {
                MessageBox.Show("Error: Data Is Not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void txtNationalNo_TextChanged(object sender, CancelEventArgs e)
        {
            string nationalNo = txtNationalNo.Text.Trim();
            if (string.IsNullOrEmpty(nationalNo))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "this field is Required!");
                return;
            }
            bool changed = (_Mode == enMode.AddNew) || (_Person != null && nationalNo != _Person.NationalNo);

            
            if (changed && clsPerson.IsPersonExist(nationalNo))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "National Number is Used For Another Person!");
                return;
            }
            e.Cancel = false;
            errorProvider1.SetError(txtNationalNo, "");
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            string nationalNo = txtNationalNo.Text.Trim();

            if (string.IsNullOrEmpty(nationalNo))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This field is required!");
                return;
            }

            
            bool isNationalNoExist = clsPerson.IsPersonExist(nationalNo);

            if (_Mode == enMode.AddNew)
            {
                if (isNationalNoExist)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtNationalNo, "National Number is used for another person!");
                    return;
                }
            }
            else 
            {
                if (_Person != null && nationalNo != _Person.NationalNo && isNationalNoExist)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtNationalNo, "National Number is used for another person!");
                    return;
                }
            }

            e.Cancel = false;
            errorProvider1.SetError(txtNationalNo, "");
        }
    }
}
