using System;

namespace Task2
{
    internal class Category : IComparable<Category>
    {
        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public int CompareTo(Category other)
        {
            return Name.CompareTo(other.Name);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Category))
            {
                return false;
            }
            return (obj as Category).Name.Equals(Name);
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
