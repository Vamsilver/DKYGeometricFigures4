using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKYGeometricFigures4
{
    class Drawer : IDrawer
    {
        private readonly Graphics graphics;

        public Drawer(Graphics g)
        {
            graphics = g;
        }

        public void DrawCircle(StrokeData pen, Color fillColor, Point basePoint, int radius)
        {
            SolidBrush brush = new SolidBrush(fillColor);

            graphics.FillEllipse(brush, basePoint.X - radius,
                basePoint.Y - radius, radius * 2, radius * 2);

            graphics.DrawEllipse(StrokeDataToPen(pen), basePoint.X - radius,
                basePoint.Y - radius, radius * 2, radius * 2);

        }

        public void DrawLine(StrokeData pen, Point basePoint, Point secondPoint)
        {
            graphics.DrawLine(StrokeDataToPen(pen), basePoint.X, basePoint.Y, secondPoint.X, secondPoint.Y);
        }

        public void DrawRectangle(StrokeData pen, Color fillColor, Point basePoint, int width, int height)
        {
            SolidBrush brush = new SolidBrush(fillColor);

            graphics.FillRectangle(brush, basePoint.X,
               basePoint.Y, width, height);

            graphics.DrawRectangle(StrokeDataToPen(pen), basePoint.X,
               basePoint.Y, width, height);
        }

        public void DrawTriangle(StrokeData pen, Color fillColor, Point a, Point b, Point c)
        {
            SolidBrush brush = new SolidBrush(fillColor);

            graphics.FillPolygon(brush, new[] { new PointF(a.X,a.Y), new PointF(b.X, b.Y), new PointF(c.X, c.Y)});

            graphics.DrawPolygon(StrokeDataToPen(pen), new[] { new PointF(a.X, a.Y), 
                new PointF(b.X, b.Y), new PointF(c.X, c.Y) });
        } 

        public static Pen StrokeDataToPen(StrokeData data)
        {
            return new Pen(data.Color, data.Width);
        }
    }
}
