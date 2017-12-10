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

namespace Manage_Cinema
{
    public partial class ChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        


        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (oldpass.Text != Manager.pw)
            {
                MessageBox.Show(Manager.pw);
                MessageBox.Show("Old password is wrong");
            }
            else
            {
                if (newpass.Text != confirm.Text)
                {
                    MessageBox.Show("New password is not same");
                }
                else
                {
                    Account_BUS.ChangePassword(Manager.id, confirm.Text.ToString());
                    MessageBox.Show("Complete!");
                    this.Close();
                }
            }
        }
    }
}