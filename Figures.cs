using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace fig
{
    abstract class Figures
    {
        Canvas canvas;
        protected Shape shape;
        Figures(Canvas canvas) { }
        abstract Coord(double x, double y) { }
        virtual SetCorol(Brush col)
        {
            Shape.Fill = col;
        }
    }
    class Box: Figures
    {
        Box(Canvas canvas, double x, double y) :Figures(canvas)
        {
            shape = new Rectangle();
            Canvas.Children.Add(shape);
            Canvas.SetTop(shape,  y);
            Canvas.SetLeft(shape, x);
            override Coord (double x, double y) {
            Canvas.SetTop(shape, y);
            Canvas.SetLeft(shape, x);
        }
        }
    }
}
