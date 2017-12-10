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
    public partial class ListStaff : DevExpress.XtraEditors.XtraForm
    {
        public ListStaff()
        {
            InitializeComponent();
        }

        int typeSearchStaff = 0;

        private void ListStaff_Load(object sender, EventArgs e)
        {
            dgvListStaff.DataSource = Staff_BUS.ListStaff();
        }

        private void searchByIDStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByIDStaff.Checked == true)
            {
                typeSearchStaff = 1;
                searchByNameStaff.Checked = false;
            }
        }

        private void searchByNameStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByNameStaff.Checked == true)
            {
                typeSearchStaff = 2;
                searchByIDStaff.Checked = false;
            }
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            switch(typeSearchStaff)
            {
                case 1:
                    {
                        dgvListStaff.DataSource = Staff_BUS.FindStaffById(keySearchStaff.Text.ToString());
                        break;
                    }
                case 2:
                    {
                        dgvListStaff.DataSource = Staff_BUS.FindStaffByName(keySearchStaff.Text.ToString());
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Error!", "Search staff", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        break;
                    }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvListStaff.DataSource = Staff_BUS.ListStaff();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (grid.RowCount > 0)
            {
                DataRow row = grid.GetDataRow(grid.GetSelectedRows()[0]);
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete staff", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Staff_BUS.DeleteStaff(row["IDStaff"].ToString());
                    MessageBox.Show("Staff was deleted", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                dgvListStaff.DataSource = Staff_BUS.ListStaff();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (grid.RowCount > 0)
            {
                DataRow row = grid.GetDataRow(grid.GetSelectedRows()[0]);
                EditStaff.oldInfo = row;
                EditStaff edit = new EditStaff();
                edit.ShowDialog();
                dgvListStaff.DataSource = Staff_BUS.ListStaff();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}