using System;
using System.Collections.Generic;

namespace Task2
{
    internal class Customers
    {
        private Dictionary<Customer, List<Category>> customers;
        private Dictionary<Category, List<Customer>> categoryes;

        public Customers()
        {
            this.customers = new Dictionary<Customer, List<Category>>();
            this.categoryes = new Dictionary<Category, List<Customer>>();
        }

        public void Add(string customerName, string categoryName)
        {
            var customer = new Customer(customerName);
            var category = new Category(categoryName);

            if (!customers.ContainsKey(customer))
            {
                customers.Add(customer, new List<Category> { category });

            }
            if (!customers[customer].Contains(category))
            {
                customers[customer].Add(category);
            };

            if (!categoryes.ContainsKey(category))
            {
                categoryes.Add(category, new List<Customer> { customer });
            }
            if (!categoryes[category].Contains(customer))
            {
                categoryes[category].Add(customer);
            }
        }
        public void PrintDataByCustomer(string customer)
        {
            Customer temp = new(customer);
            if (!customers.ContainsKey(temp)) return;
            Console.WriteLine($"Покупатель: ({customer}) покупает следующие категории:");
            foreach (var category in customers[temp])
            {
                Console.WriteLine(category);
            }
        }
        public void PrintDataByCategory(string category)
        {
            Category temp = new(category);
            if (!categoryes.ContainsKey(temp)) return;
            Console.WriteLine($"Категорию: ({category}) покупают следующие покупатели:");
            foreach (var customer in categoryes[temp])
            {
                Console.WriteLine(customer);
            }
        }
    }
}
