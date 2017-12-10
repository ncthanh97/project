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
    public partial class AddStaff : DevExpress.XtraEditors.XtraForm
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = idStaff.Text;
            string firstname = fName.Text;
            string lastname = lName.Text;
            string birthday1 = birthday.Text;
            string sex1 = sex.Text;
            string pOB = placeOfBirth.Text;
            string add = address.Text;
            string identityNumber = iNumber.Text;
            string email1 = email.Text;
            string pos = position.Text;
            string phoneNumber = pNumber.Text;

            Staff_DTO staff = new Staff_DTO(id, firstname, lastname, birthday1, sex1, pOB, add, identityNumber, email1, pos, phoneNumber);
            Staff_BUS.AddStaff(staff);
            MessageBox.Show("Complete!", "Add staff", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            idStaff.Clear();
            fName.Clear();
            lName.Clear();
            birthday.Clear();
            sex.Clear();
            placeOfBirth.Clear();
            address.Clear(); 
            iNumber.Clear();
            email.Clear();
            position.Clear();
            pNumber.Clear();
        }
    }
}