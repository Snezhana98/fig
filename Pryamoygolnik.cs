using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace fig
{
    public class Pryamoygolnik : Figures
    {
        public Pryamoygolnik(Canvas canvas, double x, double y) : base(canvas)
        {
            shape = new Rectangle();
            shape.Height = 60;
            shape.Width = 40;
            shape.Fill = Brushes.Yellow;
            canvas.Children.Add(shape);
            Coord(x, y);
            Sizes(shape.Height, shape.Width);

        }

        public override void Coord(double x, double y)
        {
            Canvas.SetTop(shape, y);
            Canvas.SetLeft(shape, x);
        }
        public override void Sizes(double a, double b)
        {
            shape.Height = a;
            shape.Width = b;
        }
        public override void SetColor()
        {
            shape.Fill = Brushes.GreenYellow;
        }

    }
}
