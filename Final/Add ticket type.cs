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
    public partial class Add_ticket_type : DevExpress.XtraEditors.XtraForm
    {
        public Add_ticket_type()
        {
            InitializeComponent();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            string id = idAddTicketType.Text;
            string condition = conditionAddTicketType.Text;
            string price = priceAddTicketType.Text;

            TicketType_DTO ticket = new TicketType_DTO(id, condition, price);
            TicketType_BUS.AddTicketType(ticket);
            MessageBox.Show("Complete!", "Add TicketType", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void btnClearType_Click(object sender, EventArgs e)
        {
            idAddTicketType.Clear();
            conditionAddTicketType.Clear();
            priceAddTicketType.Clear();
        }

        private void Add_ticket_type_Load(object sender, EventArgs e)
        {

        }
    }
}