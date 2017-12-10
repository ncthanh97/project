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
    public partial class SeatScreen : DevExpress.XtraEditors.XtraForm
    {
        public SeatScreen()
        {
            InitializeComponent();
            foreach(Control a in this.Controls)
            {
                if ((a is Button) && (a.Text != "Pay"))
                {
                    a.Click += new System.EventHandler(ClickButton);
                }
            }
        }
        public static DataRow show;
        public static List<String> seatWasTaken;
        public static string[] seat;
        public static string nMovie;
        public static string tMovie;
        public static string dMovie;
        public static string price;
        string a;

        private void SeatScreen_Load(object sender, EventArgs e)
        {
            foreach (Control a in this.Controls)
            {
                
                foreach (string b in seatWasTaken)
                {
                    if ((a is Button) && (b.Substring(0,2) == a.Text))
                    {
                        a.Enabled = false;
                        a.BackColor = Color.Gray;
                    }
                }
            }
            name.Text = show["Name"].ToString();
            time.Text = show["Time1"].ToString();
            day.Text = show["Day1"].ToString().Substring(0,10);
            ticketType.DataSource = TicketType_BUS.ListTicketType();
        }

        public void ClickButton(object sender, EventArgs e)
        {
            if ((sender as Button).BackColor == Color.Green)
            {
                (sender as Button).BackColor = Color.White;
                
            }
            else
            {
                (sender as Button).BackColor = Color.Green;
                seatNumber.Text +=(sender as Button).Text + " ";
            }
        }

        private void a1_Click(object sender, EventArgs e)
        {
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            nMovie = name.Text;
            tMovie = time.Text;
            dMovie = day.Text;
            DataRow row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            seat = seatNumber.Text.ToString().TrimEnd().Split(' ');
            price = row["Price"].ToString();
            PayScreen.ticket = row["IDTicket"].ToString();
            PayScreen pay = new PayScreen();
            this.Close();
            pay.ShowDialog();
        }

        private void seatNumber_Click(object sender, EventArgs e)
        {

        }
    }
}