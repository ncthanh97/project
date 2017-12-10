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
    public partial class EditTicketType : DevExpress.XtraEditors.XtraForm
    {
        public EditTicketType()
        {
            InitializeComponent();
        }

        public static DataRow oldInfo;

        private void EditTicketType_Load(object sender, EventArgs e)
        {
            idTicket.Text = oldInfo["IDTicket"].ToString();
            cdtTicket.Text = oldInfo["Condition"].ToString();
            priceTicket.Text = oldInfo["Price"].ToString();
        }

        private void btnEditTicket_Click(object sender, EventArgs e)
        {
            string id = idTicket.Text;
            string cdt = cdtTicket.Text;
            string price = priceTicket.Text;
            TicketType_DTO ticket = new TicketType_DTO(id, cdt, price);
            TicketType_BUS.EditTicketType(ticket);
        }
    }
}