using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace fig
{
    public class Box : Figures
    {
        public Box(Canvas canvas, double x, double y) : base(canvas)
        {
            shape = new Rectangle();
            shape.Height = 40;
            shape.Width = 40;
            shape.Fill = Brushes.Red;
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
            shape.Fill = Brushes.Gray;
        }

    }
}
