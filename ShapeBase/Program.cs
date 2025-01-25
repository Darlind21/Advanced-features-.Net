using ShapeBase.Shapes;
using System.Drawing;

Rectangle_ rectangle1 = new Rectangle_()
{
    height = 10,
    width = 5,
};

Circle circle1 = new Circle()
{
    radius = 10,
};

rectangle1.CalculateSurface();
rectangle1.CalculatePerimeter();

circle1.CalculateSurface();
circle1.CalculatePerimeter();