/*
    Vasilev Roman 220P,
    Figures2-FilledFigure,
    27.04.22
 */


using System;
using System.Drawing;

namespace DKYGeometricFigures4
{
    [Serializable]
    public class FilledFigure : Figure
    {
        protected Color _fillColor;
        
        protected FilledFigure(Point startPoint, StrokeData strokeData, Color fillColor)
            : base(startPoint, strokeData)
        {
            this._strokeData = strokeData;
            _fillColor = fillColor;
        }

        public override string ToString()
        {
            return "Filled figure " + StartPoint.ToString() + " "
                + _strokeData.ToString() + $" {_fillColor}";
        }
    }
}
