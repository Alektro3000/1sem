using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Graph
{
    internal class Program
    {
        static void Main()
        {
            //Get Input
            double Input = double.Parse(Console.ReadLine());
            
            //Get Abs value
            if (Input < 0)
                Input = -Input;
            //Main Formula
            double X = ((Input) % 2) - 1;
            //Get Neg value
            if (X < 0)
                X = -X;

            Console.WriteLine(Math.Round(1-X, 3));

        }
    }
}