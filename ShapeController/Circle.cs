using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShapeController
{
    public class Circle : CEmblem
    {
        private Pen _pen;
        private readonly Color _color;
        private readonly Rectangle _rectangle;

        public Circle(Color color, string name, Rectangle rectangle, Point[] points) : base(color, name, rectangle, points)
        {
            _rectangle = rectangle;
            _color = color;
        }

        public override void DrawEmblem(Graphics graphics)
        {
            using (_pen = new Pen(_color))
                graphics.DrawEllipse(_pen, _rectangle);
        }

        public override void HideEmblem(Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawEllipse(_pen, rectangle);
        }

        public override void ShowEmblem(Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Color color, Point[] points)
        {
            using (_pen = new Pen(color))
                graphics.DrawEllipse(_pen, rectangle);
        }
    }
}