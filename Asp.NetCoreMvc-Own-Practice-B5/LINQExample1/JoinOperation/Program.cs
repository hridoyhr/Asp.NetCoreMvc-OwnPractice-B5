using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinOperation
{
    class Program
    {
        static List<Product> products = new List<Product>
        {
           new Product { Name = "Cola", CategoryID = 0},
           new Product { Name = "Tea", CategoryID = 0},
           new Product { Name = "Apple", CategoryID = 1},
           new Product { Name = "Kiwi", CategoryID = 1},
           new Product { Name = "Carrot", CategoryID = 2}
        };

        static List<Category> categories = new List<Category>
        {
           new Category { ID = 0, CategoryName = "Breverage"},
           new Category { ID = 1, CategoryName = "Fruits"},
           new Category { ID = 2, CategoryName = "Vegitable"}
        };

        static void Main(string[] args)
        {
            var query = from product in products
                        join category in categories on product.CategoryID equals category.ID
                        select new{product.Name, category.CategoryName};

            foreach(var item in query)
                Console.WriteLine($"{item.Name} - {item.CategoryName}");
        }
    }
}
