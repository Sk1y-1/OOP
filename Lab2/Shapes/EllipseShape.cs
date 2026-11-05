using System.Drawing;
using System.Drawing.Drawing2D;
namespace Lab2 {
	public class EllipseShape : Shape
	{
		public EllipseShape(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }
		public override void Draw(Graphics g, bool rubber)
		{
			var rect = new Rectangle(Math.Min(X1, X2), Math.Min(Y1, Y2), Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
			using var pen = new Pen(Color.Black);
			if (rubber) pen.DashStyle = DashStyle.Dash;
			if (!rubber) g.FillEllipse(Brushes.Yellow, rect);
            
			g.DrawEllipse(pen, rect);
			}
		 }
	 }
