using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, decimal> accounts = new();
            accounts.Add(10, 10000m);
            Console.WriteLine(accounts[10]);

            SortedDictionary<int, decimal> accounts2 = new();
            accounts2.Add(10, 1000m);
            Console.WriteLine(accounts2[10]);

            Hashtable accounts3 = new();
            accounts3.Add(10, 1000m);
            Console.WriteLine(accounts3[10]);

            SortedList<int, decimal> accounts4 = new();
            accounts4.Add(10, 1000m);
            Console.WriteLine(accounts4.Values[0]);

            OrderedDictionary  accounts5 = new();
            accounts5.Add(10, 1000m);
            Console.WriteLine(accounts5[0]);
        }
    }
}
