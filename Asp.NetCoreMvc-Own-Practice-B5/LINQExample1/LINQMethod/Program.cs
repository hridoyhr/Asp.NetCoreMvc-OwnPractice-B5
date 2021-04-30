using System;
using System.Linq;

namespace LINQMethod
{
    class Program
    {
        static Plant[] plants = new Plant[]
            {
                new CategoryPlant { Name = "Vanus Fly Trap", TrapType = "Snap Trap"},
                new CategoryPlant { Name = "Pitcher Plant", TrapType = "Pitfall tarap"},
                new CategoryPlant { Name = "Sundew", TrapType = "Flypaper Trap"},
                new CategoryPlant { Name = "Water Wheel Plant", TrapType = "Snap Trap"}
            };
        static void Main(string[] args)
        {
            var query = from CategoryPlant plant in plants
                        where plant.TrapType == "Snap Trap"
                        select plant;

            foreach(Plant plant in query)
                Console.WriteLine(plant.Name);

        }
    }
}
