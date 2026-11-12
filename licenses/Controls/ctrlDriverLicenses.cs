using DVLDBussinessLayer;
using DVLD.licenses.Local_Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DVLD.licenses.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID;
        private clsDriver _Driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }
        private void _LoadLocalLicenseInfo()
        {

            _dtDriverLocalLicensesHistory = clsDriver.GetLicenses(_DriverID);


            dgvLocalLicensesHistory.DataSource = _dtDriverLocalLicensesHistory;
            lblLocalLicensesRecords.Text = dgvLocalLicensesHistory.Rows.Count.ToString();

            if (dgvLocalLicensesHistory.Rows.Count > 0)
            {
                
                dgvLocalLicensesHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dgvLocalLicensesHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dgvLocalLicensesHistory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
                dgvLocalLicensesHistory.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvLocalLicensesHistory.GridColor = Color.LightGray;

                dgvLocalLicensesHistory.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicensesHistory.Columns[0].Width = 80;

                dgvLocalLicensesHistory.Columns[1].HeaderText = "App.ID";
                dgvLocalLicensesHistory.Columns[1].Width = 80;

                dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
                dgvLocalLicensesHistory.Columns[2].Width = 270;

                dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicensesHistory.Columns[3].Width = 150;

                dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicensesHistory.Columns[4].Width = 150;

                dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvLocalLicensesHistory.Columns[5].Width = 80;

            }
        }
        private void _LoadInternationalLicenseInfo()
        {

            _dtDriverInternationalLicensesHistory = clsDriver.GetInternationalLicenses(_DriverID);


            dgvInternationalLicensesHistory.DataSource = _dtDriverInternationalLicensesHistory;
            lblInternationalLicensesRecords.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();

            if (dgvInternationalLicensesHistory.Rows.Count > 0)
            {
                dgvInternationalLicensesHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dgvInternationalLicensesHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dgvInternationalLicensesHistory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
                dgvInternationalLicensesHistory.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvInternationalLicensesHistory.GridColor = Color.LightGray;

                dgvInternationalLicensesHistory.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicensesHistory.Columns[0].Width = 80;

                dgvInternationalLicensesHistory.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicensesHistory.Columns[1].Width = 80;

                dgvInternationalLicensesHistory.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicensesHistory.Columns[2].Width = 80;

                dgvInternationalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicensesHistory.Columns[3].Width = 150;

                dgvInternationalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicensesHistory.Columns[4].Width = 150;

                dgvInternationalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicensesHistory.Columns[5].Width = 80;

            }
        }

        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDriver.FindByDriverID(_DriverID);

            if( _Driver == null )
            {
                MessageBox.Show("There is no Driver With ID = " + _DriverID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();

        }

        public void LoadInfoByPersonID(int PersonID)
        {

            _Driver = clsDriver.FindByPersonID(PersonID);
            if (_Driver == null)
            {
                MessageBox.Show("There is no Driver Linked With Person  With ID = " + PersonID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DriverID = _Driver.DriverID;
           

            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }
        private void ctrlDriverLicenses_Load(object sender, EventArgs e)
        {

        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLocalLicensesHistory.CurrentRow.Cells[0].Value;
            frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
            frm.ShowDialog();
        }
        public void Clear()
        {
            _dtDriverLocalLicensesHistory.Clear();
            _dtDriverInternationalLicensesHistory.Clear();

        }

        private void InternationalLicenseHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int InternationalLicenseID = (int)dgvInternationalLicensesHistory.CurrentRow.Cells[0].Value;
            //frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(InternationalLicenseID);
            //frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
