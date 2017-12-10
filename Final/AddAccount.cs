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
    public partial class AddAccount : DevExpress.XtraEditors.XtraForm
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = idAddAccount.Text;
            string pw = pwAccount.Text;
            string ids = idStaff.Text;
            string pos = positionAccount.Text;
            Account_DTO acc = new Account_DTO(id, pw, ids, pos);
            Account_BUS.AddAccount(acc);
            MessageBox.Show("Complete");
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            idAddAccount.Clear();
            pwAccount.Clear();
            idStaff.Clear();
            positionAccount.Clear();
        }
    }
}