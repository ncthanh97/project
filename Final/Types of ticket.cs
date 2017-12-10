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
    public partial class Types_of_ticket : DevExpress.XtraEditors.XtraForm
    {
        public Types_of_ticket()
        {
            InitializeComponent();
        }

        private void btnSearchTOT_Click(object sender, EventArgs e)
        {
            dgvListTOT.DataSource = TicketType_BUS.FindTicketType(searchTOT.Text.ToString());
        }

        private void Types_of_ticket_Load(object sender, EventArgs e)
        {
            dgvListTOT.DataSource = TicketType_BUS.ListTicketType();
        }

        private void btnDeleteTOT_Click(object sender, EventArgs e)
        {
            if (gridTOT.RowCount > 0)
            {
                DataRow row = gridTOT.GetDataRow(gridTOT.GetSelectedRows()[0]);
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete ticket", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TicketType_BUS.DeleteTicketType(row["IDTicket"].ToString());
                    MessageBox.Show("Ticket was deleted", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                dgvListTOT.DataSource = TicketType_BUS.ListTicketType();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnEditTOT_Click(object sender, EventArgs e)
        {
            if (gridTOT.RowCount > 0)
            {
                DataRow row = gridTOT.GetDataRow(gridTOT.GetSelectedRows()[0]);
                EditTicketType.oldInfo = row;
                EditTicketType edit = new EditTicketType();
                edit.ShowDialog();
                dgvListTOT.DataSource = TicketType_BUS.ListTicketType();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvListTOT.DataSource = TicketType_BUS.ListTicketType();
        }

        private void dgvListTOT_Click(object sender, EventArgs e)
        {

        }

        private void searchTOT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}