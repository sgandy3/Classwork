﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop30917
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i<= n; i+=2)
            {
                if(i % 6 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
