
using Hot_tours.Models;

namespace Hot_tours
{
    public class BusinessLogic
    {
        public static List<Tour> Read()
        {
            using (ApplicationContext db = new ApplicationContext(DataBaseHelper.Options()))
            {
                var tours = db.Tours.ToList();
                return tours;
            }
        }
        public static void AddTour(Tour tour)
        {
            tour.Guid = Guid.NewGuid();
            using (ApplicationContext db = new ApplicationContext(DataBaseHelper.Options()))
            {
                db.Tours.Add(tour);
                db.SaveChanges();
            }
        }

        public static void EditTour(Tour tour, Guid index)
        {
            using (ApplicationContext db = new ApplicationContext(DataBaseHelper.Options()))
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
            using (ApplicationContext db = new ApplicationContext(DataBaseHelper.Options()))
            {
                db.Tours.Remove(tour);
                db.SaveChanges();
            }
        }

        public static string ToursAmount()
        {
            using (ApplicationContext db = new ApplicationContext(DataBaseHelper.Options()))
            {
                return ("Всего туров: " + db.Tours.Count().ToString());
            }
        }

        public static string TotalSum()
        {
            decimal sum = 0;

            using (ApplicationContext db = new ApplicationContext(DataBaseHelper.Options()))
            {
                foreach (Tour tour in db.Tours)
                {
                    sum += tour.TotalPrice;
                }
                return ("Общая сумма: " + sum.ToString());
            }
        }

        public static string SurchargeAmount()
        {

            using (ApplicationContext db = new ApplicationContext(DataBaseHelper.Options()))
            {
                return ("Туров с доплатами: " +
                db.Tours.Where(x => x.Surcharge > 0).Count().ToString());
            }
        }

        public static string SurchargeSum()
        {
            decimal sum = 0;

            using (ApplicationContext db = new ApplicationContext(DataBaseHelper.Options()))
            {
                foreach (Tour tour in db.Tours)
                {
                    sum += tour.Surcharge;
                }
                return ("Сумма доплат: " + sum.ToString());
            }
        }



    }
}
