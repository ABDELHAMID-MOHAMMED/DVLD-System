using DVLD.Applications;
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
    public partial class frmListApplicationTypes : Form
    {
        private DataTable _dtAllApplicationTypes;
        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _dtAllApplicationTypes = clsApplicationType.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = _dtAllApplicationTypes;
            lblRecordsCount.Text=dgvApplicationTypes.Rows.Count.ToString();


            if (dgvApplicationTypes.Rows.Count > 0)
            {
                dgvApplicationTypes.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dgvApplicationTypes.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dgvApplicationTypes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
                dgvApplicationTypes.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvApplicationTypes.GridColor = Color.LightGray;

                dgvApplicationTypes.Columns[0].HeaderText = "ID";
                dgvApplicationTypes.Columns[0].Width = 80;
                dgvApplicationTypes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvApplicationTypes.Columns[1].HeaderText = "Title";
                dgvApplicationTypes.Columns[1].Width = 450;

                dgvApplicationTypes.Columns[2].HeaderText = "Fees";
                dgvApplicationTypes.Columns[2].Width = 150;
                dgvApplicationTypes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }

        private void dgvApplicationTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationType frm = new frmEditApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageApplicationTypes_Load(null, null);
        }
    }
}
