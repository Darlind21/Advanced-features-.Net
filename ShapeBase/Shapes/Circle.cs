using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeBase.Shapes
{
    internal class Circle : ShapeBase
    {
        public double radius { get; set; }
        public override void CalculatePerimeter()
        {
            double perimetri = radius * 2 * Math.PI;
            Console.WriteLine(perimetri);
        }

        public override void CalculateSurface()
        {
            double siperfaqja =Math.PI * Math.Pow(radius, 2);
            Console.WriteLine(siperfaqja);
        }
    }
}
