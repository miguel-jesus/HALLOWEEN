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
    public partial class FilmsDetails : Form
    {
        Film _selectedFilm;
        private static string connectionString = "Server=localhost;Database=sakila;Uid=staff;Pwd=$up3r$3cr3t;";


        public FilmsDetails(Film selectedFilm)
        {
            InitializeComponent();
            _selectedFilm = selectedFilm;
            Console.WriteLine(selectedFilm);
           
            List<Film> films = new List<Film>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"SELECT film_id, film.title, film.description,film.rating,film.length" +
                $"from film where film_id = {selectedFilm.FILM_ID}";
            Console.WriteLine(sql);    
            films = connection.Query<Film>(sql).ToList();
            Film film = films.FirstOrDefault();
            lTitle.Text = film.TITLE;
            lTime.Text = film.LENGTH + "'";
            if(film.RATING == "NC-17" || film.RATING == "R")
            {
                lRting.ForeColor = System.Drawing.Color.Red;
            }
            lRting.Text = film.RATING;
            descripList.Text = film.DESCRIPTION;

            //descripcioLabel.Text = film.;
            //autorLabel.Text = film.NOM_AUTOR;
            //departamentLabel.Text = film.FK_DEPARTAMENT;
        }

       
    }
}
