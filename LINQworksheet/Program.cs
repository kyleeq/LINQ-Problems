﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQworksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            Problems problems = new Problems();

            problems.WordsThatContainThWithLINQ(problems.words);
            Console.ReadLine();
        }
    }
}