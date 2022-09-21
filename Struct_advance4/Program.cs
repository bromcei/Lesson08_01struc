var pirmasTaskas = new Point(0, 4);
var antrasTaskas = new Point(4, 0);
var kvadratas = new Rectangle(pirmasTaskas, antrasTaskas);
var checkPoint = new Point(1, 1);
var checkPoint2 = new Point(5, 1);
Console.WriteLine(checkPoint.PointCordinates());
Console.WriteLine(kvadratas.CheckIfPointInRectangle(checkPoint));
Console.WriteLine(kvadratas.CheckIfPointInRectangle(checkPoint2));
struct Point
{
    public int X;
    public int Y;
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public string PointCordinates()
    {
        return $"Ivesto tasko koordinates: ({X}, {Y})";
    }

}
struct Rectangle
{
    public Point TopLeft;
    public Point BottomRight;
    public Rectangle(Point topleft, Point bottomright)
    {
        TopLeft = topleft;
        BottomRight = bottomright;
    }
    public string RectangleCordinatesString()
    {
        return $"(({TopLeft.X}, {TopLeft.Y}), ({BottomRight.X}, {BottomRight.Y}))";
    }
    public string CheckIfPointInRectangle(Point checkPoint)
    {
        if (checkPoint.X <= BottomRight.X && checkPoint.X >= TopLeft.X && checkPoint.Y <= TopLeft.Y && checkPoint.Y >= BottomRight.Y)
        {
            return $"Taskas ({checkPoint.X}, {checkPoint.Y}) yra staciakampyuje {RectangleCordinatesString()}"; 
        }
        else
        {
            return $"Taskas ({checkPoint.X}, {checkPoint.Y}) nera staciakampyje {RectangleCordinatesString()}";
        }   
    }
}