﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StrmRdEx0929CdEv
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("..//..//ThreeLines.txt"))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    Console.ReadLine(reader);

                    //last slide 0929
                } 

        }
    }
}
