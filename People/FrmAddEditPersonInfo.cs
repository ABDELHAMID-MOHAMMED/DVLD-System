using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Resources
{
    public partial class FrmAddEditPersonInfo : Form
    {
        private int _PersonID = -1;

        public delegate void DataBackEventHandler(Object Sender, int PersonID);
        public event DataBackEventHandler DataBack;
        public FrmAddEditPersonInfo()
        {
            InitializeComponent();
            ctrlPersonInfo1.DataSaved += OnPersonSaved;
        }

        public FrmAddEditPersonInfo(int PersonID):this()
        {
            _PersonID = PersonID;
        }
        private void OnPersonSaved(int PersonID)
        {
            lblPersonID.Text = PersonID.ToString();
            lblAddOrEditPerson.Text = "Edit Person";
        }
        private void lblAddOrEditPerson_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddEditPersonInfo_Load(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                lblAddOrEditPerson.Text = "Edit Person";
                lblPersonID.Text = _PersonID.ToString();
                ctrlPersonInfo1.LoadPersonInfo(_PersonID);
            }
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
