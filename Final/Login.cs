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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        List<string[]> login;
        
        int checkLogin = 0;

        private void dgvLogin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
            
        {
            login = new List<string[]>();
            dgvLogin.DataSource = Account_BUS.ListAccount();
            for (int i = 0; i < gridLogin.RowCount; i++)
            {
                string[] c = new string[3];
                c[0] = gridLogin.GetDataRow(i)["IDAccount"].ToString().TrimEnd();
                c[1] = gridLogin.GetDataRow(i)["Pass"].ToString().TrimEnd();
                c[2] = gridLogin.GetDataRow(i)["Position"].ToString().TrimEnd();
                login.Add(c);
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach(string[] a in login)
            {
                if ((a[0] == idLogin.Text) && (a[1] == pwLogin.Text))
                {
                    switch (a[2])
                    {
                        case "Manager":
                            {
                                Manager.id = idLogin.Text;
                                Manager.pw = pwLogin.Text;
                                checkLogin = 1;
                                break;
                            }
                        case "Ticket Seller":
                            {
                                checkLogin = 2;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
            }
            switch (checkLogin)
            {
                case 1:
                    {
                        Manager manager = new Manager();
                        this.Hide();
                        manager.ShowDialog();
                        this.Close();
                        break;
                    }
                case 2:
                    {
                        SoldTicketScreen sold = new SoldTicketScreen();
                        this.Hide();
                        sold.ShowDialog();
                        this.Close();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("ID or password is wrong");
                        break;
                    }
            }
        }
    }
}