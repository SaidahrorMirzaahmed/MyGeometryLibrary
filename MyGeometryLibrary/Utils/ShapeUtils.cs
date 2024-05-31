using MyGeometryLibrary.Shapes;

namespace MyGeometryLibrary.Utils;

public static class ShapeUtils
{
    public static double CalculateShapeArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}
