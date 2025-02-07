﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_R
{
    public class DepartmentFactory
    {
        public IDepartmen CreateItem(string name)
        {
            var assemblyNames = Assembly.GetExecutingAssembly().GetName();

            var userSelection = Type.GetType(assemblyNames.Name +"."+ name);
            var constructor = userSelection.GetConstructor(new Type[] { });
            var item = (IDepartmen)constructor.Invoke(new object[] { });

            return item;

        }
    }
}
