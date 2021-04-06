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

        public Square(Color color, string name, Rectangle rectangle, Point[] points) : base(color, name, rectangle,
            points)
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

        public override void ShowEmblem(Graphics graphics, Rectangle rectangle, Color color, Point[] points)
        {
            using (_pen = new Pen(color))
                graphics.DrawRectangle(_pen, rectangle);
        }

        public override void EnlargeObject(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox,
            Rectangle rectangle, Point[] points, Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawRectangle(_pen, rectangle);
            int x = rectangle.X, y = rectangle.Y, width = rectangle.Width, height = rectangle.Height;
            x--;
            y--;
            width += 2;
            height += 2;

            rectangle = new Rectangle(x, y, width, height);

            cEmblem.Rectangle = rectangle;
            using (_pen = new Pen(color))
                graphics.DrawRectangle(_pen, rectangle);
        }

        public override void ReduceObject(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox,
            Rectangle rectangle, Point[] points,
            Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawRectangle(_pen, rectangle);
            int x = rectangle.X, y = rectangle.Y, width = rectangle.Width, height = rectangle.Height;
            x++;
            y++;
            width -= 2;
            height -= 2;

            rectangle = new Rectangle(x, y, width, height);

            cEmblem.Rectangle = rectangle;
            using (_pen = new Pen(color))
                graphics.DrawRectangle(_pen, rectangle);
        }

        public override void YUp(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points, Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawRectangle(_pen, rectangle);
            int x = rectangle.X, y = rectangle.Y, width = rectangle.Width, height = rectangle.Height;
            y--;

            rectangle = new Rectangle(x, y, width, height);

            cEmblem.Rectangle = rectangle;
            using (_pen = new Pen(color))
                graphics.DrawRectangle(_pen, rectangle);
        }

        public override void YDown(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points, Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawRectangle(_pen, rectangle);
            int x = rectangle.X, y = rectangle.Y, width = rectangle.Width, height = rectangle.Height;
            y++;

            rectangle = new Rectangle(x, y, width, height);

            cEmblem.Rectangle = rectangle;
            using (_pen = new Pen(color))
                graphics.DrawRectangle(_pen, rectangle);
        }

        public override void XRight(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points,
            Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawRectangle(_pen, rectangle);
            int x = rectangle.X, y = rectangle.Y, width = rectangle.Width, height = rectangle.Height;
            x++;

            rectangle = new Rectangle(x, y, width, height);

            cEmblem.Rectangle = rectangle;
            using (_pen = new Pen(color))
                graphics.DrawRectangle(_pen, rectangle);
        }

        public override void XLeft(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points, Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawRectangle(_pen, rectangle);
            int x = rectangle.X, y = rectangle.Y, width = rectangle.Width, height = rectangle.Height;
            x--;

            rectangle = new Rectangle(x, y, width, height);

            cEmblem.Rectangle = rectangle;
            using (_pen = new Pen(color))
                graphics.DrawRectangle(_pen, rectangle);
        }

        public override void SuperYUp(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points,
            Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawRectangle(_pen, rectangle);
            int x = rectangle.X, y = rectangle.Y, width = rectangle.Width, height = rectangle.Height;
            y -= 10;

            rectangle = new Rectangle(x, y, width, height);

            cEmblem.Rectangle = rectangle;
            using (_pen = new Pen(color))
                graphics.DrawRectangle(_pen, rectangle);
        }

        public override void SuperYDown(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points,
            Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawRectangle(_pen, rectangle);
            int x = rectangle.X, y = rectangle.Y, width = rectangle.Width, height = rectangle.Height;
            y += 10;

            rectangle = new Rectangle(x, y, width, height);

            cEmblem.Rectangle = rectangle;
            using (_pen = new Pen(color))
                graphics.DrawRectangle(_pen, rectangle);
        }

        public override void SuperXRight(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points,
            Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawRectangle(_pen, rectangle);
            int x = rectangle.X, y = rectangle.Y, width = rectangle.Width, height = rectangle.Height;
            x += 10;

            rectangle = new Rectangle(x, y, width, height);

            cEmblem.Rectangle = rectangle;
            using (_pen = new Pen(color))
                graphics.DrawRectangle(_pen, rectangle);
        }

        public override void SuperXLeft(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points,
            Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawRectangle(_pen, rectangle);
            int x = rectangle.X, y = rectangle.Y, width = rectangle.Width, height = rectangle.Height;
            x -= 10;

            rectangle = new Rectangle(x, y, width, height);

            cEmblem.Rectangle = rectangle;
            using (_pen = new Pen(color))
                graphics.DrawRectangle(_pen, rectangle);
        }
    }
}