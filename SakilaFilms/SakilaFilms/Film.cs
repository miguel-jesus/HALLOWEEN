using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakilaFilms
{
    class Film
    {
        public int FILM_ID { get; set; }
        public string TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public string RATING { get; set; }
        public string IDLANGUAGE_ID { get; set; }
        public string LENGTH { get; set; }



        public string FullInfo
        {
            get
            {
                return FILM_ID + ":\t" + TITLE;

            }
        }
    }
}
