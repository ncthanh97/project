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
    public partial class EditRoom : DevExpress.XtraEditors.XtraForm
    {
        public EditRoom()
        {
            InitializeComponent();
        }
        public static DataRow oldInfo;

        private void EditRoom_Load(object sender, EventArgs e)
        {
            idRoom.Text = oldInfo["IDRoom"].ToString();
            snRoom.Text = oldInfo["SeatNumber"].ToString();
            areaRoom.Text = oldInfo["Area"].ToString();
            statusRoom.Text = oldInfo["Status"].ToString();
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            string id = idRoom.Text;
            string sn = snRoom.Text;
            string area = areaRoom.Text;
            string status = statusRoom.Text;
            Room_DTO room = new Room_DTO(id, sn, area, status);
            Room_BUS.EditRoom(room);
        }
    }
}