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
    public partial class ListSold : DevExpress.XtraEditors.XtraForm
    {
        public ListSold()
        {
            InitializeComponent();
        }

        int typeSearchTWS = 0;

        private void ListSold_Load(object sender, EventArgs e)
        {
            dgvListSold.DataSource = TicketWasSold_BUS.ListTWS();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvListSold.DataSource = TicketWasSold_BUS.ListTWS();
        }

        private void searchByIDMovie_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByIDMovie.Checked == true)
            {
                typeSearchTWS = 1;
                searchByIDRoom.Checked = false;
                searchByIDShow.Checked = false;
                searchByNameMovie.Checked = false;
            }
        }

        private void searchByNameMovie_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByNameMovie.Checked == true)
            {
                typeSearchTWS = 2;
                searchByIDMovie.Checked = false;
                searchByIDRoom.Checked = false;
                searchByIDShow.Checked = false;
            }
        }

        private void searchByIDRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByIDRoom.Checked == true)
            {
                typeSearchTWS = 3;
                searchByIDMovie.Checked = false;
                searchByNameMovie.Checked = false;
                searchByIDShow.Checked = false;
            }
        }

        private void searchByIDShow_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByIDShow.Checked == true)
            {
                typeSearchTWS = 4;
                searchByIDMovie.Checked = false;
                searchByIDRoom.Checked = false;
                searchByNameMovie.Checked = false;
            }
        }

        private void btnSearchTWS_Click(object sender, EventArgs e)
        {
            switch (typeSearchTWS)
            {
                case 1:
                    {
                        dgvListSold.DataSource = TicketWasSold_BUS.FindTWSByIdMovie(keySearchTWS.Text.ToString());
                        break;
                    }
                case 2:
                    {
                        dgvListSold.DataSource = TicketWasSold_BUS.FindTWSByNameMovie(keySearchTWS.Text.ToString());
                        break;
                    }
                case 3:
                    {
                        dgvListSold.DataSource = TicketWasSold_BUS.FindTWSByIdRoom(keySearchTWS.Text.ToString());
                        break;
                    }
                case 4:
                    {
                        dgvListSold.DataSource = TicketWasSold_BUS.FindTWSByIdShowtime(keySearchTWS.Text.ToString());
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Error!", "Search ticket was sold", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        break;
                    }
            }
        }
    }
}