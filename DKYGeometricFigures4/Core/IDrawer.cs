using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKYGeometricFigures4
{
    public interface IDrawer
    {
        public void DrawRectangle(StrokeData pen, Color fillColor, Point basePoint, int width,
            int height);

        public void DrawTriangle(StrokeData pen, Color fillColor, Point a, Point b, Point c);

        public void DrawLine(StrokeData pen, Point basePoint, Point secondPoint);

        public void DrawCircle(StrokeData pen, Color fillColor, Point basePoint, int radius);
    }
}
