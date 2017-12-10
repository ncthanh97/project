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
    public partial class EditUser : DevExpress.XtraEditors.XtraForm
    {
        public EditUser()
        {
            InitializeComponent();
        }

        public static DataRow oldInfo;

        private void EditUser_Load(object sender, EventArgs e)
        {
            idUser.Text = oldInfo["IDUser"].ToString();
            fName.Text = oldInfo["FirstName"].ToString();
            lName.Text = oldInfo["LastName"].ToString();
            sex.Text = oldInfo["Sex"].ToString();
            birthday.Text = oldInfo["Birthday"].ToString();
            pNumber.Text = oldInfo["PhoneNumber"].ToString();
            iNumber.Text = oldInfo["IdentityNumber"].ToString();
            email.Text = oldInfo["Email"].ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = idUser.Text;
            string fname = fName.Text;
            string lname = lName.Text;
            string sexUser = sex.Text;
            string birth = birthday.Text;
            string pnumber = pNumber.Text;
            string inumber = iNumber.Text;
            string emailUser = email.Text;
            User_DTO user = new User_DTO(id, fname, lname, sexUser, birth, pnumber, inumber, emailUser);
            User_BUS.EditUser(user);
            this.Close();
        }
    }
}