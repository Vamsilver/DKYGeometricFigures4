/*
    Vasilev Roman 220P,
    Figures2-Circle,
    27.04.22
 */

using System;
using System.Drawing;

namespace DKYGeometricFigures4
{
    [Serializable]
    public class Circle : FilledFigure
    {
        private int _radius;

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawCircle(_strokeData, _fillColor, StartPoint, _radius);
        }

        public Circle(Point startPoint, int radius, StrokeData strokeData, Color fillColor) 
                : base(startPoint, strokeData, fillColor)
        {
            this._radius = radius;
        }

        public override string ToString()
        {
            return "Circle " + StartPoint.ToString() + $" {_radius} " + _strokeData.ToString() + $" {_fillColor}";
        }
    }
}
