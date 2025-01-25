using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeBase.Shapes
{
    internal class Rectangle_ : ShapeBase
    {
        public int height { get; set; }
        public int width { get; set; }

        public override void CalculatePerimeter()
        {
            int perimetri = 2 * height + 2 * width;
            Console.WriteLine(perimetri);
        }
        public override void CalculateSurface()
        {
            int siperfaqja = height * width;
            Console.WriteLine(siperfaqja);
        }
    }
}
