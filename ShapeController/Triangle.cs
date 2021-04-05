using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShapeController
{
    public class Triangle : CEmblem
    {
        private Pen _pen;
        private readonly Color _color;
        private readonly Point[] _points;

        public Triangle(Color color, string name, Point[] points) : base(color, name, Rectangle.Empty, points)
        {
            _color = color;
            _points = points;
        }

        public override void DrawEmblem(Graphics graphics)
        {
            using (_pen = new Pen(_color))
                graphics.DrawPolygon(_pen, _points);
        }

        public override void HideEmblem(Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawPolygon(_pen, points);
        }

        public override void ShowEmblem(Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Color color, Point[] points)
        {
            using (_pen = new Pen(color))
                graphics.DrawPolygon(_pen, points);
        }
    }
}