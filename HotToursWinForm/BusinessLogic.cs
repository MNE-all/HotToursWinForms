
using HotTours.Models;

namespace HotTours
{
    public class BusinessLogic
    {
        public static List<User> GetUsers()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var tours = db.Users.ToList();
                if (tours == null || tours.Count == 0)
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
                    tours = db.Users.ToList();
                }
                return tours;
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
    }
}
