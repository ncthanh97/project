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
    public partial class PayScreen : DevExpress.XtraEditors.XtraForm
    {
        public PayScreen()
        {
            InitializeComponent();
        }

        public static string ticket;

        private void PayScreen_Load(object sender, EventArgs e)
        {
            nameMovie.Text = SeatScreen.nMovie;
            timeMovie.Text = SeatScreen.tMovie;
            dayMovie.Text = SeatScreen.dMovie;
            foreach(string a in SeatScreen.seat)
            {
                seatMovie.Text += a +" ";
            }
            priceMovie.Text = (int.Parse(SeatScreen.price) * (SeatScreen.seat.Count())).ToString() + " VND";
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            foreach(string a in SeatScreen.seat)
            {
                string idm = SeatScreen.show["IDMovie"].ToString();
                string name = SeatScreen.show["Name"].ToString();
                string idr = SeatScreen.show["IDRoom"].ToString();
                string ids = SeatScreen.show["IDShowtime"].ToString();
                string tt = ticket;
                string pos = a;
                string time = SeatScreen.show["Time1"].ToString();
                string day = SeatScreen.show["Day1"].ToString();
                TicketWasSold_DTO sold = new TicketWasSold_DTO(idm, name, idr, ids, tt, pos, time, day);
                TicketWasSold_BUS.SellTicket(sold);
                this.Close();
            }
        }

        private void priceMovie_Click(object sender, EventArgs e)
        {

        }
    }
}