using System;

struct Point {
  public Int32 x;
  public Int32 y;
}

class Program
{
  public static void Main()
  {
    Point p;
    p.x = p.y = 1;
    Object o = p; // Boxes

    p = (Point) o; // unbox and copy

    p.x = 2;
    o = p;
  }
}
