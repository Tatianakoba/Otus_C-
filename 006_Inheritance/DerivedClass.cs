﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Inheritance
{
    internal class DerivedClass: BaseClass
    {
        //Замещение метода базового класса.
        public void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
}
