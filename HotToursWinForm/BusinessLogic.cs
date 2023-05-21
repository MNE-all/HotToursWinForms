
using HotTours.Models;

namespace HotTours
{
    public class BusinessLogic
    {
        public static List<User> GetUsers()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                if (users == null || users.Count == 0)
                {
                    var user = new User
                    {
                        Login = "user",
                        Password = "user",
                        IsAdmin = false,
                    };
                    var admin = new User
                    {
                        Login = "admin",
                        Password = "admin",
                        IsAdmin = true,
                    };
                    db.Users.Add(admin);
                    db.Users.Add(user);
                    db.SaveChanges();
                    users = db.Users.ToList();
                }
                return users;
            }
        }

        public static List<Tour> Read()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var tours = db.Tours.ToList();
                return tours;
            }
        }
        public static void AddTour(Tour tour)
        {
            tour.Guid = Guid.NewGuid();
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Tours.Add(tour);
                db.SaveChanges();
            }
        }


        public static void EditTour(Tour tour, Guid index)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (db.Tours.FirstOrDefault(x => x.Guid == index) != null)
                {
                    db.Tours.First(x => x.Guid == index).WiFi = tour.WiFi;
                    db.Tours.First(x => x.Guid == index).PriceForMan = tour.PriceForMan;
                    db.Tours.First(x => x.Guid == index).TotalPrice = tour.TotalPrice;
                    db.Tours.First(x => x.Guid == index).Direction = tour.Direction;
                    db.Tours.First(x => x.Guid == index).AmountOfDays = tour.AmountOfDays;
                    db.Tours.First(x => x.Guid == index).AmountOfMan = tour.AmountOfMan;
                    db.Tours.First(x => x.Guid == index).Date = tour.Date;
                    db.Tours.First(x => x.Guid == index).Surcharge = tour.Surcharge;

                    db.SaveChanges();
                }
            }
        }

        public static void DeleteTour(Tour tour)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Tours.Remove(tour);
                db.SaveChanges();
            }
        }

        public static List<Tour> GenerateTours()
        {
            Random rnd = new Random();
            using (ApplicationContext db = new ApplicationContext())
            {
                var tours = db.Tours.ToList();
                if (tours == null || tours.Count == 0)
                {
                    for (var i = 0; i < 100; i++)
                    {
                        var priceForMan = rnd.Next(500, 3000);
                        var amountOfDays = (uint)rnd.Next(1, 18);
                        var amountOfMan = (uint)rnd.Next(1, 8);
                        var surcharge = rnd.NextDouble() >= 0.5 ? rnd.Next(500, 15000) : 0;
                        var tour = new Tour
                        {
                            Guid = Guid.NewGuid(),
                            WiFi = rnd.NextDouble() >= 0.5,
                            PriceForMan = priceForMan,
                            Direction = Tour.Directions[rnd.Next(Tour.Directions.Length)],
                            AmountOfDays = amountOfDays,
                            AmountOfMan = amountOfMan,
                            Date = DateTime.Now.AddDays(rnd.Next(1000)),
                            Surcharge = surcharge,
                            TotalPrice = surcharge + amountOfMan * amountOfDays * priceForMan,
                        };
                        db.Tours.Add(tour);
                    }
                    db.SaveChanges();
                    tours = db.Tours.ToList();
                }
                return tours;
            }
        }
    }
}
