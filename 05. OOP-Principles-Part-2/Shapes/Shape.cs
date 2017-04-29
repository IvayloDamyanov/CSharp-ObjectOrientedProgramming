using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        protected double _width;
        protected double _height;

        public double Width
        {
            get { return _width; }
        }
        public double Height
        {
            get { return _height; }
        }
        
        public abstract double CalculateSurface();
    }
}
