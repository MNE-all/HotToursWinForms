namespace HotTours.Models
{
    public class Tour
    {

        static public string[] Directions =
        {
            "Египет",
            "Крым",
            "ОАЭ",
            "Тунис",
            "Турция",
        };
        public Guid Guid { get; set; }
        public string Direction { get; set; }
        public DateTime Date { get; set; }
        public uint AmountOfDays { get; set; }
        public decimal PriceForMan { get; set; }
        public uint AmountOfMan { get; set; }
        public bool WiFi { get; set; }
        public decimal Surcharge { get; set; }
        public decimal TotalPrice { get; set; }
    }

}
