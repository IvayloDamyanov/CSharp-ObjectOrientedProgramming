using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Startup
    {
        static void Main(string[] args)
        {
            #region Shapes initialization
            Triangle trA = new Triangle(6, 2);
            Triangle trB = new Triangle(3.4, 5.8);
            Rectangle rectA = new Rectangle(6, 2);
            Rectangle rectB = new Rectangle(3.4, 5.8);
            Square sqA = new Square(3, 3);
            Square sqB = new Square(5, 7); //incorrect square
            Shape[] shapes = new Shape[] { trA, trB, rectA, rectB, sqA, sqB };
            #endregion

            #region Calculate surface test
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
            #endregion
            
        }
    }
}
