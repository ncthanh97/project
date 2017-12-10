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
    public partial class ListUser : DevExpress.XtraEditors.XtraForm
    {
        public ListUser()
        {
            InitializeComponent();
        }

        int typeSearchUser = 0;

        private void ListUser_Load(object sender, EventArgs e)
        {
            dgvListUser.DataSource = User_BUS.ListUsers();
        }

        private void searchByIDUser_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByIDUser.Checked == true)
            {
                searchByNameUser.Checked = false;
                typeSearchUser = 1;
            }
        }

        private void searchByNameUser_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByNameUser.Checked == true)
            {
                searchByIDUser.Checked = false;
                typeSearchUser = 2;
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            switch (typeSearchUser)
            {
                case 1:
                    {
                        dgvListUser.DataSource = User_BUS.FindUserById(keySearchUser.Text.ToString());
                        break;
                    }
                case 2:
                    {
                        dgvListUser.DataSource = User_BUS.FindUserByName(keySearchUser.Text.ToString());
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Error!", "Search user", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        break;
                    }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvListUser.DataSource = User_BUS.ListUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (gridUser.RowCount > 0)
            {
                DataRow row = gridUser.GetDataRow(gridUser.GetSelectedRows()[0]);
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete user", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    User_BUS.DeleteUser(row["IDUser"].ToString());
                    MessageBox.Show("User was deleted", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                dgvListUser.DataSource = User_BUS.ListUsers();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (gridUser.RowCount > 0)
            {
                DataRow row = gridUser.GetDataRow(gridUser.GetSelectedRows()[0]);
                EditUser.oldInfo = row;
                EditUser edit = new EditUser();
                edit.ShowDialog();
                dgvListUser.DataSource = User_BUS.ListUsers();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}