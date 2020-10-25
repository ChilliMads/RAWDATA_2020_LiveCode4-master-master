using System;
namespace EFExample
{
    public class Order
    {

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime Require { get; set; }

        public DateTime Shipped { get; set; }

        public string Freight { get; set; }

        public string ShipName { get; set; }

        public string ShipCity { get; set; }

    }
}
