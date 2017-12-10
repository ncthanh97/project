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
    public partial class AddRoom : DevExpress.XtraEditors.XtraForm
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idAddRoom.Text;
            string sn = seatNumberAddRoom.Text;
            string area = areaAddRoom.Text;
            string status = statusAddRoom.Text;

            Room_DTO room = new Room_DTO(id, sn, area, status);
            Room_BUS.AddRoom(room);
            MessageBox.Show("Complete!", "Add a room", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idAddRoom.Clear();
            seatNumberAddRoom.Clear();
            areaAddRoom.Clear();
            statusAddRoom.Clear();
        }
    }
}