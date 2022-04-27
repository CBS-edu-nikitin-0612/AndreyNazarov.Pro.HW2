using System;
using System.Collections.Specialized;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary orderedDictionary = new OrderedDictionary(new Comparator());

            orderedDictionary.Add(new Point() { X = 10, Y = 10 }, 1);

            try
            {
                orderedDictionary.Add(new Point() { X = 10, Y = 10 }, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
