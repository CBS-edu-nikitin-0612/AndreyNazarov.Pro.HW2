using System.Collections;

namespace Task4
{
    internal class Comparator : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {
            if (x == null || y == null || !(x is Point) || !(y is Point))
            {
                return false;
            }
            var point1 = (Point)x;
            var point2 = (Point)y;
            return point1.X == point2.X && point1.Y == point2.Y;
        }

        public int GetHashCode(object obj)
        {
            if (obj == null || !(obj is Point))
            {
                return GetHashCode();
            }
            return (obj is Point).GetHashCode();
        }
    }
}
