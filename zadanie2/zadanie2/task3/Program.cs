using System;

public class Rectangle
{
    private int x, y, width, height;

    public Rectangle(int x, int y, int width, int height)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    public void Move(int dx, int dy)
    {
        x += dx;
        y += dy;
    }
    public void Resize(int newWidth, int newHeight)
    {
        width = newWidth;
        height = newHeight;
    }

    public static Rectangle Intersect(Rectangle rect1, Rectangle rect2)
    {
        int left = Math.Max(rect1.x, rect2.x);
        int top = Math.Max(rect1.y, rect2.y);
        int right = Math.Min(rect1.x + rect1.width, rect2.x + rect2.width);
        int bottom = Math.Min(rect1.y + rect1.height, rect2.y + rect2.height);

        if (right > left && bottom > top)
        {
            return new Rectangle(left, top, right - left, bottom - top);
        }
        else
        {

            return null;
        }
    }

    public void Show()
    {
        Console.WriteLine($"Rectangle: X={x}, Y={y}, Width={width}, Height={height}");
    }

    static void Main()
    {
        Rectangle rect1 = new Rectangle(10, 20, 30, 40);
        Rectangle rect2 = new Rectangle(25, 30, 20, 15);

        rect1.Move(5, 5);
        rect2.Resize(10, 10);

        Rectangle intersection = Intersect(rect1, rect2);
        if (intersection != null)
        {
            intersection.Show();
        }
        else
        {
            Console.WriteLine("Rectangles do not intersect.");
        }
        Console.ReadLine();
    }
}
