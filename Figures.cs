using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace fig
{
    public abstract class Figures
    {
        Canvas canvas;
        protected Shape shape;
        public Figures(Canvas canvas) 
        {
            this.canvas = canvas;
        }
        public abstract void Coord(double x, double y);

        public virtual void Sizes(double a, double b) { }
        public virtual void SetColor()
        {
            
        }
    }
    
}
