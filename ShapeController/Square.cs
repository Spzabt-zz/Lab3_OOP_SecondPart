using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShapeController
{
    public class Square : CEmblem
    {
        private Pen _pen;
        private readonly Color _color;
        private readonly Rectangle _rectangle;

        public Square(Color color, string name, Rectangle rectangle, Point[] points) : base(color, name, rectangle, points)
        {
            _color = color;
            _rectangle = rectangle;
        }

        public override void DrawEmblem(Graphics graphics)
        {
            using (_pen = new Pen(_color))
                graphics.DrawRectangle(_pen, _rectangle);
        }

        public override void HideEmblem(Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawRectangle(_pen, rectangle);
        }

        public override void ShowEmblem(Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Color color, Point[] points)
        {
            using (_pen = new Pen(color))
                graphics.DrawRectangle(_pen, rectangle);
        }
    }
}