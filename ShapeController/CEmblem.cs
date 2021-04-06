using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShapeController
{
    public abstract class CEmblem
    {
        private Point[] _points;

        public Color Color { get; private set; }
        public string Name { get; private set; }
        public Rectangle Rectangle { get; set; }
        
        protected CEmblem(Color color, string name, Rectangle rectangle, Point[] points)
        {
            Color = color;
            Name = name;
            Rectangle = rectangle;
            _points = points;
        }
        
        /*protected CEmblem(Color color, string name, Rectangle rectangle, Point[] points)
        {
            Color = color;
            Name = name;
            Rectangle = rectangle;
            _points = points;
        }*/

        public Point[] GetPointsArray()
        {
            return _points;
        }
        
        public Point[] GetPointsArray(Point[] points)
        {
            return _points = points;
        }

        public abstract void DrawEmblem(Graphics graphics);
        
        public abstract void HideEmblem(Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points);
        
        public abstract void ShowEmblem(Graphics graphics, Rectangle rectangle, Color color, Point[] points);

        public abstract void EnlargeObject(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points, Color color);
        
        public abstract void ReduceObject(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points, Color color);

        public abstract void YUp(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points, Color color);
        
        public abstract void YDown(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points, Color color);
        
        public abstract void XRight(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points, Color color);
        
        public abstract void XLeft(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points, Color color);
        
        public abstract void SuperYUp(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points, Color color);
        
        public abstract void SuperYDown(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points, Color color);
        
        public abstract void SuperXRight(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points, Color color);
        
        public abstract void SuperXLeft(CEmblem cEmblem, Graphics graphics, PictureBox pictureBox, Rectangle rectangle, Point[] points, Color color);
    }
}