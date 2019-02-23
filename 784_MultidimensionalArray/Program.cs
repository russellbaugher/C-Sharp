﻿using static System.Console;

namespace _784_MultidimensionalArray
{
    class Program
    {
        static void Main()
        {
            decimal[,] a = new decimal[3, 3]; //3x3 array
            a[0, 0] = 10; a[0, 1] = 30; a[0, 2] = 80;
            a[1, 0] = 40; a[1, 1] = 50; a[1, 2] = 70;
            a[2, 0] = 45; a[2, 1] = 55; a[2, 2] = 60;
            WriteLine(a[0, 1]); //30
            WriteLine(a[1, 1] / a[0, 0]); //5
            WriteLine($"{a[1, 0]:C}"); //$40
        }
    }
}
