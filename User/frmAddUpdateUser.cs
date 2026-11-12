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

namespace DVLD
{
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew=0, Update=1};
        private enMode _Mode;
        private int _UserID = -1;
        clsUser _User;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateUser(int  UserID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _UserID = UserID;
        }
        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();


                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                btnSave.Enabled = true;
            }

            
        }
        private void _LoadData()
        {
            _User = clsUser.FindByUserID(_UserID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            if (_User == null)
            {
                MessageBox.Show("NO User with ID = "+_UserID,"User Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();

                return;
            }
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName.ToString();
            txtPassword.Text = _User.Password.ToString();
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);

            }
        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if(_Mode == enMode.Update)
            _LoadData();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tpLoginInfo"];
                return;
            }

            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {
                if(clsUser.isUserExistForPersonID(ctrlPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tabControl1.SelectedTab = tabControl1.TabPages["tpLoginInfo"];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = chkIsActive.Checked;

            if(_User.Save())
            {
                lblUserID.Text =_User.UserID.ToString();

                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
                this.Text = "Update User";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtPassword_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
            ;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_Validating_1(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "User Name Can Not Be Blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtConfirmPassword_Validating_1(object sender, CancelEventArgs e)
        {
            if(txtConfirmPassword.Text.Trim()!=txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
            
        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
