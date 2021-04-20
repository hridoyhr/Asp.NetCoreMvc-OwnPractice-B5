using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class GameItemFactory
    {
        public IGameItem CreateItem(string name)
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            var userSelection = Type.GetType(assemblyName.Name + "." + name);
            var constructor = userSelection.GetConstructor(new Type[] { });
            var item = (IGameItem)constructor.Invoke(new object[] { });

            return item;
        }
    }
}
