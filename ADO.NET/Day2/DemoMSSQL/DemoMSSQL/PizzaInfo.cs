using System;

namespace DemoMSSQL
{
    public class PizzaInfo
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime? Date { get; set; }

        public override string ToString()
        {
            return $"{Name} {Price:N2} {Date:g}";
        }
    }
}