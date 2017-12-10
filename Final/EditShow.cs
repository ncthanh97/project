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
using DTO;

namespace Manage_Cinema
{
    public partial class EditShow : DevExpress.XtraEditors.XtraForm
    {
        public EditShow()
        {
            InitializeComponent();
        }

        public static DataRow oldInfo;

        private void EditShow_Load(object sender, EventArgs e)
        {
            idShow.Text = oldInfo["IDShowtime"].ToString();
            timeShow.Text = oldInfo["Time1"].ToString();
            dayShow.Text = oldInfo["Day1"].ToString();
            tnShow.Text = oldInfo["TicketNumber"].ToString();
            idmShow.Text = oldInfo["IDMovie"].ToString();
            idrShow.Text = oldInfo["IDRoom"].ToString();
        }

        private void btnEditShow_Click(object sender, EventArgs e)
        {
            string id = idShow.Text;
            string time = timeShow.Text;
            string day = dayShow.Text;
            string tn = tnShow.Text;
            string idm = idmShow.Text;
            string idr = idrShow.Text;
            Showtime_DTO show = new Showtime_DTO(id, time, day, tn, idm, idr);
            Showtime_BUS.EditShowtime(show);
            MessageBox.Show("Showtime was deleted", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
    }
}