using System.Security.Cryptography;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private readonly Shape[] shapes = new Shape[119];
        private int count;
        private enum ShapeType { Point, Ellipse, Line, Rectangle }
        private ShapeType currentType = ShapeType.Line;
        private Shape? current;
        private bool drawing;

        public Form1()
        {
            InitializeComponent();
            Text = "Lab2 - Лінія";
            DoubleBuffered = true;
            miPoint.Click += miPoint_Click;
            miEllipse.Click += miEllipse_Click;
            miLine.Click += miLine_Click;
            miRectangle.Click += miRectangle_Click;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;

        }
        public void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                current = currentType switch
                {
                    ShapeType.Point => new PointShape(e.X, e.Y),
                    ShapeType.Ellipse => new EllipseShape(e.X, e.Y, e.X, e.Y),
                    ShapeType.Line => new LineShape(e.X, e.Y, e.X, e.Y),
                    ShapeType.Rectangle => new RectangleShape(e.X, e.Y, e.X, e.Y),
                    _ => new LineShape(e.X, e.Y, e.X, e.Y)
                };

                drawing = true;
            }
        }
        public void Form1_MouseMove(object? sender, MouseEventArgs e)
        {
            if (drawing && current != null)
            {
                current.X2 = e.X;
                current.Y2 = e.Y;
                Invalidate();
            }
        }
        public void Form1_MouseUp(object? sender, MouseEventArgs e)
        {

            if (!drawing || current == null) return;
            current.X2 = e.X;
            current.Y2 = e.Y;
            if (count < shapes.Length)
                shapes[count++] = current;


            current = null;
            drawing = false;
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int i = 0; i < count; i++)
                shapes[i].Draw(e.Graphics, false);
            if (drawing) current?.Draw(e.Graphics, true);
        }
        private void miPoint_Click(object? sender, EventArgs e)
        {
            currentType = ShapeType.Point;
            Text = "Lab2 - Точка";
        }

        private void miEllipse_Click(object? sender, EventArgs e)
        {
            currentType = ShapeType.Ellipse;
            Text = "Lab2 - Еліпс";
        }
        private void miLine_Click(object? sender, EventArgs e)
        {
            currentType = ShapeType.Line;
            Text = "Lab2 - Лінія";
        }
        private void miRectangle_Click(object? sender, EventArgs e)
        {
            currentType = ShapeType.Rectangle;
            Text = "Lab2 - Прямокутник";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


