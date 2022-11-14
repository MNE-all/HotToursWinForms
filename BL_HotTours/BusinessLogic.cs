using Hot_Tours_BL.Models;

namespace Hot_Tours_BL
{
    public class BusinessLogic
    {
        private List<Tour> tours = new List<Tour>();
        public List<Tour> Tours
        {
            get { return tours; }
        }

        public void AddTour(Tour tour)
        {
            tour.Guid = Guid.NewGuid();
            tours.Add(tour);
        }

        public void EditTour(Tour tour, int index)
        {
            tours[index] = tour;
        }

        public void DeleteTour(Tour tour)
        {
            tours.Remove(tour);
        }

        public string ToursAmount()
        {
            return ("Всего туров: " + tours.Count().ToString());
        }

        public string TotalSum()
        {
            decimal sum = 0;
            foreach (Tour tour in tours)
            {
                sum += tour.TotalPrice;
            }
            return ("Общая сумма: " + sum.ToString());
        }

        public string SurchargeAmount()
        {
            return ("Туров с доплатами: " +
                tours.Where(x => x.Surcharge > 0).Count().ToString());
        }

        public string SurchargeSum()
        {
            decimal sum = 0;
            foreach (Tour tour in tours)
            {
                sum += tour.Surcharge;
            }
            return ("Сумма доплат: " + sum.ToString());
        }



    }
}