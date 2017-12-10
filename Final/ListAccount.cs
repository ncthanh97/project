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
    public partial class ListAccount : DevExpress.XtraEditors.XtraForm
    {
        public ListAccount()
        {
            InitializeComponent();
        }

        private void ListAccount_Load(object sender, EventArgs e)
        {
            dgvListAccount.DataSource = Account_BUS.ListAccount();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvListAccount.DataSource = Account_BUS.ListAccount();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (gridAccount.RowCount > 0)
            {
                DataRow row = gridAccount.GetDataRow(gridAccount.GetSelectedRows()[0]);
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete room", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Account_BUS.DeleteAccount(row["IDAccount"].ToString());
                    MessageBox.Show("Account was deleted", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                dgvListAccount.DataSource = Room_BUS.ListRoom();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void editAccount_Click(object sender, EventArgs e)
        {
            if (gridAccount.RowCount > 0)
            {
                DataRow row = gridAccount.GetDataRow(gridAccount.GetSelectedRows()[0]);
                EditAccount.oldInfo = row;
                EditAccount edit = new EditAccount();
                edit.ShowDialog();
                dgvListAccount.DataSource = Account_BUS.ListAccount();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnSearchShow_Click(object sender, EventArgs e)
        {
            dgvListAccount.DataSource = Account_BUS.FindAccount(searchAccount.Text.ToString());
        }
    }
}