using DVLD.Resources;
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
    public partial class FrmManagePeople : Form
    {
        private static DataTable _dtAllPeople= clsPerson.GetAllPeople();

        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                      "FirstName", "SecondName", "ThirdName", "LastName",
                                                      "GendorCaption", "DateOfBirth", "CountryName",
                                                      "Phone", "Email");
        public FrmManagePeople()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void _RefreshList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

            dataGridView1.DataSource = _dtPeople;
            lblRecordsPeople.Text = dataGridView1.Rows.Count.ToString();
        }
        private void FrmManagePeople_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _dtPeople;
            comboBoxFilterPerson.SelectedIndex = 0;
            lblRecordsPeople.Text = dataGridView1.Rows.Count.ToString();

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridView1.GridColor = Color.LightGray;

                dataGridView1.Columns[0].HeaderText = "Person ID";
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[1].HeaderText = "National No";
                dataGridView1.Columns[1].Width = 130;
                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[2].HeaderText = "First Name";
                dataGridView1.Columns[2].Width = 130;

                dataGridView1.Columns[3].HeaderText = "Second Name";
                dataGridView1.Columns[3].Width = 150;

                dataGridView1.Columns[4].HeaderText = "Third Name";
                dataGridView1.Columns[4].Width = 130;

                dataGridView1.Columns[5].HeaderText = "Last Name";
                dataGridView1.Columns[5].Width = 130;

                dataGridView1.Columns[6].HeaderText = "Gendor";
                dataGridView1.Columns[6].Width = 100;
                dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[7].HeaderText = "Date Of Birth";
                dataGridView1.Columns[7].Width = 170;

                dataGridView1.Columns[8].HeaderText = "Nationality";
                dataGridView1.Columns[8].Width = 130;
                dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns[9].HeaderText = "Phone";
                dataGridView1.Columns[9].Width = 120;

                dataGridView1.Columns[10].HeaderText = "Email";
                dataGridView1.Columns[10].Width = 200;


            }

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            FrmAddEditPersonInfo frm = new FrmAddEditPersonInfo();
            frm.ShowDialog();
            _RefreshList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = comboBoxFilterPerson.Text != "None";
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            int PersonID=(int)dataGridView1.CurrentRow.Cells["PersonID"].Value;

            if(MessageBox.Show("Are You Sure To Delete This Person ? ","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if(clsPerson.Delete(PersonID))
                {
                    MessageBox.Show("Person Deleted Successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _RefreshList() ;
                }
                else
                {
                    MessageBox.Show("Could Not Delete This Person.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dataGridView1.CurrentRow.Cells["PersonID"].Value;
           
            FrmAddEditPersonInfo frm = new FrmAddEditPersonInfo(PersonID);
            frm.ShowDialog();
            _RefreshList();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch(comboBoxFilterPerson.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;


                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if(txtFilterValue.Text.Trim()==""||FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsPeople.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsPeople.Text = dataGridView1.Rows.Count.ToString();


        }

        private void lblRecordsPeople_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID=(int)dataGridView1.CurrentRow.Cells[0].Value;
            Form frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEditPersonInfo frm = new FrmAddEditPersonInfo();
            frm.ShowDialog();
            _RefreshList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxFilterPerson.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void dataGridView1_AlternatingRowsDefaultCellStyleChanged(object sender, EventArgs e)
        {

        }
    }
}
