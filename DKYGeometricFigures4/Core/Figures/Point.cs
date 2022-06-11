/*
    Vasilev Roman 220P,
    Figures2-Point,
    27.04.22
 */

using System;

namespace DKYGeometricFigures4
{
    [Serializable]
    public class Point
    {
        public int X;
        public int Y;
        
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X} {Y}";
        }
    }
}
