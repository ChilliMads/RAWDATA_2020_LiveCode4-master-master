
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var dataService = new DataService();

            /*foreach (var elem in dataService.GetProducts())
            {
                Console.WriteLine(elem);
            }*/

            foreach (var elem in dataService.GetSingleOrderById())
            {
                Console.WriteLine(elem);
            }

            //using var ctx = new NorthWindContext();

            //foreach (var product in ctx.Products.Include(x => x.Category))
            //{
            //    Console.WriteLine(product);
            //}


            //var cat = ctx.Categories.Find(9);

            //ctx.Categories.Remove(cat);

            ////cat.Name = "UpdateTest";
            ////cat.Description = "fdsjfsldkjfsdlkf";

            ////var maxId = ctx.Categories.Max(x => x.Id);

            ////ctx.Categories.Add(new Category {Id = maxId + 1, Name = "Testing"});

            //ctx.SaveChanges();

            //foreach (var category in ctx.Categories)
            //{
            //    Console.WriteLine(category);
            //}
        }
    }
}
