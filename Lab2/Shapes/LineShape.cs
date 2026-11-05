using System.Drawing;
using System.Drawing.Drawing2D;
namespace Lab2
{
    public class LineShape : Shape
    {
        public LineShape(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }


        public override void Draw(Graphics g, bool rubber)

        {
            using var pen = new Pen(Color.Black);
            if (rubber) pen.DashStyle = DashStyle.Dash;
            g.DrawLine(pen, X1, Y1, X2, Y2);
        }
    }
}




