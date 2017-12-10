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
    public partial class EditStaff : DevExpress.XtraEditors.XtraForm
    {
        public EditStaff()
        {
            InitializeComponent();
        }

        public static DataRow oldInfo;

        private void EditStaff_Load(object sender, EventArgs e)
        {
            idStaff.Text = oldInfo["IDStaff"].ToString();
            fName.Text = oldInfo["FirstName"].ToString();
            lName.Text = oldInfo["LastName"].ToString();
            birthday.Text = oldInfo["Birthday"].ToString();
            sex.Text = oldInfo["Sex"].ToString();
            placeOfBirth.Text = oldInfo["PlaceOfBirth"].ToString();
            address.Text = oldInfo["Address1"].ToString();
            iNumber.Text = oldInfo["IdentityNumber"].ToString();
            email.Text = oldInfo["Email"].ToString();
            position.Text = oldInfo["Position"].ToString();
            pNumber.Text = oldInfo["PhoneNumber"].ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Staff_DTO staff = new Staff_DTO(
                idStaff.Text.ToString(),
                fName.Text.ToString(),
                lName.Text.ToString(),
                birthday.Text.ToString(),
                sex.Text.ToString(),
                placeOfBirth.Text.ToString(),
                address.Text.ToString(),
                iNumber.Text.ToString(),
                email.Text.ToString(),
                position.Text.ToString(),
                pNumber.Text.ToString());
            Staff_BUS.EditStaff(staff);
            this.Close();
        }
    }
}