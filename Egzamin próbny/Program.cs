public static double TriangleArea(int a, int b, int c, int precision = 2)
{
    double obw = (a + b + c);
    double hobw = obw / 2;
    double area = Math.Sqrt((hobw * (hobw - a) * (hobw - b) * (hobw - c)));
    if (precision < 2 || precision > 8)
    {
        throw new ArgumentOutOfRangeException("wrong arguments");
    }
    if (a < 0 || b < 0 || c < 0)
    {
        throw new ArgumentOutOfRangeException("wrong arguments");
    }
    if (a + b < c || b + a < c || c + b < a)
    {
        throw new ArgumentException("object not exist");
    }
    return area;
}