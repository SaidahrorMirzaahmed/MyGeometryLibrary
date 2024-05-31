using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeometryLibrary.Shapes;

public class Circle(double radius) : IShape
{

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}
