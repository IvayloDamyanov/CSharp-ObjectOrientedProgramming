using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            base._width = width;
            base._height = height;
        }

        public override double CalculateSurface()
        {
            double surface = base._width * base._height / 2;
            return surface;
        }
    }
}
