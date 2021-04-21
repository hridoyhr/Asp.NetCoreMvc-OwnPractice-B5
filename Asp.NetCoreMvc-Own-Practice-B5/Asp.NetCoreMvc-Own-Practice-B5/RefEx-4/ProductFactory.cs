using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RefEx_4
{
    public class ProductFactory
    {
        public IProduct CreateItem(string name)
        {
            var assemblyProduct = Assembly.GetExecutingAssembly().GetName();

            var userSelection = Type.GetType(assemblyProduct.Name + "." + name);
            var constructor = userSelection.GetConstructor(new Type[] { });
            var item = (IProduct)constructor.Invoke(new object[] { });

            return item;
        }
    }
}
