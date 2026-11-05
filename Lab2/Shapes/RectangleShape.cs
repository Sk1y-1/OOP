using System.Drawing.Drawing2D;

namespace Lab2
{
    public class RectangleShape : Shape
    {
        public override void Draw(Graphics g, bool rubber)
        {
            int dx = Math.Abs(X2 - X1);
            int dy = Math.Abs(Y2 - Y1);

            int left = X1 - dx;
            int top = Y1 - dy;
            int width = dx * 2;
            int height = dy * 2;

            using var pen = new Pen(Color.Black);
            if (rubber) pen.DashStyle = DashStyle.Dash;
            g.DrawRectangle(pen, left, top, width, height);
        }
        public RectangleShape(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }
    }
  }

