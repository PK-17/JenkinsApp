using System;
using Math;

namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");
            Console.WriteLine("First use of Jenkins!");
            MyMaths m = new MyMaths();
            m.add(50, 50);
            m.multiply(7, 3);
            Console.ReadLine();
        }
    }
}
