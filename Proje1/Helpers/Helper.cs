using Proje1.Enums;
using Proje1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Helpers
{
    class Helper
    {
        public static List<Movie> createMovies()
        {
            string basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Aslan Kral",
                    category = Category.macera,
                    minute = "1 Saat 25 Dakika",
                    price = 50,
                    picturePath = basePath + "\\3408245.jpg"
                },
                   new Movie()
                {
                    movieName = "Shrek",
                    category = Category.macera,
                    minute = "2 Saat 30 Dakika",
                    price = 60,
                    picturePath = basePath + "\\Shrek.jpg"
                },
                new Movie()
                {
                    movieName = "Forrest Gump",
                    category = Category.komedi,
                    minute = "1 Saat 55 Dakika",
                    price = 20,
                    picturePath = basePath + "\\Forrest_Gump_(film,_1994).jpg"
                },
                new Movie()
                {
                    movieName = "Alis Harikalar Diyarında",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 1 Dakika",
                    price = 30,
                    picturePath = basePath + "\\Alice_Harikalar_Diyarında_film_Posteri.jpg"
                },
                new Movie()
                {
                    movieName = "Pasifik Savaşı",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 15 Dakika",
                    price = 50,
                    picturePath = basePath + "\\21014203_20130620162004717.jpg"
                },

             new Movie()
                {
                    movieName = "Wall-e",
                    category = Category.bilimKurgu,
                    minute = "1 Saat 14 Dakika",
                    price = 200,
                    picturePath = basePath + "\\vol-i-1660915312.jpg"
                },


            };
        }
    }
}
