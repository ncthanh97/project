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
    public partial class List_show : DevExpress.XtraEditors.XtraForm
    {
        public List_show()
        {
            InitializeComponent();
        }

        int typeSearchShowTime = 0;

        private void List_show_Load(object sender, EventArgs e)
        {
            dgvListShow.DataSource = Showtime_BUS.ListShowtime();
        }

        private void btnSearchShow_Click(object sender, EventArgs e)
        {
            switch (typeSearchShowTime)
            {
                case 1:
                    {
                        dgvListShow.DataSource = Showtime_BUS.FindShowtimeById(searchShow.Text.ToString());
                        break;
                    }
                case 2:
                    {
                        dgvListShow.DataSource = Showtime_BUS.FindShowtimeByIdMovie(searchShow.Text.ToString());
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Error!", "Search showtime", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        break;
                    }
            }
        }

        private void btnDeleteShow_Click(object sender, EventArgs e)
        {
            if (gridShow.RowCount > 0)
            {
                DataRow row = gridShow.GetDataRow(gridShow.GetSelectedRows()[0]);
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete showtime", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Room_BUS.DeleteRoom(row["IDShowtime"].ToString());
                    MessageBox.Show("Showtime was deleted", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                dgvListShow.DataSource = Showtime_BUS.ListShowtime();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridShow.RowCount > 0)
            {
                DataRow row = gridShow.GetDataRow(gridShow.GetSelectedRows()[0]);
                EditShow.oldInfo = row;
                EditShow edit = new EditShow();
                edit.ShowDialog();
                dgvListShow.DataSource = Showtime_BUS.ListShowtime();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvListShow.DataSource = Showtime_BUS.ListShowtime();
        }

        private void searchByIDShow_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByIDShow.Checked == true)
            {
                typeSearchShowTime = 1;
                searchByIDMovie.Checked = false;
            }
        }

        private void searchByIDMovie_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByIDMovie.Checked == true)
            {
                typeSearchShowTime = 2;
                searchByIDShow.Checked = false;
            }
        }
    }
}