using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace Manage_Cinema
{
    public partial class ListSalary : DevExpress.XtraEditors.XtraForm
    {
        public ListSalary()
        {
            InitializeComponent();
        }

        private void ListSalary_Load(object sender, EventArgs e)
        {
            dgvListSalary.DataSource = Salary_BUS.ListSalary();
        }

        private void btnSearchSalary_Click(object sender, EventArgs e)
        {
            dgvListSalary.DataSource = Salary_BUS.FindSalary(searchSalary.Text.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvListSalary.DataSource = Salary_BUS.ListSalary();
        }

        private void btnDeleteSalary_Click(object sender, EventArgs e)
        {
            if (gridSalary.RowCount > 0)
            {
                DataRow row = gridSalary.GetDataRow(gridSalary.GetSelectedRows()[0]);
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete salary", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Salary_BUS.DeleteSalary(row["Position"].ToString());
                    MessageBox.Show("Salary was deleted", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                dgvListSalary.DataSource = Salary_BUS.ListSalary();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnEditSalary_Click(object sender, EventArgs e)
        {
            if (gridSalary.RowCount > 0)
            {
                DataRow row = gridSalary.GetDataRow(gridSalary.GetSelectedRows()[0]);
                EditSalary.oldInfo = row;
                EditSalary edit = new EditSalary();
                edit.ShowDialog();
                dgvListSalary.DataSource = Salary_BUS.ListSalary();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}