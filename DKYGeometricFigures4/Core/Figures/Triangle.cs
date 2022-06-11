/*
    Vasilev Roman 220P,
    Figures2-Triangle,
    27.04.22
 */

using System;
using System.Drawing;

namespace DKYGeometricFigures4
{
    [Serializable]
    public class Triangle : FilledFigure
    {
        private Point _vertex1
        {
            get => StartPoint;
            set => StartPoint = value;
        }
        private Point _vertex2;
        private Point _vertex3;

        public Triangle(Point vertex1, Point vertex2, Point vertex3,
            StrokeData strokeData, Color fillColor) 
                : base(vertex1, strokeData, fillColor)
        {
            _vertex1 = vertex1;
            _vertex2 = vertex2;
            _vertex3 = vertex3;
        }
        
        public override void Draw(IDrawer drawer)
        {
            drawer.DrawTriangle(_strokeData, _fillColor, StartPoint, _vertex2, _vertex3);
        }

        public override string ToString()
        {
            return "Triangle " + _vertex1.ToString() + " "
                + _vertex2.ToString() + " " + _vertex3.ToString()
                + " " + _strokeData.ToString() + $" {_fillColor}";
        }
    }
}
