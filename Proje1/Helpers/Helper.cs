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
                    movieName = "Karayip Korsanları",
                    category = Category.komedi,
                    minute = "2 Saat 29 Dakika",
                    price = 100,
                    picturePath = basePath + "/karayip.jpg"
                },
                   new Movie()
                {
                    movieName = "Redlights",
                    category = Category.macera,
                    minute = "2 Saat 30 Dakika",
                    price = 120,
                    picturePath = basePath + "/redlights.jpg"
                },
                new Movie()
                {
                    movieName = "Esaretin Bedeli",
                    category = Category.gerilim,
                    minute = "2 Saat 55 Dakika",
                    price = 40,
                    picturePath = basePath + "/shawshank.jpg"
                },
                new Movie()
                {
                    movieName = "Snowpiercer",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 57 Dakika",
                    price = 60,
                    picturePath = basePath + "/snowpiercer.jpg"
                },
                new Movie()
                {
                    movieName = "Thor",
                    category = Category.fantastik,
                    minute = "2 Saat 25 Dakika",
                    price = 100,
                    picturePath = basePath + "/thor.jpg"
                },

             new Movie()
                {
                    movieName = "Twilight",
                    category = Category.fantastik,
                    minute = "2 Saat 45 Dakika",
                    price = 400,
                    picturePath = basePath + "/twilight.jpg"
                },


            };
        }
    }
}
