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
    public partial class frmListTestTypes : Form
    {
        private DataTable _dtAllTestTypes;
        public frmListTestTypes()
        {
            InitializeComponent();
        }

        private void pbApplicationTypesmage_Click(object sender, EventArgs e)
        {

        }

        private void lblRecordsCount_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvTestTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            _dtAllTestTypes = clsTestType.GetAllTestTypes();
            dgvTestTypes.DataSource = _dtAllTestTypes;
            lblRecordsCount.Text = dgvTestTypes.Rows.Count.ToString();
            if (dgvTestTypes.Rows.Count > 0)
            {
                dgvTestTypes.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dgvTestTypes.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dgvTestTypes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
                dgvTestTypes.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvTestTypes.GridColor = Color.LightGray;

                dgvTestTypes.Columns[0].HeaderText = "ID";
                dgvTestTypes.Columns[0].Width = 120;
                dgvTestTypes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvTestTypes.Columns[1].HeaderText = "Title";
                dgvTestTypes.Columns[1].Width = 190;

                dgvTestTypes.Columns[2].HeaderText = "Description";
                dgvTestTypes.Columns[2].Width = 650;

                dgvTestTypes.Columns[3].HeaderText = "Fees";
                dgvTestTypes.Columns[3].Width = 140;
                dgvTestTypes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestType frm = new frmEditTestType((clsTestType.enTestType)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListTestTypes_Load(null, null);
        }
    }
}
