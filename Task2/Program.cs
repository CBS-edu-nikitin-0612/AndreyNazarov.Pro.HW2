using System;
using System.Collections;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customers = new();
            customers.Add("Петя", "Овощи");
            customers.Add("Петя", "Мясо");
            customers.Add("Петя", "Молоко");
            customers.Add("Катя", "Овощи");
            customers.Add("Катя", "Мясо");
            customers.Add("Катя", "Молоко");
            customers.Add("Женя", "Овощи");
            customers.Add("Вова", "Овощи");

            customers.PrintDataByCategory("Овощи");
            Console.WriteLine(new string('-', 30));
            customers.PrintDataByCustomer("Петя");
            Console.WriteLine(new string('-', 30));
            customers.PrintDataByCustomer("Оля");
        }
    }
}
