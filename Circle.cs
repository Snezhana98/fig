using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace fig
{
    public class Circle : Figures
    {
        public Circle(Canvas canvas, double x, double y) : base(canvas)
        {
            shape = new Ellipse();
            shape.Width = 40;
            shape.Height = 40;
            shape.Fill = Brushes.Green;
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
            shape.Height = b;
            shape.Width = b;
        }

        public override void SetColor()
        {
            shape.Fill = Brushes.Black;
        }
    }
}
