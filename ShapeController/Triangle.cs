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
        private Point _point1;
        private Point _point2;
        private Point _point3;

        public Triangle(Color color, string name, Point[] points, Point point1, Point point2, Point point3) : base(
            color, name, Rectangle.Empty, points)
        {
            _color = color;
            _points = points;
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
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

        public override void ShowEmblem(Graphics graphics, Rectangle rectangle, Color color, Point[] points)
        {
            using (_pen = new Pen(color))
                graphics.DrawPolygon(_pen, points);
        }

        public override void EnlargeObject(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox,
            Rectangle rectangle, Point[] points, Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawPolygon(_pen, points);

            int x1 = _point1.X, y1 = _point1.Y, x2 = _point2.X, y2 = _point2.Y, x3 = _point3.X, y3 = _point3.Y;
            x1--;
            y1--;
            x2 += 2;
            x3--;
            y3++;

            _point1 = new Point(x1, y1);
            _point2 = new Point(x2, y2);
            _point3 = new Point(x3, y3);

            points = new Point[]
            {
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3)
            };

            var newPoints = cEmblem.GetPointsArray(points);
            using (_pen = new Pen(color))
                graphics.DrawPolygon(_pen, newPoints);
        }

        public override void ReduceObject(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox,
            Rectangle rectangle, Point[] points,
            Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawPolygon(_pen, points);

            int x1 = _point1.X, y1 = _point1.Y, x2 = _point2.X, y2 = _point2.Y, x3 = _point3.X, y3 = _point3.Y;
            x1++;
            y1++;
            x2 -= 2;
            x3++;
            y3--;

            _point1 = new Point(x1, y1);
            _point2 = new Point(x2, y2);
            _point3 = new Point(x3, y3);

            points = new Point[]
            {
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3)
            };

            var newPoints = cEmblem.GetPointsArray(points);
            using (_pen = new Pen(color))
                graphics.DrawPolygon(_pen, newPoints);
        }

        public override void YUp(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points, Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawPolygon(_pen, points);

            int x1 = _point1.X, y1 = _point1.Y, x2 = _point2.X, y2 = _point2.Y, x3 = _point3.X, y3 = _point3.Y;
            y1--;
            y2--;
            y3--;

            _point1 = new Point(x1, y1);
            _point2 = new Point(x2, y2);
            _point3 = new Point(x3, y3);

            points = new Point[]
            {
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3)
            };

            var newPoints = cEmblem.GetPointsArray(points);
            using (_pen = new Pen(color))
                graphics.DrawPolygon(_pen, newPoints);
        }

        public override void YDown(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points, Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawPolygon(_pen, points);

            int x1 = _point1.X, y1 = _point1.Y, x2 = _point2.X, y2 = _point2.Y, x3 = _point3.X, y3 = _point3.Y;
            y1++;
            y2++;
            y3++;

            _point1 = new Point(x1, y1);
            _point2 = new Point(x2, y2);
            _point3 = new Point(x3, y3);

            points = new Point[]
            {
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3)
            };

            var newPoints = cEmblem.GetPointsArray(points);
            using (_pen = new Pen(color))
                graphics.DrawPolygon(_pen, newPoints);
        }

        public override void XRight(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points,
            Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawPolygon(_pen, points);

            int x1 = _point1.X, y1 = _point1.Y, x2 = _point2.X, y2 = _point2.Y, x3 = _point3.X, y3 = _point3.Y;
            x1++;
            x2++;
            x3++;

            _point1 = new Point(x1, y1);
            _point2 = new Point(x2, y2);
            _point3 = new Point(x3, y3);

            points = new Point[]
            {
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3)
            };

            var newPoints = cEmblem.GetPointsArray(points);
            using (_pen = new Pen(color))
                graphics.DrawPolygon(_pen, newPoints);
        }

        public override void XLeft(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points, Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawPolygon(_pen, points);

            int x1 = _point1.X, y1 = _point1.Y, x2 = _point2.X, y2 = _point2.Y, x3 = _point3.X, y3 = _point3.Y;
            x1--;
            x2--;
            x3--;

            _point1 = new Point(x1, y1);
            _point2 = new Point(x2, y2);
            _point3 = new Point(x3, y3);

            points = new Point[]
            {
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3)
            };

            var newPoints = cEmblem.GetPointsArray(points);
            using (_pen = new Pen(color))
                graphics.DrawPolygon(_pen, newPoints);
        }

        public override void SuperYUp(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points,
            Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawPolygon(_pen, points);

            int x1 = _point1.X, y1 = _point1.Y, x2 = _point2.X, y2 = _point2.Y, x3 = _point3.X, y3 = _point3.Y;
            y1 -= 10;
            y2 -= 10;
            y3 -= 10;

            _point1 = new Point(x1, y1);
            _point2 = new Point(x2, y2);
            _point3 = new Point(x3, y3);

            points = new Point[]
            {
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3)
            };

            var newPoints = cEmblem.GetPointsArray(points);
            using (_pen = new Pen(color))
                graphics.DrawPolygon(_pen, newPoints);
        }

        public override void SuperYDown(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points,
            Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawPolygon(_pen, points);

            int x1 = _point1.X, y1 = _point1.Y, x2 = _point2.X, y2 = _point2.Y, x3 = _point3.X, y3 = _point3.Y;
            y1 += 10;
            y2 += 10;
            y3 += 10;

            _point1 = new Point(x1, y1);
            _point2 = new Point(x2, y2);
            _point3 = new Point(x3, y3);

            points = new Point[]
            {
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3)
            };

            var newPoints = cEmblem.GetPointsArray(points);
            using (_pen = new Pen(color))
                graphics.DrawPolygon(_pen, newPoints);
        }

        public override void SuperXRight(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points,
            Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawPolygon(_pen, points);

            int x1 = _point1.X, y1 = _point1.Y, x2 = _point2.X, y2 = _point2.Y, x3 = _point3.X, y3 = _point3.Y;
            x1 += 10;
            x2 += 10;
            x3 += 10;

            _point1 = new Point(x1, y1);
            _point2 = new Point(x2, y2);
            _point3 = new Point(x3, y3);

            points = new Point[]
            {
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3)
            };

            var newPoints = cEmblem.GetPointsArray(points);
            using (_pen = new Pen(color))
                graphics.DrawPolygon(_pen, newPoints);
        }

        public override void SuperXLeft(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle,
            Point[] points,
            Color color)
        {
            using (_pen = new Pen(pictureBox.BackColor))
                graphics.DrawPolygon(_pen, points);

            int x1 = _point1.X, y1 = _point1.Y, x2 = _point2.X, y2 = _point2.Y, x3 = _point3.X, y3 = _point3.Y;
            x1 -= 10;
            x2 -= 10;
            x3 -= 10;

            _point1 = new Point(x1, y1);
            _point2 = new Point(x2, y2);
            _point3 = new Point(x3, y3);

            points = new Point[]
            {
                new Point(x1, y1),
                new Point(x2, y2),
                new Point(x3, y3)
            };

            var newPoints = cEmblem.GetPointsArray(points);
            using (_pen = new Pen(color))
                graphics.DrawPolygon(_pen, newPoints);
        }
    }
}