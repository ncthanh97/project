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
    public partial class EditSalary : DevExpress.XtraEditors.XtraForm
    {
        public EditSalary()
        {
            InitializeComponent();
        }

        public static DataRow oldInfo;

        private void EditSalary_Load(object sender, EventArgs e)
        {
            position.Text = oldInfo["Position"].ToString();
            salary.Text = oldInfo["Salary"].ToString();
            work.Text = oldInfo["Work"].ToString();
        }

        private void btnEditSalary_Click(object sender, EventArgs e)
        {
            Salary_DTO sal = new Salary_DTO(
                position.Text.ToString(),
                salary.Text.ToString(),
                work.Text.ToString());
            Salary_BUS.EditSalary(sal);
            this.Close();
        }
    }
}