using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample
{
    public class OrderDetails
    {
        public Double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }

        /*public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }*/
    }
}
