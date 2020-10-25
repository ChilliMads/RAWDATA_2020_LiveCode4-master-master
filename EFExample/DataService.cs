using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFExample
{
    public class DataService
    {

        // henrik methods
        public IList<Category> GetCategories()
        {
            using var ctx = new NorthWindContext();
            return ctx.Categories.ToList();
        }
        public IList<Product> GetProducts()
        {
            using var ctx = new NorthWindContext();
            return ctx.Products
                .Include(x => x.Category)
                .ToList();
        }
        // end henrik methods

        //Order methods
        public IList<Order> GetSingleOrderById()
        {
            using var orderbyid = new NorthWindContext();
            return (IList<Order>)orderbyid.Orders
                .Include(x => x.Id)
                .ToList();
        }

        public IList<Order> GetOrderByShipname()
        {
            using var ctx = new NorthWindContext();
            return (IList<Order>)ctx.Orders
                .Include(x => x.Id)
                .ToList();
        }
        public IList<Order> ListAllOrders()
        {
            using var ctx = new NorthWindContext();
            return (IList<Order>)ctx.Orders
                .Include(x => x.Id)
                .ToList();
        }
        //end Order methods

        // Order details methods
        public IList<OrderDetails> GetSpecificOrderByID()
        {
            using var ctx = new NorthWindContext();
            return (IList<OrderDetails>)ctx.Orders
                .Include(x => x.Id)
                .Include(x => x.Date)
                .Include(x => x.ShipName)
                .Include(x => x.ShipCity)
                .ToList();
        }
        //end Order details methodss



        
    }
}