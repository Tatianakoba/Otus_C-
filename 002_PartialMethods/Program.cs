﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartialClass instance = new PartialClass();
            instance.CallPartialMethod();
            

            Console.ReadKey();
        }
    }
}
