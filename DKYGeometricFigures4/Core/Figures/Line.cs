/*
    Vasilev Roman 220P,
    Figures2-Line,
    27.04.22
 */

using System;

namespace DKYGeometricFigures4
{
    [Serializable]
    public class Line : Figure
    {
        private Point _vertex1
        {
            get => StartPoint;
            set => StartPoint = value;
        }
        private Point _vertex2;

        public Line(Point vertex1, Point vertex2, StrokeData strokeData)
            : base(vertex1, strokeData)
        {
            _vertex1 = vertex1;
            _vertex2 = vertex2;
        }


        public override void Draw(IDrawer drawer)
        {
            drawer.DrawLine(_strokeData, StartPoint, _vertex2);
        }

        public override string ToString()
        {
            return "Line " + _vertex1.ToString() + " "
                + _vertex2.ToString() + " " + _strokeData.ToString();
        }
    }
}
