using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace SakilaFilms
{
    public partial class Sakila : Form
    {
        private static string connectionStringStaff = "Server=localhost;Database=sakila;Uid=staff;Pwd=$up3r$3cr3t;";
        private static string connectionStringClient = "Server=localhost;Database=sakila;Uid=client;Pwd=$3cr3t3t;";
        private static Boolean login = false;

        public Sakila()
        {
            InitializeComponent();
            //if(login == false)
            //{
            //    tabControl1.Enabled = false;
            //}
            //else
            //{
            //    tabControl1.Enabled = true;
            //}
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            List<int> films = new List<int>();
            MySqlConnection connection = new MySqlConnection(connectionStringStaff);
            string sql = $"select count(staff_id) from staff where username like {user} and password like {password};";

            int count = connection.Query<int>(sql).Count();
            if(count > 0)
            {
                login = true;
            }
        }
        private void bFinder_Click(object sender, EventArgs e)
        {
            
            List<Film> films = new List<Film>();
            MySqlConnection connection = new MySqlConnection(connectionStringStaff);
            string sql = "select * from FILM" +
                $" WHERE TITLE LIKE '%{iSearch.Text}%'";
           
            
            if (cMatch.Checked)
            {
                 sql = "select * from FILM" +
                $" WHERE TITLE LIKE '{iSearch.Text}_%' OR TITLE LIKE '%_{iSearch.Text}'";
            }
            films = connection.Query<Film>(sql).ToList();
             int count = connection.Query<Film>(sql).Count();

            lCount.Text = count + " records found";
            listFilms.DataSource = films;
            listFilms.DisplayMember = "FullInfo";

            connection.Close();
        }

        private void listFilms_DoubleClick(object sender, EventArgs e)
        {
            Film selectedFilm = listFilms.SelectedItem as Film;
            FilmsDetails filmDetailsForm =
                new FilmsDetails(selectedFilm);

            //Button prop DialogResult

            DialogResult result = filmDetailsForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                //this.txtResult.Text = testDialog.TextBox1.Text;
            }
            else if (result == DialogResult.Cancel)
            {
                //this.txtResult.Text = "Cancelled";

            }
            filmDetailsForm.Dispose();
        }

        private void Update_Click(object sender, EventArgs e)
        {

        }
    }
}
