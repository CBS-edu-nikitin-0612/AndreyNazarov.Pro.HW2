using System;
using System.Collections.Generic;
using Task4;


namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<Point, string> list = new(new Comparator());
            list.Add(new Point() { X = 10, Y = 10 }, "1");
            list.Add(new Point() { X = 100, Y = 100 }, "2");
            list.Add(new Point() { X = 1, Y = 1 }, "3");
            list.Add(new Point() { X = 1000, Y = 1000 }, "4");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
