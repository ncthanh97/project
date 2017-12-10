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
    public partial class Add_Movie : DevExpress.XtraEditors.XtraForm
    {
        public Add_Movie()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string id = addIdMovie.Text;
            string name = addNameMovie.Text;
            string genres = addGenres.Text;
            string director = addDirector.Text;
            string actor = addActor.Text;
            string duration = addDuration.Text;
            string releaseDay = addReleaseDay.Value.ToString();
            string language = addLanguage.Text;
            string country = addCountry.Text;
            string rated = addRated.Text;

            Movie_DTO movie = new Movie_DTO(id, name, genres, director, actor, duration, releaseDay.Substring(0, 10), language, country, rated);
            BUS.Movie_BUS.AddMovie(movie);
            MessageBox.Show("Complete", "Add a movie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void btnClearAddMovie_Click(object sender, EventArgs e)
        {
            addIdMovie.Clear();
            addNameMovie.Clear();
            addGenres.Clear();
            addDirector.Clear();
            addActor.Clear();
            addDuration.Clear();
            addLanguage.Clear();
            addCountry.Clear();
            addRated.Clear();
        }
    }
}