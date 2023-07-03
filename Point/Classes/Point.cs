public class Point
{
    int _x = 0;
    int _y = 0;
    public Point()
    {
        
    }
    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }
    public int X { get => _x; set => _x = value; }
    public int Y { get => _y; set => _y = value; }
    public override string ToString()
    {
        return $"({_x}, {_y})";
    }
    public int[] GetXY()
    {
        int[] arr = new int[2]{_x, _y};
        return arr;
    }
    public void SetXY(int x, int y)
    {
        _x = x;
        _y = y;
    }
    public double Distance(int x, int y)
    {
        return Math.Sqrt(Math.Pow((_x - x), 2) + Math.Pow((_y - y), 2));
    }
    public double Distance(Point another)
    {
        return Math.Sqrt(Math.Pow((_x - another._x), 2) + Math.Pow((_y - another._y), 2));
    }
    public double Distance()
    {
        return Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
    }
}
