﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            for(int i=0;i<a;i++)
            {
                if (i == 2)
                    break;
                Console.WriteLine("inside break");
            }
            Console.WriteLine("outside break");
            Console.ReadLine();
        }
    }
}
