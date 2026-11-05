using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab2 { 
public abstract class Shape (int x1, int y1, int x2, int y2)
{
    public int X1 { get; set; } = x1;
    public int Y1 { get; set; } = y1;
    public int X2 { get; set; } = x2;
    public int Y2 { get; set; } = y2;

    public abstract void Draw(Graphics g, bool rubber);
  }
}