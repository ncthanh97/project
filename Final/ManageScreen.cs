using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manage_Cinema
{
    public partial class Manager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Manager()
        {
            InitializeComponent();
        }

        public static string id;
        public static string pw;

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListMovie listMovie = new ListMovie();
            listMovie.MdiParent = this;
            listMovie.Show();
        }

        private void tabAddMovie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add_Movie add = new Add_Movie();
            add.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List_show listShow = new List_show();
            listShow.MdiParent = this;
            listShow.Show();
        }

        private void btnAddShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add_show addShow = new Add_show();
            addShow.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Types_of_ticket ticketType = new Types_of_ticket();
            ticketType.MdiParent = this;
            ticketType.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add_ticket_type addTT = new Add_ticket_type();
            addTT.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.ShowDialog();
        }

        private void btnListRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListRoom listRoom = new ListRoom();
            listRoom.MdiParent = this;
            listRoom.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListStaff staff = new ListStaff();
            staff.MdiParent = this;
            staff.Show();
        }

        private void btnAddStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddStaff staff = new AddStaff();
            staff.ShowDialog();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddSalary salary = new AddSalary();
            salary.ShowDialog();
        }

        private void btnListSalary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListSalary salary = new ListSalary();
            salary.MdiParent = this;
            salary.Show();
        }

        private void btnListUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListUser user = new ListUser();
            user.MdiParent = this;
            user.Show();
            
        }

        private void btnAddUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddUser user = new AddUser();
            user.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListAccount acc = new ListAccount();
            acc.MdiParent = this;
            acc.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListSold sold = new ListSold();
            sold.MdiParent = this;
            sold.Show();
        }

        private void btnAddAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddAccount acc = new AddAccount();
            acc.ShowDialog();
        }

        private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.ShowDialog();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            this.Close();
            id = "";
            pw = "";
        }
    }
}
