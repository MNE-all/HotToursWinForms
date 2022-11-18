﻿namespace Hot_tours.Models
{
    public class Tour
    {
        public Guid Guid { get; set; }
        public Direction Direction { get; set; }
        public DateTime Date { get; set; }
        public uint AmountOfDays { get; set; }
        public decimal PriceForMan { get; set; }
        public uint AmountOfMan { get; set; }
        public bool WiFi { get; set; }
        public decimal Surcharge { get; set; }
        public decimal TotalPrice { get; set; }
    }

}
