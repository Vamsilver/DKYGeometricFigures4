/*
    Vasilev Roman 220P,
    Figures2-Figure,
    27.04.22
 */


using System;

namespace DKYGeometricFigures4
{
    [Serializable]
    public class Figure
    {
        protected Point StartPoint;
        protected StrokeData _strokeData;

        public Figure(Point startPoint, StrokeData strokeData)
        {
            this.StartPoint = startPoint;
            _strokeData = strokeData;
        }
        
        public Figure(int x, int y, StrokeData strokeData)
        {
            _strokeData = strokeData;
            this.StartPoint = new Point(x,y);
        }

        public virtual void Draw(IDrawer drawer)
        {
            //do smth
        }

        public override  string ToString()
        {
            return $"Figure " + StartPoint.ToString() + " "
                + _strokeData.ToString();
        }
    }
}
