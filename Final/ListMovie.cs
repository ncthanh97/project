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
    public partial class ListMovie : DevExpress.XtraEditors.XtraForm
    {
        public ListMovie()
        {
            InitializeComponent();
        }
        int typeCheckMovie = 0;


        private void btnShowAllMovie_Click(object sender, EventArgs e)
        {
            dgvListMovie.DataSource = BUS.Movie_BUS.ListMovie();
        }

        private void btnSearchMovie_Click(object sender, EventArgs e)
        {
            switch (typeCheckMovie)
            {
                case 1:
                    {
                        dgvListMovie.DataSource = Movie_BUS.FindMovieById(keySearchMovie.Text.ToString());
                        break;
                    }
                case 2:
                    {
                        dgvListMovie.DataSource = Movie_BUS.FindMovieByName(keySearchMovie.Text.ToString());
                        break;
                    }
                default:
                    MessageBox.Show("Error!", "Search movie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
            }

        }

        private void searchByIDMovie_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByIDMovie.Checked == true)
            {
                typeCheckMovie = 1;
                searchByNameMovie.Checked = false;
            }
        }

        private void searchByNameMovie_CheckedChanged(object sender, EventArgs e)
        {
            if (searchByNameMovie.Checked == true)
            {
                typeCheckMovie = 2;
                searchByIDMovie.Checked = false;
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (grid.RowCount > 0)
            {
                DataRow row = grid.GetDataRow(grid.GetSelectedRows()[0]);
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete movie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Movie_BUS.DeleteMovie(row["IDMovie"].ToString());
                    MessageBox.Show("Movie was deleted", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                dgvListMovie.DataSource = Movie_BUS.ListMovie();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void ListMovie_Load(object sender, EventArgs e)
        {
            dgvListMovie.DataSource = Movie_BUS.ListMovie();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (grid.RowCount > 0)
            {
                DataRow row = grid.GetDataRow(grid.GetSelectedRows()[0]);
                EditMovie.oldInfo = row;
                EditMovie edit = new EditMovie();
                edit.ShowDialog();
                dgvListMovie.DataSource = Movie_BUS.ListMovie();
            }
            else
            {
                MessageBox.Show("Error!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }  
        }
    }
}