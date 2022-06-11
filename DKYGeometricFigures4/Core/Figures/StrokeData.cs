/*
    Vasilev Roman 220P,
    Figures2-StrokeData,
    27.04.22
 */
using System;
using System.Drawing;

namespace DKYGeometricFigures4
{
    [Serializable]
    public struct StrokeData
    {
        public int Width;
        public Color Color;

        public StrokeData(int width, Color colorHex)
        {
            this.Width = width;
            this.Color = colorHex;
        }

        public override string ToString()
        {
            return $"{Width} {Color}";
        }
    }
}