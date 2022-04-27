using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Task2
{
    internal class Customer : IComparable<Customer>
    {
        public Customer(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public int CompareTo(Customer other)
        {
            return Name.CompareTo(other.Name);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Customer))
            {
                return false;
            }
            return (obj as Customer).Name.Equals(Name);
        }      

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }    

        public override string ToString()
        {
            return Name;
        }
    }
}
