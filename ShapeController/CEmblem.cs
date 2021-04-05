using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShapeController
{
    public abstract class CEmblem
    {
        public Color Color { get; private set; }
        public string Name { get; private set; }
        public Rectangle Rectangle{ get; private set; }
        private readonly Point[] _points;

        protected CEmblem(Color color, string name, Rectangle rectangle, Point[] points)
        {
            Color = color;
            Name = name;
            Rectangle = rectangle;
            _points = points;
        }

        public Point[] GetPointsArray()
        {
            return _points;
        }

        public abstract void DrawEmblem(Graphics graphics);
        
        public abstract void HideEmblem(Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points);
        
        public abstract void ShowEmblem(Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Color color, Point[] points);
    }
}