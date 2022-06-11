/*
    Vasilev Roman 220P,
    Figures2-Rectangle,
    27.04.22
 */

using System;
using System.Drawing;

namespace DKYGeometricFigures4
{
    [Serializable]
    public class Rectangle : FilledFigure
    {
        private int _width;
        private int _height;

        public Rectangle(Point startPoint, int height, int width,
            StrokeData strokeData, Color fillColor)
            : base(startPoint, strokeData, fillColor)
        {
            this._height = height;
            this._width = width;
        }

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawRectangle(_strokeData, _fillColor, StartPoint, _width, _height);
        }

        public override string ToString()
        {
            return "Rectangle " + StartPoint.ToString() + $" {_height} {_width} "
                + _strokeData.ToString() + $" {_fillColor}";
        }
    }
}
