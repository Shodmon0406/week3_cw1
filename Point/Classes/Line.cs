public class Line
{
    Point _begin = new Point();
    Point _end = new Point();
    public Line(int x1, int y1, int x2, int y2)
    {
        _begin.SetXY(x1, y1);
        _end.SetXY(x2, y2);
    }
    public Line(Point begin, Point end)
    {
        _begin = begin;
        _end = end;
    }
    public Point Begin { get => _begin; set => _begin = value; }
    public Point end { get => _end; set => _end = value; }
    public int BeginX { get => _begin.X; set => _begin.X = value; }
    public int BeginY { get => _begin.Y; set => _begin.Y = value; }
    public int endX { get => _end.X; set => _end.X = value; }
    public int endY { get => _end.Y; set => _end.Y = value; }
    public int[] GetBeginXY()
    {
        return _begin.GetXY();
    }
    public void SetBeginXY(int x, int y)
    {
        _begin.X = x;
        _begin.Y = y;
    }
    public int[] GetEndXY()
    {
        return _end.GetXY();
    }
    public void SetEndXY(int x, int y)
    {
        _end.X = x;
        _end.Y = y;
    }
    public override string ToString()
    {
        return $"Line[begin={_begin.ToString()}, end={_end.ToString()}]";
    }
    public double GetLength()
    {
        return _begin.Distance(_end);
    }
}
