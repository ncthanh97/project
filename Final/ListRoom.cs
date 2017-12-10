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
    public partial class ListRoom : DevExpress.XtraEditors.XtraForm
    {
        public ListRoom()
        {
            InitializeComponent();
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            dgvListRoom.DataSource = Room_BUS.FindRoomById(searchRoom.Text.ToString());
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (gridRoom.RowCount > 0)
            {
                DataRow row = gridRoom.GetDataRow(gridRoom.GetSelectedRows()[0]);
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete room", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Room_BUS.DeleteRoom(row["IDRoom"].ToString());
                    MessageBox.Show("Room was deleted", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                dgvListRoom.DataSource = Room_BUS.ListRoom();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }            
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (gridRoom.RowCount > 0)
            {
                DataRow row = gridRoom.GetDataRow(gridRoom.GetSelectedRows()[0]);
                EditRoom.oldInfo = row;
                EditRoom edit = new EditRoom();
                edit.ShowDialog();
                dgvListRoom.DataSource = Room_BUS.ListRoom();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }            
        }

        private void ListRoom_Load(object sender, EventArgs e)
        {
            dgvListRoom.DataSource = Room_BUS.ListRoom();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvListRoom.DataSource = Room_BUS.ListRoom();
        }
    }
}