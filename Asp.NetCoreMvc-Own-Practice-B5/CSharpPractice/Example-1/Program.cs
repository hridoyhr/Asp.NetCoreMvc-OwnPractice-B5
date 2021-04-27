using System;
using System.Reflection;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Type type = user.GetType();
            PropertyInfo prop = type.GetProperty("Name");
            prop.SetValue(user, "Bangladesh", null);
            prop.SetValue(user, "India", null);

            Console.WriteLine(user.Name);
        }
    }
}
