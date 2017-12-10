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
    public partial class AddSalary : DevExpress.XtraEditors.XtraForm
    {
        public AddSalary()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string pos = position.Text;
            string sal = salary.Text;
            string work1 = work.Text;
            Salary_DTO salary1 = new Salary_DTO(pos, sal, work1);
            Salary_BUS.AddSalary(salary1);
            MessageBox.Show("Complete", "Add salary", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            position.Clear();
            salary.Clear();
            work.Clear();
        }
    }
}