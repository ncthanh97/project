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
using DTO;
using BUS;

namespace Manage_Cinema
{
    public partial class Add_show : DevExpress.XtraEditors.XtraForm
    {
        public Add_show()
        {
            InitializeComponent();
        }

        private void addShow_Click(object sender, EventArgs e)
        {
            string id = idAddShowtime.Text;
            string time = timeAddShow.Text;
            string day = dayAddShowTime.Value.ToString();
            string tn = ticketNumberAddShowtime.Text;
            string idm = idMovieAddShowTime.Text;
            string idr = idRoomAddShowTime.Text;

            Showtime_DTO showtime = new Showtime_DTO(id, time, day.Substring(0, 10), tn, idm, idr);
            Showtime_BUS.AddShowtime(showtime);
            MessageBox.Show("Complete!", "Add showtime", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            idAddShowtime.Clear();
            ticketNumberAddShowtime.Clear();
            idMovieAddShowTime.Clear();
            idRoomAddShowTime.Clear();
            timeAddShow.Clear();
        }
    }
}