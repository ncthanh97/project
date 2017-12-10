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
    public partial class EditAccount : DevExpress.XtraEditors.XtraForm
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        public static DataRow oldInfo;

        private void EditAccount_Load(object sender, EventArgs e)
        {
            id.Text = oldInfo["IDAccount"].ToString();
            pwAccount.Text = oldInfo["Pass"].ToString();
            idstaff.Text = oldInfo["IDStaff"].ToString();
            position.Text = oldInfo["Position"].ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id1 = id.Text;
            string pw = pwAccount.Text;
            string ids = idstaff.Text;
            string pos = position.Text;
            Account_DTO acc = new Account_DTO(id1, pw, ids, pos);
            Account_BUS.EditAccount(acc);
        }
    }
}