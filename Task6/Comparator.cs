using System.Collections.Generic;
using Task4;


namespace Task6
{
    internal class Comparator : IComparer<Point>
    {
        public int Compare(Point x, Point y)
        {
            return x.X - y.Y + x.Y - y.Y;
        }
    }
}
