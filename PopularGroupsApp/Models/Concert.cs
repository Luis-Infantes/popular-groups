using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PopularGroupsApp.Models
{
    public class Concert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public DateTime Date { get; set; }

        public int BandId { get; set; }
        public Band band { get; set; }

        public static List<Concert> concertCreate() 
        {

            List<Concert> concertList = new List<Concert>() 
            {


                new Concert { Id = 1, Name = "Luz y Sonido Fest", City = "Madrid", Date = new DateTime(2025, 03, 15), BandId = 1 },
                new Concert { Id = 2, Name = "Luz y Sonido Fest", City = "Madrid", Date = new DateTime(2025, 03, 15), BandId = 5 },
                new Concert { Id = 3, Name = "Luz y Sonido Fest", City = "Madrid", Date = new DateTime(2025, 03, 15), BandId = 7 },
                new Concert { Id = 4, Name = "Luz y Sonido Fest", City = "Madrid", Date = new DateTime(2025, 03, 15), BandId = 24 },

                new Concert { Id = 5, Name = "Sunset Beats", City = "Barcelona", Date = new DateTime(2025, 04, 10), BandId = 13 },
                new Concert { Id = 6, Name = "Sunset Beats", City = "Barcelona", Date = new DateTime(2025, 04, 10), BandId = 3 },
                new Concert { Id = 7, Name = "Sunset Beats", City = "Barcelona", Date = new DateTime(2025, 04, 10), BandId = 20 },

                new Concert { Id = 8, Name = "Ritmo Ibérico", City = "Sevilla", Date = new DateTime(2025, 05, 05), BandId = 2 },
                new Concert { Id = 9, Name = "Ritmo Ibérico", City = "Sevilla", Date = new DateTime(2025, 05, 05), BandId = 22 },
                new Concert { Id = 10, Name = "Ritmo Ibérico", City = "Sevilla", Date = new DateTime(2025, 05, 05), BandId = 10 },
                new Concert { Id = 11, Name = "Ritmo Ibérico", City = "Sevilla", Date = new DateTime(2025, 05, 05), BandId = 4 },

                new Concert { Id = 12, Name = "Ocean Vibes Festival", City = "Valencia", Date = new DateTime(2025, 06, 20), BandId = 1 },
                new Concert { Id = 13, Name = "Ocean Vibes Festival", City = "Valencia", Date = new DateTime(2025, 06, 20), BandId = 17 },
                new Concert { Id = 14, Name = "Ocean Vibes Festival", City = "Valencia", Date = new DateTime(2025, 06, 20), BandId = 3 },
                new Concert { Id = 15, Name = "Ocean Vibes Festival", City = "Valencia", Date = new DateTime(2025, 06, 20), BandId = 6 },

                new Concert { Id = 16, Name = "Montaña Sonora", City = "Granada", Date = new DateTime(2025, 07, 12), BandId = 23},
                new Concert { Id = 17, Name = "Montaña Sonora", City = "Granada", Date = new DateTime(2025, 07, 12), BandId = 7},
                new Concert { Id = 18, Name = "Montaña Sonora", City = "Granada", Date = new DateTime(2025, 07, 12), BandId = 16},
                new Concert { Id = 19, Name = "Montaña Sonora", City = "Granada", Date = new DateTime(2025, 07, 12), BandId = 21},
                new Concert { Id = 20, Name = "Montaña Sonora", City = "Granada", Date = new DateTime(2025, 07, 12), BandId = 12},

                new Concert { Id = 21, Name = "Electro Horizon", City = "Bilbao", Date = new DateTime(2025, 08, 02), BandId = 8 },
                new Concert { Id = 22, Name = "Electro Horizon", City = "Bilbao", Date = new DateTime(2025, 08, 02), BandId = 19},
                new Concert { Id = 23, Name = "Electro Horizon", City = "Bilbao", Date = new DateTime(2025, 08, 02), BandId = 11},
                new Concert { Id = 24, Name = "Electro Horizon", City = "Bilbao", Date = new DateTime(2025, 08, 02), BandId = 13},

                new Concert { Id = 25, Name = "Fiesta del Rock", City = "Zaragoza", Date = new DateTime(2025, 09, 14), BandId = 24},
                new Concert { Id = 26, Name = "Fiesta del Rock", City = "Zaragoza", Date = new DateTime(2025, 09, 14), BandId = 9},
                new Concert { Id = 27, Name = "Fiesta del Rock", City = "Zaragoza", Date = new DateTime(2025, 09, 14), BandId = 14},

                new Concert { Id = 28, Name = "Indie Dreams", City = "San Sebastián", Date = new DateTime(2025, 10, 03), BandId = 15 },
                new Concert { Id = 29, Name = "Indie Dreams", City = "San Sebastián", Date = new DateTime(2025, 10, 03), BandId = 23},
                new Concert { Id = 30, Name = "Indie Dreams", City = "San Sebastián", Date = new DateTime(2025, 10, 03), BandId = 21},
                new Concert { Id = 31, Name = "Indie Dreams", City = "San Sebastián", Date = new DateTime(2025, 10, 03), BandId = 4},

                new Concert { Id = 32, Name = "Costa Beat Festival", City = "Málaga", Date = new DateTime(2025, 06, 28), BandId = 13},
                new Concert { Id = 33, Name = "Costa Beat Festival", City = "Málaga", Date = new DateTime(2025, 06, 28), BandId = 17},
                new Concert { Id = 34, Name = "Costa Beat Festival", City = "Málaga", Date = new DateTime(2025, 06, 28), BandId = 22},
                new Concert { Id = 35, Name = "Costa Beat Festival", City = "Málaga", Date = new DateTime(2025, 06, 28), BandId = 2},

                new Concert { Id = 36, Name = "Aurora Music Fest", City = "Alicante", Date = new DateTime(2025, 11, 08), BandId = 9},
                new Concert { Id = 37, Name = "Aurora Music Fest", City = "Alicante", Date = new DateTime(2025, 11, 08), BandId = 16},
                new Concert { Id = 38, Name = "Aurora Music Fest", City = "Alicante", Date = new DateTime(2025, 11, 08), BandId = 21},

                new Concert { Id = 39, Name = "Ritmos del Sur", City = "Cádiz", Date = new DateTime(2025, 07, 19), BandId = 2},

                new Concert { Id = 40, Name = "Urban Sound Fest", City = "Madrid", Date = new DateTime(2025, 12, 05), BandId = 11},
                new Concert { Id = 41, Name = "Urban Sound Fest", City = "Madrid", Date = new DateTime(2025, 12, 05), BandId = 23},

                new Concert { Id = 42, Name = "Mediterranean Beats", City = "Valencia", Date = new DateTime(2025, 08, 16), BandId = 12},
                new Concert { Id = 43, Name = "Mediterranean Beats", City = "Valencia", Date = new DateTime(2025, 08, 16), BandId = 17},

                new Concert { Id = 44, Name = "Rock & Waves", City = "Santander", Date = new DateTime(2025, 09, 21), BandId = 21},
                new Concert { Id = 45, Name = "Rock & Waves", City = "Santander", Date = new DateTime(2025, 09, 21), BandId = 5},

                new Concert { Id = 46, Name = "Fiesta Sonora", City = "Murcia", Date = new DateTime(2025, 10, 18), BandId = 18}
            };

            return concertList;

       
        
        }
    }
}