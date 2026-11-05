using System.Drawing;
namespace Lab2 { 
public class PointShape : Shape
{
	public PointShape(int x, int y) : base(x, y, x, y) { }
        public override void Draw(Graphics g, bool rubber)
{
        g.FillEllipse(Brushes.Black, X1 - 2, Y1 - 2, 4, 4);
    }
  }
}
