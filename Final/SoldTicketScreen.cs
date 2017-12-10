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
    public partial class SoldTicketScreen : DevExpress.XtraEditors.XtraForm
    {
        public SoldTicketScreen()
        {
            InitializeComponent();
        }
        int typeSearchShowTime = 0;

        private void SoldTicketScreen_Load(object sender, EventArgs e)
        {
            dgvListShow.DataSource = Showtime_BUS.ListShowtimeSold();
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

        private void btnSellTicket_Click(object sender, EventArgs e)
        {
            if (gridShow.RowCount > 0)
            {
                DataRow row = gridShow.GetDataRow(gridShow.GetSelectedRows()[0]);
                SeatScreen.show = row;
                SeatScreen seat = new SeatScreen();
                dgvTicketSell.DataSource = TicketWasSold_BUS.seatWasTaken(row["IDShowtime"].ToString());
                List<string> list = new List<string>();
                for (int i = 0; i < grid.RowCount; i++)
                {
                    list.Add(grid.GetDataRow(i)[0].ToString());
                }
                SeatScreen.seatWasTaken = list;
                seat.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        
    }
}