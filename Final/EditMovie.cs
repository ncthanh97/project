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
    public partial class EditMovie : DevExpress.XtraEditors.XtraForm
    {
        public EditMovie()
        {
            InitializeComponent();
        }

        public static DataRow oldInfo;

        private void EditMovie_Load(object sender, EventArgs e)
        {
            idMovie.Text = oldInfo["IDMovie"].ToString();
            editNameMovie.Text = oldInfo["Name"].ToString();
            editGenres.Text = oldInfo["Genres"].ToString();
            editDirector.Text = oldInfo["Director"].ToString();
            editActor.Text = oldInfo["Actor"].ToString();
            editDuration.Text = oldInfo["Duration"].ToString();
            editReleaseDay.Text = oldInfo["ReleaseDay"].ToString();
            editLanguage.Text = oldInfo["Languages"].ToString();
            editCountry.Text = oldInfo["Country"].ToString();
            editRated.Text = oldInfo["Rated"].ToString();
        }

        private void idMovie_Click(object sender, EventArgs e)
        {
        }

        private void editNameMovie_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            string id = idMovie.Text;
            string name = editNameMovie.Text;
            string genres = editGenres.Text;
            string dir = editDirector.Text;
            string act = editActor.Text;
            string dur = editDuration.Text;
            string rel = editReleaseDay.Text;
            string lan = editLanguage.Text;
            string cou = editCountry.Text;
            string rated = editRated.Text;
            Movie_DTO movie = new Movie_DTO(id, name, genres, dir, act, dur, rel, lan, cou, rated);
            Movie_BUS.EditMovie(movie);
            this.Close();
        }
    }
}