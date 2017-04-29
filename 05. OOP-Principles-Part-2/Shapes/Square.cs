using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        public Square(double width, double height)
        {
            base._width = width;
            if (height == width)
            {
                base._height = height;
            }
            else
            {
                base._height = width; //height must be kept equal to width ...?!
                Console.WriteLine("A square can not have sides with different size! (width: {0}, height: {1})\nMaking height same as width - {0}", width, height);
            }
        }

        public override double CalculateSurface()
        {
            double surface = base._width * base._height;
            return surface;
        }
    }
}
